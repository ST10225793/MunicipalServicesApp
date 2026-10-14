using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReportIssuesForm : Form
    {
        private Form mainMenuRef;
        private List<Issue> reportedIssuesList;
        private string attachedFilePath = "None";
        private int userReportCount = 0;

        public ReportIssuesForm(Form mainMenu)
        {
            InitializeComponent();
            mainMenuRef = mainMenu;
            reportedIssuesList = new List<Issue>();

            // Populate Category Dropdown
            cmbCategory.Items.AddRange(new string[] {
                "Sanitation & Sewage",
                "Water Supply & Leakages",
                "Roads & Potholes",
                "Electricity & Power Interruptions",
                "Refuse & Waste Management",
                "Public Parks & Recreation",
                "Other Services"
            });
            cmbCategory.SelectedIndex = 0;
        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Supporting Document or Image";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Document Files (*.pdf;*.docx;*.txt)|*.pdf;*.docx;*.txt|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachedFilePath = openFileDialog.FileName;
                    lblAttachmentStatus.Text = "Attached: " + System.IO.Path.GetFileName(attachedFilePath);
                    lblAttachmentStatus.ForeColor = System.Drawing.Color.Green;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the location of the issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please provide a description of the issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbDescription.Focus();
                return;
            }

            // Create Issue object & store in List
            Issue newIssue = new Issue(txtLocation.Text.Trim(), cmbCategory.SelectedItem.ToString(), rtbDescription.Text.Trim(), attachedFilePath);
            reportedIssuesList.Add(newIssue);

            // Update User Engagement Progress
            userReportCount++;
            int progress = Math.Min(userReportCount * 20, 100);
            prgEngagement.Value = progress;

            string engagementRank = "Civic Observer";
            if (userReportCount >= 5) engagementRank = "Municipal Champion";
            else if (userReportCount >= 3) engagementRank = "Active Citizen";
            else if (userReportCount >= 1) engagementRank = "Community Guardian";

            lblEngagementStatus.Text = $"Reports Submitted: {userReportCount} | Status: {engagementRank}";

            MessageBox.Show($"Thank you! Your issue report for '{newIssue.Location}' has been successfully logged.\n\nTotal Active Reports in List: {reportedIssuesList.Count}", "Report Submitted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset Input Controls
            txtLocation.Clear();
            rtbDescription.Clear();
            attachedFilePath = "None";
            lblAttachmentStatus.Text = "No file attached";
            lblAttachmentStatus.ForeColor = System.Drawing.Color.Gray;
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            mainMenuRef.Show();
            this.Close();
        }
    }
}
