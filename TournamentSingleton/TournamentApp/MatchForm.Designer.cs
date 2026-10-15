namespace TournamentApp
{
    partial class MatchForm
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
            this.lblHome = new System.Windows.Forms.Label();
            this.cmbHome = new System.Windows.Forms.ComboBox();
            this.numHome = new System.Windows.Forms.NumericUpDown();
            this.lblAway = new System.Windows.Forms.Label();
            this.cmbAway = new System.Windows.Forms.ComboBox();
            this.numAway = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstMatches = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAway)).BeginInit();
            this.SuspendLayout();
            this.lblHome.Location = new System.Drawing.Point(12, 15);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(90, 20);
            this.lblHome.Text = "Господарі:";
            this.cmbHome.Location = new System.Drawing.Point(105, 12);
            this.cmbHome.Name = "cmbHome";
            this.cmbHome.Size = new System.Drawing.Size(250, 23);
            this.cmbHome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHome.TabIndex = 0;
            this.numHome.Location = new System.Drawing.Point(365, 12);
            this.numHome.Name = "numHome";
            this.numHome.Size = new System.Drawing.Size(60, 23);
            this.numHome.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            this.numHome.TabIndex = 1;
            this.lblAway.Location = new System.Drawing.Point(12, 48);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(90, 20);
            this.lblAway.Text = "Гості:";
            this.cmbAway.Location = new System.Drawing.Point(105, 45);
            this.cmbAway.Name = "cmbAway";
            this.cmbAway.Size = new System.Drawing.Size(250, 23);
            this.cmbAway.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAway.TabIndex = 2;
            this.numAway.Location = new System.Drawing.Point(365, 45);
            this.numAway.Name = "numAway";
            this.numAway.Size = new System.Drawing.Size(60, 23);
            this.numAway.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            this.numAway.TabIndex = 3;
            this.btnAdd.Location = new System.Drawing.Point(105, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додати результат матчу";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.lstMatches.Location = new System.Drawing.Point(12, 122);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(456, 229);
            this.lstMatches.ItemHeight = 15;
            this.lstMatches.TabIndex = 5;
            this.lblInfo.Location = new System.Drawing.Point(12, 358);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(456, 20);
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 388);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lstMatches);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numAway);
            this.Controls.Add(this.cmbAway);
            this.Controls.Add(this.lblAway);
            this.Controls.Add(this.numHome);
            this.Controls.Add(this.cmbHome);
            this.Controls.Add(this.lblHome);
            this.Name = "MatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Матчі";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Load += new System.EventHandler(this.MatchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.ComboBox cmbHome;
        private System.Windows.Forms.NumericUpDown numHome;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.ComboBox cmbAway;
        private System.Windows.Forms.NumericUpDown numAway;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstMatches;
        private System.Windows.Forms.Label lblInfo;
    }
}
