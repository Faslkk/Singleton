using System;
using System.Windows.Forms;
using TournamentLibrary;

namespace TournamentApp
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            Logger.GetInstance().Log("Відкрито форму \"Журнал дій\"");
            lblInfo.Text = $"Logger: #{Logger.GetInstance().GetHashCode():X8}   DocumentSaver: #{DocumentSaver.GetInstance().GetHashCode():X8}";
            LoadData();
        }

        private void LoadData()
        {
            txtLog.Text = Logger.GetInstance().ReadAll();
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.ScrollToCaret();

            lstDocuments.Items.Clear();
            foreach (string file in DocumentSaver.GetInstance().GetSavedDocuments())
            {
                lstDocuments.Items.Add(file);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Logger.GetInstance().Log("Оновлено журнал дій");
            LoadData();
        }
    }
}
