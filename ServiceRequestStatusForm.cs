using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ServiceRequestStatusForm : Form
    {
        private Form mainMenuRef;
        private BinarySearchTree bst;
        private MinHeap priorityHeap;
        private MunicipalGraph graph;

        public ServiceRequestStatusForm(Form mainMenu)
        {
            InitializeComponent();
            mainMenuRef = mainMenu;

            bst = new BinarySearchTree();
            priorityHeap = new MinHeap();
            graph = new MunicipalGraph();

            SeedDefaultData();
            DisplayAllBstRequests();
            DisplayPriorityQueue();
            PopulateGraphControls();
        }

        private void SeedDefaultData()
        {
            Issue req1 = new Issue("REQ-1001", "Ward 4, West Street", "Water Supply & Leakages", "Burst water pipe flooding main road.", "pipe_photo.png", 1, "Dispatched");
            Issue req2 = new Issue("REQ-1005", "Sector 3 Industrial", "Electricity & Power", "Feeder cable fault causing substation trip.", "power_log.pdf", 1, "In Progress");
            Issue req3 = new Issue("REQ-1002", "Ward 1 Hub (East)", "Roads & Potholes", "Deep pothole causing vehicle tire damage.", "road_damage.png", 3, "Pending");
            Issue req4 = new Issue("REQ-1008", "Ward 8 Health Clinic", "Sanitation & Sewage", "Clogged main sewer line near clinic entrance.", "sewer_inspection.pdf", 2, "Scheduled");
            Issue req5 = new Issue("REQ-1004", "Ward 12 Community Center", "Refuse & Waste", "Uncollected illegal dumping site behind hall.", "waste_site.jpg", 4, "Logged");

            // Insert into BST
            bst.Insert(req1.RequestId, req1);
            bst.Insert(req2.RequestId, req2);
            bst.Insert(req3.RequestId, req3);
            bst.Insert(req4.RequestId, req4);
            bst.Insert(req5.RequestId, req5);

            // Insert into Min-Heap
            priorityHeap.Insert(req1.PriorityLevel, req1);
            priorityHeap.Insert(req2.PriorityLevel, req2);
            priorityHeap.Insert(req3.PriorityLevel, req3);
            priorityHeap.Insert(req4.PriorityLevel, req4);
            priorityHeap.Insert(req5.PriorityLevel, req5);
        }

        private void DisplayAllBstRequests()
        {
            lvwBstRequests.Items.Clear();
            List<Issue> requests = bst.GetAllInOrder();

            foreach (Issue req in requests)
            {
                ListViewItem lvi = new ListViewItem(req.RequestId);
                lvi.SubItems.Add(req.Category);
                lvi.SubItems.Add(req.Location);
                lvi.SubItems.Add($"Priority {req.PriorityLevel}");
                lvi.SubItems.Add(req.Status);
                lvi.Tag = req;
                lvwBstRequests.Items.Add(lvi);
            }

            lblBstCount.Text = $"Total BST Nodes (In-Order Traversal): {requests.Count}";
        }

        private void DisplayPriorityQueue()
        {
            lstPriorityHeap.Items.Clear();
            List<PriorityItem> sorted = priorityHeap.GetAllSorted();

            int rank = 1;
            foreach (var item in sorted)
            {
                string tag = item.Priority == 1 ? "🔥 CRITICAL" : (item.Priority == 2 ? "⚠️ HIGH" : "DEFAULT");
                lstPriorityHeap.Items.Add($"[{rank++}] {tag} (P{item.Priority}) | {item.Request.RequestId} - {item.Request.Category} @ {item.Request.Location}");
            }
        }

        private void PopulateGraphControls()
        {
            cmbStartLocation.Items.Clear();
            List<string> locations = graph.GetAllLocations();
            foreach (string loc in locations)
            {
                cmbStartLocation.Items.Add(loc);
            }
            if (cmbStartLocation.Items.Count > 0) cmbStartLocation.SelectedIndex = 0;
        }

        private void btnBstSearch_Click(object sender, EventArgs e)
        {
            string searchId = txtBstSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchId))
            {
                MessageBox.Show("Please enter a Tracking Request ID (e.g., REQ-1001).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Issue result = bst.Search(searchId);
            if (result != null)
            {
                MessageBox.Show($"[BST SEARCH HIT - O(log N)]\n\nTracking ID: {result.RequestId}\nCategory: {result.Category}\nLocation: {result.Location}\nPriority Level: {result.PriorityLevel}\nStatus: {result.Status}\nDescription: {result.Description}", "Request Found in Binary Search Tree", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Request ID '{searchId}' was not found in the Binary Search Tree index.", "Request Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRunBfs_Click(object sender, EventArgs e)
        {
            string startLoc = cmbStartLocation.SelectedItem.ToString();
            string route = graph.BFS(startLoc);
            rtbGraphOutput.Text = $"=== BREADTH-FIRST SEARCH (BFS) TRAVERSAL ===\nStarting Hub: {startLoc}\n\nTraversal Route (Queue-based Shortest Hop):\n{route}\n\n[Note: BFS guarantees optimal node-level reachability in O(V + E) time.]";
        }

        private void btnRunDfs_Click(object sender, EventArgs e)
        {
            string startLoc = cmbStartLocation.SelectedItem.ToString();
            string route = graph.DFS(startLoc);
            rtbGraphOutput.Text = $"=== DEPTH-FIRST SEARCH (DFS) TRAVERSAL ===\nStarting Hub: {startLoc}\n\nTraversal Route (Stack-based Recursive Branching):\n{route}\n\n[Note: DFS explores network paths deeply before backtracking in O(V + E) time.]";
        }

        private void btnComputeMst_Click(object sender, EventArgs e)
        {
            string startLoc = cmbStartLocation.SelectedItem.ToString();
            string mstOutput = graph.GetMinimumSpanningTree(startLoc);
            rtbGraphOutput.Text = mstOutput + "\n[Note: Prim's Algorithm evaluates edge weights in O(E log V) time to minimize total municipal infrastructure distance.]";
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            mainMenuRef.Show();
            this.Close();
        }
    }
}
