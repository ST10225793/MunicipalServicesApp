using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class EventsForm : Form
    {
        private Form mainMenuRef;
        private SearchRecommendationEngine engine;

        public EventsForm(Form mainMenu)
        {
            InitializeComponent();
            mainMenuRef = mainMenu;
            engine = new SearchRecommendationEngine();

            InitializeCategoryDropdown();
            DisplayAllEvents();
            DisplayAnnouncementsQueue();
            UpdateRecommendationsUI();
            UpdateSearchHistoryUI();
        }

        private void InitializeCategoryDropdown()
        {
            cmbCategoryFilter.Items.Clear();
            cmbCategoryFilter.Items.Add("All Categories");

            // Populate ComboBox dynamically using HashSet<string> (Sets requirement)
            HashSet<string> categories = engine.GetCategories();
            foreach (string cat in categories)
            {
                cmbCategoryFilter.Items.Add(cat);
            }

            cmbCategoryFilter.SelectedIndex = 0;
        }

        private void DisplayEventsList(List<EventItem> events)
        {
            lvwEvents.Items.Clear();

            foreach (EventItem item in events)
            {
                ListViewItem lvi = new ListViewItem(item.EventId);
                lvi.SubItems.Add(item.Title);
                lvi.SubItems.Add(item.Category);
                lvi.SubItems.Add(item.EventDate.ToString("yyyy-MM-dd"));
                lvi.SubItems.Add(item.Location);
                lvi.SubItems.Add(item.IsUrgentAnnouncement ? "📢 Announcement" : "📅 Event");
                lvi.Tag = item;

                if (item.IsUrgentAnnouncement)
                {
                    lvi.BackColor = Color.FromArgb(253, 237, 236);
                }

                lvwEvents.Items.Add(lvi);
            }

            lblResultCount.Text = $"Showing {events.Count} event(s) and announcement(s).";
        }

        private void DisplayAllEvents()
        {
            List<EventItem> allEvents = new List<EventItem>();
            
            // Iterate over SortedDictionary<DateTime, List<EventItem>>
            SortedDictionary<DateTime, List<EventItem>> dict = engine.GetAllEventsSorted();
            foreach (var kvp in dict)
            {
                allEvents.AddRange(kvp.Value);
            }

            DisplayEventsList(allEvents);
        }

        private void DisplayAnnouncementsQueue()
        {
            lstAnnouncementsQueue.Items.Clear();

            // Display FIFO Announcement Queue
            Queue<EventItem> queue = engine.GetAnnouncementQueue();
            int count = 1;
            foreach (EventItem ann in queue)
            {
                lstAnnouncementsQueue.Items.Add($"[{count++}] 📢 {ann.Title} ({ann.EventDate.ToString("yyyy-MM-dd")}) - {ann.Location}");
            }
        }

        private void UpdateRecommendationsUI()
        {
            lstRecommendations.Items.Clear();

            // Fetch smart recommendations based on search patterns
            List<Tuple<EventItem, string>> recommendations = engine.GetSmartRecommendations();
            foreach (var rec in recommendations)
            {
                EventItem item = rec.Item1;
                string rationale = rec.Item2;
                lstRecommendations.Items.Add($"⭐ {item.Title} [{item.Category}] | {rationale}");
            }
        }

        private void UpdateSearchHistoryUI()
        {
            Stack<string> historyStack = engine.GetSearchHistoryStack();
            if (historyStack.Count > 0)
            {
                lblSearchHistoryStatus.Text = $"Recent Search Interest (Stack LIFO): '{historyStack.Peek()}' (Total searches logged: {historyStack.Count})";
            }
            else
            {
                lblSearchHistoryStatus.Text = "Search History (Stack LIFO): No search queries performed yet.";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string category = cmbCategoryFilter.SelectedItem != null ? cmbCategoryFilter.SelectedItem.ToString() : "All Categories";
            DateTime? date = chkEnableDateFilter.Checked ? (DateTime?)dtpDateFilter.Value.Date : null;
            string keyword = txtKeywordSearch.Text;

            List<EventItem> results = engine.SearchEvents(category, date, keyword);
            DisplayEventsList(results);

            // Refresh recommendations and search history tracking
            UpdateRecommendationsUI();
            UpdateSearchHistoryUI();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            cmbCategoryFilter.SelectedIndex = 0;
            chkEnableDateFilter.Checked = false;
            txtKeywordSearch.Clear();
            DisplayAllEvents();
        }

        private void lvwEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwEvents.SelectedItems.Count > 0)
            {
                EventItem selectedEvent = (EventItem)lvwEvents.SelectedItems[0].Tag;
                rtbEventDetails.Text = $"TITLE: {selectedEvent.Title}\n" +
                                       $"CATEGORY: {selectedEvent.Category}\n" +
                                       $"DATE: {selectedEvent.EventDate.ToString("dd MMMM yyyy")}\n" +
                                       $"LOCATION: {selectedEvent.Location}\n" +
                                       $"TYPE: {(selectedEvent.IsUrgentAnnouncement ? "Urgent Municipal Announcement" : "Local Event")}\n\n" +
                                       $"DESCRIPTION:\n{selectedEvent.Description}";
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            mainMenuRef.Show();
            this.Close();
        }
    }
}
