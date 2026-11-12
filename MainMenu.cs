using System;
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
            ServiceRequestStatusForm statusForm = new ServiceRequestStatusForm(this);
            statusForm.Show();
            this.Hide();
        }

        private void lblHeaderSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
