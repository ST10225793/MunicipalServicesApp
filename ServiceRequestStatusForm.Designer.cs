namespace MunicipalServicesApp
{
    partial class ServiceRequestStatusForm
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
            this.grpBst = new System.Windows.Forms.GroupBox();
            this.lblBstCount = new System.Windows.Forms.Label();
            this.btnBstSearch = new System.Windows.Forms.Button();
            this.txtBstSearch = new System.Windows.Forms.TextBox();
            this.lblBstSearch = new System.Windows.Forms.Label();
            this.lvwBstRequests = new System.Windows.Forms.ListView();
            this.colReqId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpHeap = new System.Windows.Forms.GroupBox();
            this.lstPriorityHeap = new System.Windows.Forms.ListBox();
            this.grpGraph = new System.Windows.Forms.GroupBox();
            this.rtbGraphOutput = new System.Windows.Forms.RichTextBox();
            this.btnComputeMst = new System.Windows.Forms.Button();
            this.btnRunDfs = new System.Windows.Forms.Button();
            this.btnRunBfs = new System.Windows.Forms.Button();
            this.cmbStartLocation = new System.Windows.Forms.ComboBox();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpBst.SuspendLayout();
            this.grpHeap.SuspendLayout();
            this.grpGraph.SuspendLayout();
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
            this.lblHeader.Location = new System.Drawing.Point(260, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(464, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Service Request Status (Trees, Heaps && Graphs)";
            // 
            // grpBst
            // 
            this.grpBst.Controls.Add(this.lblBstCount);
            this.grpBst.Controls.Add(this.btnBstSearch);
            this.grpBst.Controls.Add(this.txtBstSearch);
            this.grpBst.Controls.Add(this.lblBstSearch);
            this.grpBst.Controls.Add(this.lvwBstRequests);
            this.grpBst.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpBst.Location = new System.Drawing.Point(20, 70);
            this.grpBst.Name = "grpBst";
            this.grpBst.Size = new System.Drawing.Size(465, 290);
            this.grpBst.TabIndex = 1;
            this.grpBst.TabStop = false;
            this.grpBst.Text = "Binary Search Tree (BST) Request Index";
            // 
            // lblBstCount
            // 
            this.lblBstCount.AutoSize = true;
            this.lblBstCount.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblBstCount.Location = new System.Drawing.Point(15, 265);
            this.lblBstCount.Name = "lblBstCount";
            this.lblBstCount.Size = new System.Drawing.Size(183, 15);
            this.lblBstCount.TabIndex = 4;
            this.lblBstCount.Text = "Total BST Nodes (In-Order): 0";
            // 
            // btnBstSearch
            // 
            this.btnBstSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBstSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBstSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnBstSearch.ForeColor = System.Drawing.Color.White;
            this.btnBstSearch.Location = new System.Drawing.Point(365, 24);
            this.btnBstSearch.Name = "btnBstSearch";
            this.btnBstSearch.Size = new System.Drawing.Size(85, 26);
            this.btnBstSearch.TabIndex = 3;
            this.btnBstSearch.Text = "Search BST";
            this.btnBstSearch.UseVisualStyleBackColor = false;
            this.btnBstSearch.Click += new System.EventHandler(this.btnBstSearch_Click);
            // 
            // txtBstSearch
            // 
            this.txtBstSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBstSearch.Location = new System.Drawing.Point(235, 25);
            this.txtBstSearch.Name = "txtBstSearch";
            this.txtBstSearch.Size = new System.Drawing.Size(120, 23);
            this.txtBstSearch.TabIndex = 2;
            // 
            // lblBstSearch
            // 
            this.lblBstSearch.AutoSize = true;
            this.lblBstSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBstSearch.Location = new System.Drawing.Point(15, 28);
            this.lblBstSearch.Name = "lblBstSearch";
            this.lblBstSearch.Size = new System.Drawing.Size(213, 15);
            this.lblBstSearch.TabIndex = 1;
            this.lblBstSearch.Text = "Search Request ID (O(log N) BST Lookup):";
            // 
            // lvwBstRequests
            // 
            this.lvwBstRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colReqId,
            this.colCategory,
            this.colLocation,
            this.colPriority,
            this.colStatus});
            this.lvwBstRequests.FullRowSelect = true;
            this.lvwBstRequests.GridLines = true;
            this.lvwBstRequests.HideSelection = false;
            this.lvwBstRequests.Location = new System.Drawing.Point(15, 60);
            this.lvwBstRequests.Name = "lvwBstRequests";
            this.lvwBstRequests.Size = new System.Drawing.Size(435, 195);
            this.lvwBstRequests.TabIndex = 0;
            this.lvwBstRequests.UseCompatibleStateImageBehavior = false;
            this.lvwBstRequests.View = System.Windows.Forms.View.Details;
            // 
            // colReqId
            // 
            this.colReqId.Text = "Req ID";
            this.colReqId.Width = 70;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 110;
            // 
            // colLocation
            // 
            this.colLocation.Text = "Location";
            this.colLocation.Width = 110;
            // 
            // colPriority
            // 
            this.colPriority.Text = "Priority";
            this.colPriority.Width = 65;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 75;
            // 
            // grpHeap
            // 
            this.grpHeap.Controls.Add(this.lstPriorityHeap);
            this.grpHeap.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpHeap.Location = new System.Drawing.Point(500, 70);
            this.grpHeap.Name = "grpHeap";
            this.grpHeap.Size = new System.Drawing.Size(465, 290);
            this.grpHeap.TabIndex = 2;
            this.grpHeap.TabStop = false;
            this.grpHeap.Text = "Min-Heap Emergency Dispatch Priority Queue";
            // 
            // lstPriorityHeap
            // 
            this.lstPriorityHeap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstPriorityHeap.FormattingEnabled = true;
            this.lstPriorityHeap.ItemHeight = 15;
            this.lstPriorityHeap.Location = new System.Drawing.Point(15, 28);
            this.lstPriorityHeap.Name = "lstPriorityHeap";
            this.lstPriorityHeap.Size = new System.Drawing.Size(435, 244);
            this.lstPriorityHeap.TabIndex = 0;
            // 
            // grpGraph
            // 
            this.grpGraph.Controls.Add(this.rtbGraphOutput);
            this.grpGraph.Controls.Add(this.btnComputeMst);
            this.grpGraph.Controls.Add(this.btnRunDfs);
            this.grpGraph.Controls.Add(this.btnRunBfs);
            this.grpGraph.Controls.Add(this.cmbStartLocation);
            this.grpGraph.Controls.Add(this.lblStartLocation);
            this.grpGraph.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpGraph.Location = new System.Drawing.Point(20, 370);
            this.grpGraph.Name = "grpGraph";
            this.grpGraph.Size = new System.Drawing.Size(945, 235);
            this.grpGraph.TabIndex = 3;
            this.grpGraph.TabStop = false;
            this.grpGraph.Text = "Municipal Location Graph Network (BFS / DFS Traversals && Prim's MST Minimum Route)";
            // 
            // rtbGraphOutput
            // 
            this.rtbGraphOutput.BackColor = System.Drawing.Color.White;
            this.rtbGraphOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGraphOutput.Location = new System.Drawing.Point(15, 65);
            this.rtbGraphOutput.Name = "rtbGraphOutput";
            this.rtbGraphOutput.ReadOnly = true;
            this.rtbGraphOutput.Size = new System.Drawing.Size(915, 155);
            this.rtbGraphOutput.TabIndex = 5;
            this.rtbGraphOutput.Text = "Select a depot location and click BFS, DFS, or Prim's MST to evaluate graph algorithms...";
            // 
            // btnComputeMst
            // 
            this.btnComputeMst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnComputeMst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputeMst.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnComputeMst.ForeColor = System.Drawing.Color.White;
            this.btnComputeMst.Location = new System.Drawing.Point(740, 27);
            this.btnComputeMst.Name = "btnComputeMst";
            this.btnComputeMst.Size = new System.Drawing.Size(190, 28);
            this.btnComputeMst.TabIndex = 4;
            this.btnComputeMst.Text = "🌐 Prim's MST (Min Distance)";
            this.btnComputeMst.UseVisualStyleBackColor = false;
            this.btnComputeMst.Click += new System.EventHandler(this.btnComputeMst_Click);
            // 
            // btnRunDfs
            // 
            this.btnRunDfs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnRunDfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunDfs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnRunDfs.ForeColor = System.Drawing.Color.White;
            this.btnRunDfs.Location = new System.Drawing.Point(590, 27);
            this.btnRunDfs.Name = "btnRunDfs";
            this.btnRunDfs.Size = new System.Drawing.Size(140, 28);
            this.btnRunDfs.TabIndex = 3;
            this.btnRunDfs.Text = "🔍 DFS Traversal";
            this.btnRunDfs.UseVisualStyleBackColor = false;
            this.btnRunDfs.Click += new System.EventHandler(this.btnRunDfs_Click);
            // 
            // btnRunBfs
            // 
            this.btnRunBfs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRunBfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunBfs.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnRunBfs.ForeColor = System.Drawing.Color.White;
            this.btnRunBfs.Location = new System.Drawing.Point(440, 27);
            this.btnRunBfs.Name = "btnRunBfs";
            this.btnRunBfs.Size = new System.Drawing.Size(140, 28);
            this.btnRunBfs.TabIndex = 2;
            this.btnRunBfs.Text = "🚀 BFS Reachability";
            this.btnRunBfs.UseVisualStyleBackColor = false;
            this.btnRunBfs.Click += new System.EventHandler(this.btnRunBfs_Click);
            // 
            // cmbStartLocation
            // 
            this.cmbStartLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStartLocation.FormattingEnabled = true;
            this.cmbStartLocation.Location = new System.Drawing.Point(145, 30);
            this.cmbStartLocation.Name = "cmbStartLocation";
            this.cmbStartLocation.Size = new System.Drawing.Size(280, 23);
            this.cmbStartLocation.TabIndex = 1;
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartLocation.Location = new System.Drawing.Point(15, 33);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(124, 15);
            this.lblStartLocation.TabIndex = 0;
            this.lblStartLocation.Text = "Start Depot/Hub Node:";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnBackToMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(825, 615);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(140, 30);
            this.btnBackToMenu.TabIndex = 4;
            this.btnBackToMenu.Text = "⬅ Main Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(984, 660);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.grpGraph);
            this.Controls.Add(this.grpHeap);
            this.Controls.Add(this.grpBst);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ServiceRequestStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal Services - Service Request Status (Trees, Heaps && Graphs)";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpBst.ResumeLayout(false);
            this.grpBst.PerformLayout();
            this.grpHeap.ResumeLayout(false);
            this.grpGraph.ResumeLayout(false);
            this.grpGraph.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpBst;
        private System.Windows.Forms.ListView lvwBstRequests;
        private System.Windows.Forms.ColumnHeader colReqId;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colLocation;
        private System.Windows.Forms.ColumnHeader colPriority;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Button btnBstSearch;
        private System.Windows.Forms.TextBox txtBstSearch;
        private System.Windows.Forms.Label lblBstSearch;
        private System.Windows.Forms.Label lblBstCount;
        private System.Windows.Forms.GroupBox grpHeap;
        private System.Windows.Forms.ListBox lstPriorityHeap;
        private System.Windows.Forms.GroupBox grpGraph;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.ComboBox cmbStartLocation;
        private System.Windows.Forms.Button btnRunBfs;
        private System.Windows.Forms.Button btnRunDfs;
        private System.Windows.Forms.Button btnComputeMst;
        private System.Windows.Forms.RichTextBox rtbGraphOutput;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}
