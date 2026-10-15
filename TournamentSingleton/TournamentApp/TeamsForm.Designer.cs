namespace TournamentApp
{
    partial class TeamsForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 20);
            this.lblName.Text = "Назва команди:";
            this.txtName.Location = new System.Drawing.Point(125, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 23);
            this.txtName.TabIndex = 0;
            this.btnAdd.Location = new System.Drawing.Point(303, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.lstTeams.Location = new System.Drawing.Point(12, 48);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(376, 244);
            this.lstTeams.ItemHeight = 15;
            this.lstTeams.TabIndex = 2;
            this.lblInfo.Location = new System.Drawing.Point(12, 300);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(376, 20);
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 330);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "TeamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Команди";
            this.AcceptButton = this.btnAdd;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Load += new System.EventHandler(this.TeamsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Label lblInfo;
    }
}
