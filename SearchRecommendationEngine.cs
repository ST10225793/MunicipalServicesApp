using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApp
{
    public class SearchRecommendationEngine
    {
        private SortedDictionary<DateTime, List<EventItem>> eventDictionary;
        private Stack<string> searchCategoryHistory;
        private Queue<EventItem> announcementQueue;
        private HashSet<string> categorySet;
        private HashSet<DateTime> dateSet;

        public SearchRecommendationEngine()
        {
            eventDictionary = new SortedDictionary<DateTime, List<EventItem>>();
            searchCategoryHistory = new Stack<string>();
            announcementQueue = new Queue<EventItem>();
            categorySet = new HashSet<string>();
            dateSet = new HashSet<DateTime>();

            SeedMockData();
        }

        private void SeedMockData()
        {
            AddEvent(new EventItem("EV01", "Water Infrastructure Public Consultation", "Water & Sanitation", new DateTime(2026, 11, 18), "Town Hall, Ward 4", "Public meeting regarding the upgrade of local water pipes and pour-flush sanitation facilities."));
            AddEvent(new EventItem("EV02", "Community Youth Clean-Up Campaign", "Environment & Waste", new DateTime(2026, 11, 20), "Central Park, Sector 2", "Volunteer drive for refuse collection and park restoration."));
            AddEvent(new EventItem("EV03", "Integrated Development Plan (IDP) Workshop", "Governance & Planning", new DateTime(2026, 11, 22), "Municipal Council Chambers", "Annual IDP stakeholder workshop to discuss budget allocation and basic services prioritisation."));
            AddEvent(new EventItem("EV04", "Road Maintenance & Pothole Repair Schedule", "Roads & Transport", new DateTime(2026, 11, 25), "Main Road, Zone B", "Scheduled road closures and resurfacing efforts across major local transport routes."));
            AddEvent(new EventItem("EV05", "Clean Energy & Solar Geyser Awareness Expo", "Electricity & Energy", new DateTime(2026, 11, 28), "Civic Centre Auditorium", "Demonstration of renewable energy solutions and subsidized solar water heating for households."));
            
            EventItem ann1 = new EventItem("AN01", "Emergency Water Pipeline Maintenance", "Water & Sanitation", DateTime.Now.AddDays(1), "Ward 4 & Ward 5", "Temporary water supply interruption scheduled from 08:00 to 16:00 for emergency repairs.", true);
            EventItem ann2 = new EventItem("AN02", "Scheduled Substation Maintenance Power Outage", "Electricity & Energy", DateTime.Now.AddDays(3), "Sector 3 Industrial Area", "Electricity grid maintenance outage expected between 09:00 and 15:00.", true);
            EventItem ann3 = new EventItem("AN03", "Refuse Collection Schedule Delay Notice", "Environment & Waste", DateTime.Now.AddDays(4), "All Wards", "Due to fleet servicing, refuse collection will run 1 day behind normal schedule this week.", true);

            EnqueueAnnouncement(ann1);
            EnqueueAnnouncement(ann2);
            EnqueueAnnouncement(ann3);
        }

        public void AddEvent(EventItem ev)
        {
            DateTime eventDate = ev.EventDate.Date;
            if (!eventDictionary.ContainsKey(eventDate))
            {
                eventDictionary[eventDate] = new List<EventItem>();
            }
            eventDictionary[eventDate].Add(ev);

            categorySet.Add(ev.Category);
            dateSet.Add(eventDate);
        }

        public void EnqueueAnnouncement(EventItem ann)
        {
            announcementQueue.Enqueue(ann);
            AddEvent(ann);
        }

        public List<EventItem> SearchEvents(string category, DateTime? date, string keyword)
        {
            if (!string.IsNullOrWhiteSpace(category) && category != "All Categories")
            {
                searchCategoryHistory.Push(category);
            }

            List<EventItem> searchResults = new List<EventItem>();
            foreach (var kvp in eventDictionary)
            {
                if (date.HasValue && kvp.Key.Date != date.Value.Date)
                {
                    continue;
                }

                foreach (var ev in kvp.Value)
                {
                    bool matchesCategory = (string.IsNullOrWhiteSpace(category) || category == "All Categories" || ev.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
                    bool matchesKeyword = (string.IsNullOrWhiteSpace(keyword) || ev.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 || ev.Description.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 || ev.Location.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);

                    if (matchesCategory && matchesKeyword)
                    {
                        searchResults.Add(ev);
                    }
                }
            }
            return searchResults;
        }

        public List<Tuple<EventItem, string>> GetSmartRecommendations()
        {
            List<Tuple<EventItem, string>> recommendations = new List<Tuple<EventItem, string>>();
            if (searchCategoryHistory.Count == 0)
            {
                foreach (var kvp in eventDictionary)
                {
                    foreach (var ev in kvp.Value)
                    {
                        recommendations.Add(new Tuple<EventItem, string>(ev, "Featured Upcoming Municipal Activity"));
                        if (recommendations.Count >= 3) return recommendations;
                    }
                }
                return recommendations;
            }

            Dictionary<string, int> categoryFrequency = new Dictionary<string, int>();
            foreach (string cat in searchCategoryHistory)
            {
                if (!categoryFrequency.ContainsKey(cat)) categoryFrequency[cat] = 0;
                categoryFrequency[cat]++;
            }

            string topCategory = categoryFrequency.OrderByDescending(x => x.Value).First().Key;
            string latestSearchedCategory = searchCategoryHistory.Peek();

            foreach (var kvp in eventDictionary)
            {
                foreach (var ev in kvp.Value)
                {
                    if (ev.Category.Equals(latestSearchedCategory, StringComparison.OrdinalIgnoreCase))
                    {
                        recommendations.Add(new Tuple<EventItem, string>(ev, $"Recommended based on your recent search interest in '{latestSearchedCategory}'"));
                    }
                    else if (ev.Category.Equals(topCategory, StringComparison.OrdinalIgnoreCase))
                    {
                        recommendations.Add(new Tuple<EventItem, string>(ev, $"Popular in your most searched category '{topCategory}'"));
                    }

                    if (recommendations.Count >= 4) return recommendations;
                }
            }

            return recommendations;
        }

        public SortedDictionary<DateTime, List<EventItem>> GetEventDictionary() => eventDictionary;
        public Stack<string> GetSearchHistoryStack() => searchCategoryHistory;
        public Queue<EventItem> GetAnnouncementQueue() => announcementQueue;
        public HashSet<string> GetCategorySet() => categorySet;
    }
}
