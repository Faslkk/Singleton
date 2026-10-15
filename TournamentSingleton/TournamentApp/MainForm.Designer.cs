namespace TournamentApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvStandings = new System.Windows.Forms.DataGridView();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnMatches = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.lblInstances = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.dgvStandings.Location = new System.Drawing.Point(12, 12);
            this.dgvStandings.Name = "dgvStandings";
            this.dgvStandings.Size = new System.Drawing.Size(720, 330);
            this.dgvStandings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStandings.AllowUserToAddRows = false;
            this.dgvStandings.AllowUserToDeleteRows = false;
            this.dgvStandings.AllowUserToResizeRows = false;
            this.dgvStandings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStandings.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStandings.MultiSelect = false;
            this.dgvStandings.ReadOnly = true;
            this.dgvStandings.RowHeadersVisible = false;
            this.dgvStandings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStandings.TabIndex = 0;
            this.btnTeams.Location = new System.Drawing.Point(12, 354);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(170, 34);
            this.btnTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTeams.TabIndex = 1;
            this.btnTeams.Text = "Команди";
            this.btnTeams.UseVisualStyleBackColor = true;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            this.btnMatches.Location = new System.Drawing.Point(194, 354);
            this.btnMatches.Name = "btnMatches";
            this.btnMatches.Size = new System.Drawing.Size(170, 34);
            this.btnMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMatches.TabIndex = 2;
            this.btnMatches.Text = "Матчі";
            this.btnMatches.UseVisualStyleBackColor = true;
            this.btnMatches.Click += new System.EventHandler(this.btnMatches_Click);
            this.btnSave.Location = new System.Drawing.Point(376, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 34);
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Зберегти таблицю";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnLog.Location = new System.Drawing.Point(558, 354);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(170, 34);
            this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Журнал дій";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            this.lblInstances.Location = new System.Drawing.Point(12, 398);
            this.lblInstances.Name = "lblInstances";
            this.lblInstances.Size = new System.Drawing.Size(720, 40);
            this.lblInstances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstances.ForeColor = System.Drawing.Color.DimGray;
            this.lblInstances.TabIndex = 5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 447);
            this.Controls.Add(this.lblInstances);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMatches);
            this.Controls.Add(this.btnTeams);
            this.Controls.Add(this.dgvStandings);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Турнірна таблиця";
            this.MinimumSize = new System.Drawing.Size(760, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvStandings;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.Button btnMatches;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label lblInstances;
    }
}
