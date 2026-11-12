namespace MunicipalServicesApp
{
    partial class MainMenu
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
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnLocalEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(912, 123);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(253, 71);
            this.lblHeaderSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(383, 25);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Integrated South African Citizen Portal (PoE)";
            this.lblHeaderSubtitle.Click += new System.EventHandler(this.lblHeaderSubtitle_Click);
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(193, 22);
            this.lblHeaderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(492, 46);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Municipal Services Application";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblInstructions.Location = new System.Drawing.Point(240, 160);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(428, 25);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Please select a municipal service task from below:";
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReportIssues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.ForeColor = System.Drawing.Color.White;
            this.btnReportIssues.Location = new System.Drawing.Point(256, 215);
            this.btnReportIssues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(400, 68);
            this.btnReportIssues.TabIndex = 2;
            this.btnReportIssues.Text = "1. Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLocalEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEvents.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalEvents.ForeColor = System.Drawing.Color.White;
            this.btnLocalEvents.Location = new System.Drawing.Point(256, 308);
            this.btnLocalEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.Size = new System.Drawing.Size(400, 68);
            this.btnLocalEvents.TabIndex = 3;
            this.btnLocalEvents.Text = "2. Local Events && Announcements";
            this.btnLocalEvents.UseVisualStyleBackColor = false;
            this.btnLocalEvents.Click += new System.EventHandler(this.btnLocalEvents_Click);
            // 
            // btnServiceStatus
            // 
            this.btnServiceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnServiceStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServiceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceStatus.ForeColor = System.Drawing.Color.White;
            this.btnServiceStatus.Location = new System.Drawing.Point(256, 400);
            this.btnServiceStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Size = new System.Drawing.Size(400, 68);
            this.btnServiceStatus.TabIndex = 4;
            this.btnServiceStatus.Text = "3. Service Request Status";
            this.btnServiceStatus.UseVisualStyleBackColor = false;
            this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.Color.Gray;
            this.lblFooter.Location = new System.Drawing.Point(0, 517);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(912, 37);
            this.lblFooter.TabIndex = 5;
            this.lblFooter.Text = "Powered by C# .NET Framework & Advanced Data Structures | IIE PROG7312 / AAPD7112" +
    "";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(912, 554);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal Services Application - Main Menu";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Label lblFooter;
    }
}
