using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TournamentLibrary;

namespace TournamentApp
{
    public partial class MatchForm : Form
    {
        public MatchForm()
        {
            InitializeComponent();
        }

        private void MatchForm_Load(object sender, EventArgs e)
        {
            Logger.GetInstance().Log("Відкрито форму \"Матчі\"");
            lblInfo.Text = $"DbManager: #{DbManager.GetInstance().GetHashCode():X8}   Logger: #{Logger.GetInstance().GetHashCode():X8}";

            List<string> teams = DbManager.GetInstance().GetTeams();
            cmbHome.Items.AddRange(teams.ToArray());
            cmbAway.Items.AddRange(teams.ToArray());
            if (teams.Count >= 2)
            {
                cmbHome.SelectedIndex = 0;
                cmbAway.SelectedIndex = 1;
            }
            RefreshMatches();
        }

        private void RefreshMatches()
        {
            lstMatches.Items.Clear();
            foreach (Match m in DbManager.GetInstance().GetMatches())
            {
                lstMatches.Items.Add(m.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string home = cmbHome.SelectedItem as string;
            string away = cmbAway.SelectedItem as string;
            int homeGoals = (int)numHome.Value;
            int awayGoals = (int)numAway.Value;

            try
            {
                DbManager.GetInstance().AddMatch(home, away, homeGoals, awayGoals);
                Logger.GetInstance().Log($"Додано матч: {home} {homeGoals}:{awayGoals} {away}");
                numHome.Value = 0;
                numAway.Value = 0;
                RefreshMatches();
            }
            catch (ArgumentException ex)
            {
                Logger.GetInstance().Log("Помилка додавання матчу: " + ex.Message);
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
