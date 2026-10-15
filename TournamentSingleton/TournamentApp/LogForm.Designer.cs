namespace TournamentApp
{
    partial class LogForm
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lstDocuments = new System.Windows.Forms.ListBox();
            this.lblDocuments = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.txtLog.Location = new System.Drawing.Point(12, 12);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(600, 250);
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtLog.Multiline = true;
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.TabIndex = 0;
            this.lblDocuments.Location = new System.Drawing.Point(12, 270);
            this.lblDocuments.Name = "lblDocuments";
            this.lblDocuments.Size = new System.Drawing.Size(400, 20);
            this.lblDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDocuments.Text = "Збережені документи (DocumentSaver):";
            this.lstDocuments.Location = new System.Drawing.Point(12, 292);
            this.lstDocuments.Name = "lstDocuments";
            this.lstDocuments.Size = new System.Drawing.Size(600, 94);
            this.lstDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDocuments.ItemHeight = 15;
            this.lstDocuments.TabIndex = 1;
            this.btnRefresh.Location = new System.Drawing.Point(12, 394);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 30);
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Оновити";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.lblInfo.Location = new System.Drawing.Point(150, 401);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(462, 20);
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.ForeColor = System.Drawing.Color.DimGray;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 434);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDocuments);
            this.Controls.Add(this.lstDocuments);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtLog);
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Журнал дій";
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Load += new System.EventHandler(this.LogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lstDocuments;
        private System.Windows.Forms.Label lblDocuments;
        private System.Windows.Forms.Label lblInfo;
    }
}
