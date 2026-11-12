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

            PopulateCategoryFilter();
            DisplayAllEvents();
            DisplayAnnouncementsQueue();
            UpdateRecommendationsUI();
            UpdateSearchHistoryUI();
        }

        private void PopulateCategoryFilter()
        {
            cmbCategoryFilter.Items.Clear();
            cmbCategoryFilter.Items.Add("All Categories");

            HashSet<string> categories = engine.GetCategorySet();
            foreach (string cat in categories)
            {
                cmbCategoryFilter.Items.Add(cat);
            }
            cmbCategoryFilter.SelectedIndex = 0;
        }

        private void DisplayAllEvents()
        {
            SortedDictionary<DateTime, List<EventItem>> dict = engine.GetEventDictionary();
            List<EventItem> allEvents = new List<EventItem>();

            foreach (var kvp in dict)
            {
                allEvents.AddRange(kvp.Value);
            }

            DisplayEventsList(allEvents);
        }

        private void DisplayEventsList(List<EventItem> events)
        {
            lvwEvents.Items.Clear();
            rtbEventDetails.Clear();

            foreach (EventItem item in events)
            {
                ListViewItem lvi = new ListViewItem(item.EventId);
                lvi.SubItems.Add(item.Title);
                lvi.SubItems.Add(item.Category);
                lvi.SubItems.Add(item.EventDate.ToString("yyyy-MM-dd"));
                lvi.SubItems.Add(item.Location);
                lvi.SubItems.Add(item.IsUrgentAnnouncement ? "Urgent Notice" : "Event");
                lvi.Tag = item;

                if (item.IsUrgentAnnouncement)
                {
                    lvi.ForeColor = Color.DarkRed;
                    lvi.Font = new Font(lvwEvents.Font, FontStyle.Bold);
                }

                lvwEvents.Items.Add(lvi);
            }

            lblResultCount.Text = $"Total Events Displayed: {events.Count}";
        }

        private void DisplayAnnouncementsQueue()
        {
            lstAnnouncementsQueue.Items.Clear();
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
                rtbEventDetails.Text = $"TITLE: {selectedEvent.Title}\nCATEGORY: {selectedEvent.Category}\nDATE: {selectedEvent.EventDate.ToString("dd MMMM yyyy")}\nLOCATION: {selectedEvent.Location}\nTYPE: {(selectedEvent.IsUrgentAnnouncement ? "Urgent Municipal Announcement" : "Local Event")}\n\nDESCRIPTION:\n{selectedEvent.Description}";
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            mainMenuRef.Show();
            this.Close();
        }
    }
}
