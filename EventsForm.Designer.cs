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
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.chkEnableDateFilter = new System.Windows.Forms.CheckBox();
            this.dtpDateFilter = new System.Windows.Forms.DateTimePicker();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeywordSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
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
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(20, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(438, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Local Events and Announcements (Part 2)";
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
            this.grpFilters.Location = new System.Drawing.Point(20, 75);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(944, 90);
            this.grpFilters.TabIndex = 1;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = " Search & Filter Local Events (SortedDictionary & Set Integration) ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lblCategory.Location = new System.Drawing.Point(15, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(91, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category (Set):";
            // 
            // cmbCategoryFilter
            // 
            this.cmbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategoryFilter.FormattingEnabled = true;
            this.cmbCategoryFilter.Location = new System.Drawing.Point(15, 45);
            this.cmbCategoryFilter.Name = "cmbCategoryFilter";
            this.cmbCategoryFilter.Size = new System.Drawing.Size(180, 23);
            this.cmbCategoryFilter.TabIndex = 1;
            // 
            // chkEnableDateFilter
            // 
            this.chkEnableDateFilter.AutoSize = true;
            this.chkEnableDateFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkEnableDateFilter.Location = new System.Drawing.Point(215, 24);
            this.chkEnableDateFilter.Name = "chkEnableDateFilter";
            this.chkEnableDateFilter.Size = new System.Drawing.Size(117, 19);
            this.chkEnableDateFilter.TabIndex = 2;
            this.chkEnableDateFilter.Text = "Filter by Date:";
            this.chkEnableDateFilter.UseVisualStyleBackColor = true;
            // 
            // dtpDateFilter
            // 
            this.dtpDateFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFilter.Location = new System.Drawing.Point(215, 45);
            this.dtpDateFilter.Name = "dtpDateFilter";
            this.dtpDateFilter.Size = new System.Drawing.Size(130, 23);
            this.dtpDateFilter.TabIndex = 3;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKeyword.Location = new System.Drawing.Point(365, 25);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(115, 15);
            this.lblKeyword.TabIndex = 4;
            this.lblKeyword.Text = "Keyword Search:";
            // 
            // txtKeywordSearch
            // 
            this.txtKeywordSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKeywordSearch.Location = new System.Drawing.Point(365, 45);
            this.txtKeywordSearch.Name = "txtKeywordSearch";
            this.txtKeywordSearch.Size = new System.Drawing.Size(220, 23);
            this.txtKeywordSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(610, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "🔍 Search Events";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnResetFilters.ForeColor = System.Drawing.Color.White;
            this.btnResetFilters.Location = new System.Drawing.Point(760, 40);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(160, 32);
            this.btnResetFilters.TabIndex = 7;
            this.btnResetFilters.Text = "🔄 Reset All Filters";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
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
            this.lvwEvents.Location = new System.Drawing.Point(20, 175);
            this.lvwEvents.MultiSelect = false;
            this.lvwEvents.Name = "lvwEvents";
            this.lvwEvents.Size = new System.Drawing.Size(580, 210);
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
            this.colTitle.Text = "Event / Announcement Title";
            this.colTitle.Width = 180;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 110;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 85;
            // 
            // colLocation
            // 
            this.colLocation.Text = "Location";
            this.colLocation.Width = 95;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 60;
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblResultCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblResultCount.Location = new System.Drawing.Point(20, 390);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(185, 15);
            this.lblResultCount.TabIndex = 3;
            this.lblResultCount.Text = "Showing events from SortedDictionary.";
            // 
            // rtbEventDetails
            // 
            this.rtbEventDetails.BackColor = System.Drawing.Color.White;
            this.rtbEventDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbEventDetails.Location = new System.Drawing.Point(615, 175);
            this.rtbEventDetails.Name = "rtbEventDetails";
            this.rtbEventDetails.ReadOnly = true;
            this.rtbEventDetails.Size = new System.Drawing.Size(349, 210);
            this.rtbEventDetails.TabIndex = 4;
            this.rtbEventDetails.Text = "Select an event or announcement from the list to view its full details.";
            // 
            // grpAnnouncements
            // 
            this.grpAnnouncements.Controls.Add(this.lstAnnouncementsQueue);
            this.grpAnnouncements.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpAnnouncements.Location = new System.Drawing.Point(20, 415);
            this.grpAnnouncements.Name = "grpAnnouncements";
            this.grpAnnouncements.Size = new System.Drawing.Size(944, 90);
            this.grpAnnouncements.TabIndex = 5;
            this.grpAnnouncements.TabStop = false;
            this.grpAnnouncements.Text = " 📢 Urgent Announcements Queue (Queue FIFO Structure) ";
            // 
            // lstAnnouncementsQueue
            // 
            this.lstAnnouncementsQueue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lstAnnouncementsQueue.FormattingEnabled = true;
            this.lstAnnouncementsQueue.ItemHeight = 15;
            this.lstAnnouncementsQueue.Location = new System.Drawing.Point(15, 22);
            this.lstAnnouncementsQueue.Name = "lstAnnouncementsQueue";
            this.lstAnnouncementsQueue.Size = new System.Drawing.Size(914, 55);
            this.lstAnnouncementsQueue.TabIndex = 0;
            // 
            // grpRecommendations
            // 
            this.grpRecommendations.Controls.Add(this.lstRecommendations);
            this.grpRecommendations.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpRecommendations.Location = new System.Drawing.Point(20, 515);
            this.grpRecommendations.Name = "grpRecommendations";
            this.grpRecommendations.Size = new System.Drawing.Size(944, 100);
            this.grpRecommendations.TabIndex = 6;
            this.grpRecommendations.TabStop = false;
            this.grpRecommendations.Text = " ⭐ Smart Recommendations Engine (Analyzes Search Pattern Frequencies) ";
            // 
            // lstRecommendations
            // 
            this.lstRecommendations.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lstRecommendations.FormattingEnabled = true;
            this.lstRecommendations.ItemHeight = 15;
            this.lstRecommendations.Location = new System.Drawing.Point(15, 22);
            this.lstRecommendations.Name = "lstRecommendations";
            this.lstRecommendations.Size = new System.Drawing.Size(914, 64);
            this.lstRecommendations.TabIndex = 0;
            // 
            // lblSearchHistoryStatus
            // 
            this.lblSearchHistoryStatus.AutoSize = true;
            this.lblSearchHistoryStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblSearchHistoryStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearchHistoryStatus.Location = new System.Drawing.Point(20, 622);
            this.lblSearchHistoryStatus.Name = "lblSearchHistoryStatus";
            this.lblSearchHistoryStatus.Size = new System.Drawing.Size(262, 15);
            this.lblSearchHistoryStatus.TabIndex = 7;
            this.lblSearchHistoryStatus.Text = "Search History (Stack LIFO): No searches performed yet.";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(784, 620);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(180, 38);
            this.btnBackToMenu.TabIndex = 8;
            this.btnBackToMenu.Text = "⬅ Back to Main Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(984, 670);
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
