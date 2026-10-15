using System;
using System.Windows.Forms;
using TournamentLibrary;

namespace TournamentApp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Logger.GetInstance().Log("Програму запущено");
            Application.Run(new MainForm());
            Logger.GetInstance().Log("Програму закрито");
        }
    }
}
