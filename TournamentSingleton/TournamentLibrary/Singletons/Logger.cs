using System;
using System.IO;
using System.Text;

namespace TournamentLibrary
{
    public sealed class Logger
    {
        private static Logger instance;
        private static readonly object locker = new object();

        public static int CreatedCount { get; private set; }
        public string FilePath { get; private set; }

        private Logger()
        {
            CreatedCount++;
            FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");
        }

        public static Logger GetInstance()
        {
            lock (locker)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }

        public void Log(string message)
        {
            lock (locker)
            {
                string line = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] {message}";
                File.AppendAllText(FilePath, line + Environment.NewLine, Encoding.UTF8);
            }
        }

        public string ReadAll()
        {
            lock (locker)
            {
                if (!File.Exists(FilePath))
                {
                    return "";
                }
                return File.ReadAllText(FilePath, Encoding.UTF8);
            }
        }
    }
}
