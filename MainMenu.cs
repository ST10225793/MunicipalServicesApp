using System;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm(this);
            reportForm.Show();
            this.Hide();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            EventsForm eventsForm = new EventsForm(this);
            eventsForm.Show();
            this.Hide();
        }

        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Service Request Status tracking will be implemented in Part 3 of the POE.", 
                            "Task Not Enabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
