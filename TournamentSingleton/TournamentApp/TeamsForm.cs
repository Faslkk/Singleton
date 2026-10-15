using System;
using System.Windows.Forms;
using TournamentLibrary;

namespace TournamentApp
{
    public partial class TeamsForm : Form
    {
        public TeamsForm()
        {
            InitializeComponent();
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {
            Logger.GetInstance().Log("Відкрито форму \"Команди\"");
            lblInfo.Text = $"DbManager: #{DbManager.GetInstance().GetHashCode():X8}   Logger: #{Logger.GetInstance().GetHashCode():X8}";
            RefreshTeams();
        }

        private void RefreshTeams()
        {
            lstTeams.Items.Clear();
            foreach (string name in DbManager.GetInstance().GetTeams())
            {
                lstTeams.Items.Add(name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                DbManager.GetInstance().AddTeam(name);
                Logger.GetInstance().Log($"Додано команду \"{name}\"");
                txtName.Clear();
                RefreshTeams();
            }
            catch (ArgumentException ex)
            {
                Logger.GetInstance().Log("Помилка додавання команди: " + ex.Message);
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtName.Focus();
        }
    }
}
