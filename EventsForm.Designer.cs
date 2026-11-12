namespace MunicipalServicesApp
{
    partial class EventsForm
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
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeywordSearch = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.dtpDateFilter = new System.Windows.Forms.DateTimePicker();
            this.chkEnableDateFilter = new System.Windows.Forms.CheckBox();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lvwEvents = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblResultCount = new System.Windows.Forms.Label();
            this.rtbEventDetails = new System.Windows.Forms.RichTextBox();
            this.grpAnnouncements = new System.Windows.Forms.GroupBox();
            this.lstAnnouncementsQueue = new System.Windows.Forms.ListBox();
            this.grpRecommendations = new System.Windows.Forms.GroupBox();
            this.lstRecommendations = new System.Windows.Forms.ListBox();
            this.lblSearchHistoryStatus = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpFilters.SuspendLayout();
            this.grpAnnouncements.SuspendLayout();
            this.grpRecommendations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(310, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(364, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Local Events and Announcements";
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.btnResetFilters);
            this.grpFilters.Controls.Add(this.btnSearch);
            this.grpFilters.Controls.Add(this.txtKeywordSearch);
            this.grpFilters.Controls.Add(this.lblKeyword);
            this.grpFilters.Controls.Add(this.dtpDateFilter);
            this.grpFilters.Controls.Add(this.chkEnableDateFilter);
            this.grpFilters.Controls.Add(this.cmbCategoryFilter);
            this.grpFilters.Controls.Add(this.lblCategory);
            this.grpFilters.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpFilters.Location = new System.Drawing.Point(20, 70);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(944, 75);
            this.grpFilters.TabIndex = 1;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Event Search && Filter Controls (SortedDictionary && HashSet)";
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnResetFilters.ForeColor = System.Drawing.Color.White;
            this.btnResetFilters.Location = new System.Drawing.Point(840, 27);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(85, 30);
            this.btnResetFilters.TabIndex = 7;
            this.btnResetFilters.Text = "Reset All";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(740, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeywordSearch
            // 
            this.txtKeywordSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKeywordSearch.Location = new System.Drawing.Point(575, 30);
            this.txtKeywordSearch.Name = "txtKeywordSearch";
            this.txtKeywordSearch.Size = new System.Drawing.Size(150, 23);
            this.txtKeywordSearch.TabIndex = 5;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.Location = new System.Drawing.Point(515, 33);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(56, 15);
            this.lblKeyword.TabIndex = 4;
            this.lblKeyword.Text = "Keyword:";
            // 
            // dtpDateFilter
            // 
            this.dtpDateFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFilter.Location = new System.Drawing.Point(395, 30);
            this.dtpDateFilter.Name = "dtpDateFilter";
            this.dtpDateFilter.Size = new System.Drawing.Size(110, 23);
            this.dtpDateFilter.TabIndex = 3;
            // 
            // chkEnableDateFilter
            // 
            this.chkEnableDateFilter.AutoSize = true;
            this.chkEnableDateFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkEnableDateFilter.Location = new System.Drawing.Point(295, 32);
            this.chkEnableDateFilter.Name = "chkEnableDateFilter";
            this.chkEnableDateFilter.Size = new System.Drawing.Size(95, 19);
            this.chkEnableDateFilter.TabIndex = 2;
            this.chkEnableDateFilter.Text = "Filter by Date:";
            this.chkEnableDateFilter.UseVisualStyleBackColor = true;
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(85, 30);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(195, 23);
            this.cmbCategoryFilter.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(20, 33);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            // 
            // lvwEvents
            // 
            this.lvwEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTitle,
            this.colCategory,
            this.colDate,
            this.colLocation,
            this.colType});
            this.lvwEvents.FullRowSelect = true;
            this.lvwEvents.GridLines = true;
            this.lvwEvents.HideSelection = false;
            this.lvwEvents.Location = new System.Drawing.Point(20, 155);
            this.lvwEvents.MultiSelect = false;
            this.lvwEvents.Name = "lvwEvents";
            this.lvwEvents.Size = new System.Drawing.Size(580, 220);
            this.lvwEvents.TabIndex = 2;
            this.lvwEvents.UseCompatibleStateImageBehavior = false;
            this.lvwEvents.View = System.Windows.Forms.View.Details;
            this.lvwEvents.SelectedIndexChanged += new System.EventHandler(this.lvwEvents_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 50;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Event Title";
            this.colTitle.Width = 170;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 120;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 80;
            // 
            // colLocation
            // 
            this.colLocation.Text = "Location";
            this.colLocation.Width = 100;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 55;
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblResultCount.Location = new System.Drawing.Point(20, 380);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(126, 15);
            this.lblResultCount.TabIndex = 3;
            this.lblResultCount.Text = "Total Events Displayed: 0";
            // 
            // rtbEventDetails
            // 
            this.rtbEventDetails.BackColor = System.Drawing.Color.White;
            this.rtbEventDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbEventDetails.Location = new System.Drawing.Point(615, 155);
            this.rtbEventDetails.Name = "rtbEventDetails";
            this.rtbEventDetails.ReadOnly = true;
            this.rtbEventDetails.Size = new System.Drawing.Size(349, 220);
            this.rtbEventDetails.TabIndex = 4;
            this.rtbEventDetails.Text = "Select an event from the list to view comprehensive details...";
            // 
            // grpAnnouncements
            // 
            this.grpAnnouncements.Controls.Add(this.lstAnnouncementsQueue);
            this.grpAnnouncements.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpAnnouncements.Location = new System.Drawing.Point(20, 400);
            this.grpAnnouncements.Name = "grpAnnouncements";
            this.grpAnnouncements.Size = new System.Drawing.Size(944, 100);
            this.grpAnnouncements.TabIndex = 5;
            this.grpAnnouncements.TabStop = false;
            this.grpAnnouncements.Text = "Urgent Municipal Announcements Broadcast (Queue FIFO Structure)";
            // 
            // lstAnnouncementsQueue
            // 
            this.lstAnnouncementsQueue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstAnnouncementsQueue.FormattingEnabled = true;
            this.lstAnnouncementsQueue.ItemHeight = 15;
            this.lstAnnouncementsQueue.Location = new System.Drawing.Point(15, 25);
            this.lstAnnouncementsQueue.Name = "lstAnnouncementsQueue";
            this.lstAnnouncementsQueue.Size = new System.Drawing.Size(914, 64);
            this.lstAnnouncementsQueue.TabIndex = 0;
            // 
            // grpRecommendations
            // 
            this.grpRecommendations.Controls.Add(this.lstRecommendations);
            this.grpRecommendations.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpRecommendations.Location = new System.Drawing.Point(20, 505);
            this.grpRecommendations.Name = "grpRecommendations";
            this.grpRecommendations.Size = new System.Drawing.Size(944, 105);
            this.grpRecommendations.TabIndex = 6;
            this.grpRecommendations.TabStop = false;
            this.grpRecommendations.Text = "Smart Recommendation Engine (Stack History Pattern Analysis)";
            // 
            // lstRecommendations
            // 
            this.lstRecommendations.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstRecommendations.ForeColor = System.Drawing.Color.DarkBlue;
            this.lstRecommendations.FormattingEnabled = true;
            this.lstRecommendations.ItemHeight = 15;
            this.lstRecommendations.Location = new System.Drawing.Point(15, 25);
            this.lstRecommendations.Name = "lstRecommendations";
            this.lstRecommendations.Size = new System.Drawing.Size(914, 64);
            this.lstRecommendations.TabIndex = 0;
            // 
            // lblSearchHistoryStatus
            // 
            this.lblSearchHistoryStatus.AutoSize = true;
            this.lblSearchHistoryStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSearchHistoryStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSearchHistoryStatus.Location = new System.Drawing.Point(20, 615);
            this.lblSearchHistoryStatus.Name = "lblSearchHistoryStatus";
            this.lblSearchHistoryStatus.Size = new System.Drawing.Size(326, 15);
            this.lblSearchHistoryStatus.TabIndex = 7;
            this.lblSearchHistoryStatus.Text = "Search History (Stack LIFO): No search queries logged yet.";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(824, 615);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(140, 30);
            this.btnBackToMenu.TabIndex = 8;
            this.btnBackToMenu.Text = "⬅ Main Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(984, 660);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblSearchHistoryStatus);
            this.Controls.Add(this.grpRecommendations);
            this.Controls.Add(this.grpAnnouncements);
            this.Controls.Add(this.rtbEventDetails);
            this.Controls.Add(this.lblResultCount);
            this.Controls.Add(this.lvwEvents);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal Services - Local Events and Announcements";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.grpAnnouncements.ResumeLayout(false);
            this.grpRecommendations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.CheckBox chkEnableDateFilter;
        private System.Windows.Forms.DateTimePicker dtpDateFilter;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.TextBox txtKeywordSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.ListView lvwEvents;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colLocation;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.RichTextBox rtbEventDetails;
        private System.Windows.Forms.GroupBox grpAnnouncements;
        private System.Windows.Forms.ListBox lstAnnouncementsQueue;
        private System.Windows.Forms.GroupBox grpRecommendations;
        private System.Windows.Forms.ListBox lstRecommendations;
        private System.Windows.Forms.Label lblSearchHistoryStatus;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}
