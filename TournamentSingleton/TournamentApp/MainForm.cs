using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TournamentLibrary;

namespace TournamentApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateColumns();
        }

        private void CreateColumns()
        {
            dgvStandings.Columns.Add("Place", "№");
            dgvStandings.Columns.Add("Name", "Команда");
            dgvStandings.Columns.Add("Played", "І");
            dgvStandings.Columns.Add("Wins", "В");
            dgvStandings.Columns.Add("Draws", "Н");
            dgvStandings.Columns.Add("Losses", "П");
            dgvStandings.Columns.Add("Goals", "Голи");
            dgvStandings.Columns.Add("Diff", "Різниця");
            dgvStandings.Columns.Add("Points", "Очки");

            dgvStandings.Columns["Name"].FillWeight = 300;
            foreach (DataGridViewColumn column in dgvStandings.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (column.Name != "Name")
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.GetInstance().Log("Відкрито головну форму (турнірна таблиця)");
            RefreshStandings();
        }

        private void RefreshStandings()
        {
            dgvStandings.Rows.Clear();
            List<Team> standings = DbManager.GetInstance().GetStandings();
            int place = 1;
            foreach (Team t in standings)
            {
                string diff = t.GoalDifference > 0 ? "+" + t.GoalDifference : t.GoalDifference.ToString();
                dgvStandings.Rows.Add(place, t.Name, t.Played, t.Wins, t.Draws, t.Losses,
                    t.GoalsFor + ":" + t.GoalsAgainst, diff, t.Points);
                place++;
            }
            ShowInstances();
        }

        private void ShowInstances()
        {
            lblInstances.Text =
                $"DbManager: #{DbManager.GetInstance().GetHashCode():X8} (створено {DbManager.CreatedCount})   " +
                $"DocumentSaver: #{DocumentSaver.GetInstance().GetHashCode():X8} (створено {DocumentSaver.CreatedCount})   " +
                $"Logger: #{Logger.GetInstance().GetHashCode():X8} (створено {Logger.CreatedCount})";
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            using (TeamsForm form = new TeamsForm())
            {
                form.ShowDialog(this);
            }
            RefreshStandings();
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            using (MatchForm form = new MatchForm())
            {
                form.ShowDialog(this);
            }
            RefreshStandings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = DocumentSaver.GetInstance().SaveStandings(DbManager.GetInstance().GetStandings());
                Logger.GetInstance().Log("Збережено турнірну таблицю у файл " + path);
                MessageBox.Show("Таблицю збережено:\n" + path, "Збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.GetInstance().Log("Помилка збереження таблиці: " + ex.Message);
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            using (LogForm form = new LogForm())
            {
                form.ShowDialog(this);
            }
        }
    }
}
