namespace MunicipalServicesApp
{
    partial class ReportIssuesForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.lblAttachmentStatus = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpEngagement = new System.Windows.Forms.GroupBox();
            this.lblEngagementStatus = new System.Windows.Forms.Label();
            this.prgEngagement = new System.Windows.Forms.ProgressBar();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpEngagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(784, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(230, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(325, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Report Municipal Service Issues";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocation.Location = new System.Drawing.Point(40, 95);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(185, 19);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location (Street/Ward/Area):";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(240, 92);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(480, 25);
            this.txtLocation.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(40, 135);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(117, 19);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Service Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(240, 132);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(240, 25);
            this.cmbCategory.TabIndex = 4;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPriority.Location = new System.Drawing.Point(490, 135);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(65, 19);
            this.lblPriority.TabIndex = 5;
            this.lblPriority.Text = "Priority:";
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "1 - Critical",
            "2 - High",
            "3 - Medium",
            "4 - Low"});
            this.cmbPriority.Location = new System.Drawing.Point(560, 132);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(160, 25);
            this.cmbPriority.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(40, 175);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 19);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Issue Description:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbDescription.Location = new System.Drawing.Point(240, 172);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(480, 100);
            this.rtbDescription.TabIndex = 8;
            this.rtbDescription.Text = "";
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAttachMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachMedia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnAttachMedia.ForeColor = System.Drawing.Color.White;
            this.btnAttachMedia.Location = new System.Drawing.Point(240, 285);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(160, 35);
            this.btnAttachMedia.TabIndex = 9;
            this.btnAttachMedia.Text = "📎 Attach Media/Doc";
            this.btnAttachMedia.UseVisualStyleBackColor = false;
            this.btnAttachMedia.Click += new System.EventHandler(this.btnAttachMedia_Click);
            // 
            // lblAttachmentStatus
            // 
            this.lblAttachmentStatus.AutoSize = true;
            this.lblAttachmentStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblAttachmentStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblAttachmentStatus.Location = new System.Drawing.Point(415, 295);
            this.lblAttachmentStatus.Name = "lblAttachmentStatus";
            this.lblAttachmentStatus.Size = new System.Drawing.Size(89, 15);
            this.lblAttachmentStatus.TabIndex = 10;
            this.lblAttachmentStatus.Text = "No file attached";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(240, 335);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(480, 45);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit Issue Report";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpEngagement
            // 
            this.grpEngagement.Controls.Add(this.lblEngagementStatus);
            this.grpEngagement.Controls.Add(this.prgEngagement);
            this.grpEngagement.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpEngagement.Location = new System.Drawing.Point(40, 395);
            this.grpEngagement.Name = "grpEngagement";
            this.grpEngagement.Size = new System.Drawing.Size(680, 80);
            this.grpEngagement.TabIndex = 12;
            this.grpEngagement.TabStop = false;
            this.grpEngagement.Text = "Civic Participation Tracker (Interactive Campaign)";
            // 
            // lblEngagementStatus
            // 
            this.lblEngagementStatus.AutoSize = true;
            this.lblEngagementStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngagementStatus.Location = new System.Drawing.Point(20, 50);
            this.lblEngagementStatus.Name = "lblEngagementStatus";
            this.lblEngagementStatus.Size = new System.Drawing.Size(256, 17);
            this.lblEngagementStatus.TabIndex = 1;
            this.lblEngagementStatus.Text = "Reports Submitted: 0 | Status: Civic Observer";
            // 
            // prgEngagement
            // 
            this.prgEngagement.Location = new System.Drawing.Point(20, 25);
            this.prgEngagement.Name = "prgEngagement";
            this.prgEngagement.Size = new System.Drawing.Size(640, 20);
            this.prgEngagement.TabIndex = 0;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(40, 490);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(160, 35);
            this.btnBackToMenu.TabIndex = 13;
            this.btnBackToMenu.Text = "⬅ Main Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(784, 545);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.grpEngagement);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAttachmentStatus);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportIssuesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal Services - Report Issues";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpEngagement.ResumeLayout(false);
            this.grpEngagement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Label lblAttachmentStatus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpEngagement;
        private System.Windows.Forms.ProgressBar prgEngagement;
        private System.Windows.Forms.Label lblEngagementStatus;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}
