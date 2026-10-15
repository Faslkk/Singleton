using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TournamentLibrary
{
    public sealed class DocumentSaver
    {
        private static DocumentSaver instance;
        private static readonly object locker = new object();

        public static int CreatedCount { get; private set; }
        public string FolderPath { get; private set; }

        private DocumentSaver()
        {
            CreatedCount++;
            FolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Documents");
            Directory.CreateDirectory(FolderPath);
        }

        public static DocumentSaver GetInstance()
        {
            lock (locker)
            {
                if (instance == null)
                {
                    instance = new DocumentSaver();
                }
                return instance;
            }
        }

        public string SaveStandings(List<Team> standings)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Турнірна таблиця станом на {DateTime.Now:dd.MM.yyyy HH:mm}");
            sb.AppendLine();
            sb.AppendLine(string.Format("{0,-3} {1,-20} {2,3} {3,3} {4,3} {5,3} {6,7} {7,5} {8,5}",
                "№", "Команда", "І", "В", "Н", "П", "Голи", "Різн", "Очки"));
            sb.AppendLine(new string('-', 62));

            int place = 1;
            foreach (Team t in standings)
            {
                sb.AppendLine(string.Format("{0,-3} {1,-20} {2,3} {3,3} {4,3} {5,3} {6,7} {7,5} {8,5}",
                    place, t.Name, t.Played, t.Wins, t.Draws, t.Losses,
                    t.GoalsFor + ":" + t.GoalsAgainst, t.GoalDifference, t.Points));
                place++;
            }

            string fileName = $"Standings_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string path = Path.Combine(FolderPath, fileName);
            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
            return path;
        }

        public List<string> GetSavedDocuments()
        {
            return Directory.GetFiles(FolderPath, "*.txt")
                .Select(Path.GetFileName)
                .OrderByDescending(f => f)
                .ToList();
        }
    }
}
