using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace TournamentLibrary
{
    public sealed class DbManager
    {
        private static DbManager instance;
        private static readonly object locker = new object();

        private readonly List<string> teams = new List<string>();
        private readonly List<Match> matches = new List<Match>();

        public static int CreatedCount { get; private set; }
        public string FilePath { get; private set; }

        private DbManager()
        {
            CreatedCount++;
            FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tournament_db.txt");
            Load();
        }

        public static DbManager GetInstance()
        {
            lock (locker)
            {
                if (instance == null)
                {
                    instance = new DbManager();
                }
                return instance;
            }
        }

        public List<string> GetTeams()
        {
            return teams.OrderBy(t => t).ToList();
        }

        public List<Match> GetMatches()
        {
            return matches.ToList();
        }

        public void AddTeam(string name)
        {
            name = (name ?? "").Trim();
            if (name.Length == 0)
            {
                throw new ArgumentException("Назва команди не може бути порожньою.");
            }
            if (name.Contains("|"))
            {
                throw new ArgumentException("Назва команди не може містити символ '|'.");
            }
            if (teams.Any(t => string.Equals(t, name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Команда \"{name}\" вже існує.");
            }
            teams.Add(name);
            Save();
        }

        public void AddMatch(string homeTeam, string awayTeam, int homeGoals, int awayGoals)
        {
            if (string.IsNullOrEmpty(homeTeam) || string.IsNullOrEmpty(awayTeam))
            {
                throw new ArgumentException("Оберіть обидві команди.");
            }
            if (homeTeam == awayTeam)
            {
                throw new ArgumentException("Команда не може грати сама з собою.");
            }
            if (homeGoals < 0 || awayGoals < 0)
            {
                throw new ArgumentException("Кількість голів не може бути від'ємною.");
            }
            matches.Add(new Match(homeTeam, awayTeam, homeGoals, awayGoals, DateTime.Now));
            Save();
        }

        public List<Team> GetStandings()
        {
            Dictionary<string, Team> table = new Dictionary<string, Team>();
            foreach (string name in teams)
            {
                table[name] = new Team(name);
            }

            foreach (Match m in matches)
            {
                if (!table.ContainsKey(m.HomeTeam) || !table.ContainsKey(m.AwayTeam))
                {
                    continue;
                }
                Team home = table[m.HomeTeam];
                Team away = table[m.AwayTeam];

                home.Played++;
                away.Played++;
                home.GoalsFor += m.HomeGoals;
                home.GoalsAgainst += m.AwayGoals;
                away.GoalsFor += m.AwayGoals;
                away.GoalsAgainst += m.HomeGoals;

                if (m.HomeGoals > m.AwayGoals)
                {
                    home.Wins++;
                    away.Losses++;
                }
                else if (m.HomeGoals < m.AwayGoals)
                {
                    away.Wins++;
                    home.Losses++;
                }
                else
                {
                    home.Draws++;
                    away.Draws++;
                }
            }

            return table.Values
                .OrderByDescending(t => t.Points)
                .ThenByDescending(t => t.GoalDifference)
                .ThenByDescending(t => t.GoalsFor)
                .ThenBy(t => t.Name)
                .ToList();
        }

        private void Load()
        {
            if (!File.Exists(FilePath))
            {
                return;
            }

            foreach (string line in File.ReadAllLines(FilePath, Encoding.UTF8))
            {
                string[] parts = line.Split('|');
                if (parts[0] == "TEAM" && parts.Length == 2)
                {
                    teams.Add(parts[1]);
                }
                else if (parts[0] == "MATCH" && parts.Length == 6)
                {
                    DateTime date = DateTime.Parse(parts[5], CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                    matches.Add(new Match(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), date));
                }
            }
        }

        private void Save()
        {
            List<string> lines = new List<string>();
            foreach (string name in teams)
            {
                lines.Add("TEAM|" + name);
            }
            foreach (Match m in matches)
            {
                lines.Add($"MATCH|{m.HomeTeam}|{m.AwayTeam}|{m.HomeGoals}|{m.AwayGoals}|{m.Date.ToString("o", CultureInfo.InvariantCulture)}");
            }
            File.WriteAllLines(FilePath, lines, Encoding.UTF8);
        }
    }
}
