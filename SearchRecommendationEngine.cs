using System;
using System.Collections.Generic;
using System.Linq;

namespace MunicipalServicesApp
{
    public class SearchRecommendationEngine
    {
        // 1. SortedDictionary to store events chronologically by date
        private SortedDictionary<DateTime, List<EventItem>> eventDictionary;

        // 2. Stack to track user search query history (LIFO structure)
        private Stack<string> searchCategoryHistory;

        // 3. Queue to manage urgent announcements and broadcast messages (FIFO structure)
        private Queue<EventItem> announcementQueue;

        // 4. Sets for fast unique category and date tracking
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
            // Seed a realistic dataset of South African municipal events and announcements
            AddEvent(new EventItem("EV01", "Water Infrastructure Public Consultation", "Water & Sanitation", new DateTime(2026, 10, 18), "Town Hall, Ward 4", "Public meeting regarding the upgrade of local water pipes and pour-flush sanitation facilities."));
            AddEvent(new EventItem("EV02", "Community Youth Clean-Up Campaign", "Environment & Waste", new DateTime(2026, 10, 20), "Central Park, Sector 2", "Volunteer drive for refuse collection and park restoration."));
            AddEvent(new EventItem("EV03", "Integrated Development Plan (IDP) Workshop", "Governance & Planning", new DateTime(2026, 10, 22), "Municipal Council Chambers", "Annual IDP stakeholder workshop to discuss budget allocation and basic services prioritisation."));
            AddEvent(new EventItem("EV04", "Road Maintenance & Pothole Repair Schedule", "Roads & Transport", new DateTime(2026, 10, 25), "Main Road, Zone B", "Scheduled road closures and resurfacing efforts across major local transport routes."));
            AddEvent(new EventItem("EV05", "Clean Energy & Solar Geyser Awareness Expo", "Electricity & Energy", new DateTime(2026, 10, 28), "Civic Centre Auditorium", "Demonstration of renewable energy solutions and subsidized solar water heating for households."));
            AddEvent(new EventItem("EV06", "Subsidized Basic Services Registration Drive", "Social Development", new DateTime(2026, 11, 02), "Community Hall, Ward 12", "Indigent registration support for qualifying households seeking basic water and electricity relief."));
            AddEvent(new EventItem("EV07", "Sanitation Health & Hygiene Workshop", "Water & Sanitation", new DateTime(2026, 11, 05), "Health Clinic, Ward 8", "Community health awareness session on safe water usage and sanitation hygiene practices."));
            AddEvent(new EventItem("EV08", "Public Safety & Community Policing Forum", "Governance & Planning", new DateTime(2026, 11, 10), "Community Centre, Zone A", "Quarterly meeting with local law enforcement, ward councillors, and residents."));

            // Urgent Announcements for FIFO Queue
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
            AddEvent(ann); // Also add to general event dictionary
        }

        public HashSet<string> GetCategories()
        {
            return categorySet;
        }

        public HashSet<DateTime> GetEventDates()
        {
            return dateSet;
        }

        public SortedDictionary<DateTime, List<EventItem>> GetAllEventsSorted()
        {
            return eventDictionary;
        }

        public Queue<EventItem> GetAnnouncementQueue()
        {
            return announcementQueue;
        }

        public Stack<string> GetSearchHistoryStack()
        {
            return searchCategoryHistory;
        }

        public void TrackSearchPattern(string category)
        {
            if (!string.IsNullOrWhiteSpace(category) && category != "All Categories")
            {
                searchCategoryHistory.Push(category);
            }
        }

        public List<EventItem> SearchEvents(string selectedCategory, DateTime? selectedDate, string keyword)
        {
            List<EventItem> searchResults = new List<EventItem>();

            foreach (var kvp in eventDictionary)
            {
                // Date Filter
                if (selectedDate.HasValue && kvp.Key.Date != selectedDate.Value.Date)
                {
                    continue;
                }

                foreach (EventItem item in kvp.Value)
                {
                    // Category Filter
                    if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "All Categories" && item.Category != selectedCategory)
                    {
                        continue;
                    }

                    // Keyword Filter
                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        string kw = keyword.Trim().ToLower();
                        bool matchTitle = item.Title.ToLower().Contains(kw);
                        bool matchDesc = item.Description.ToLower().Contains(kw);
                        bool matchLoc = item.Location.ToLower().Contains(kw);

                        if (!matchTitle && !matchDesc && !matchLoc)
                        {
                            continue;
                        }
                    }

                    searchResults.Add(item);
                }
            }

            // Track search pattern if category specified
            if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "All Categories")
            {
                TrackSearchPattern(selectedCategory);
            }

            return searchResults;
        }

        public List<Tuple<EventItem, string>> GetSmartRecommendations()
        {
            List<Tuple<EventItem, string>> recommendations = new List<Tuple<EventItem, string>>();

            if (searchCategoryHistory.Count == 0)
            {
                // Default recommendations if no search history exists
                foreach (var kvp in eventDictionary)
                {
                    foreach (var ev in kvp.Value)
                    {
                        recommendations.Add(new Tuple<EventItem, string>(ev, "Featured upcoming municipal event"));
                        if (recommendations.Count >= 3) return recommendations;
                    }
                }
                return recommendations;
            }

            // Analyze search frequency from Stack
            Dictionary<string, int> categoryCounts = new Dictionary<string, int>();
            foreach (string category in searchCategoryHistory)
            {
                if (!categoryCounts.ContainsKey(category))
                {
                    categoryCounts[category] = 0;
                }
                categoryCounts[category]++;
            }

            // Get top preferred category
            string preferredCategory = categoryCounts.OrderByDescending(c => c.Value).First().Key;
            int searchCount = categoryCounts[preferredCategory];

            // Select recommended events matching preferred category
            foreach (var kvp in eventDictionary)
            {
                foreach (var ev in kvp.Value)
                {
                    if (ev.Category == preferredCategory)
                    {
                        string rationale = $"Recommended based on your {searchCount} recent search(es) in '{preferredCategory}'";
                        recommendations.Add(new Tuple<EventItem, string>(ev, rationale));
                    }
                }
            }

            // Fallback if not enough recommendations
            if (recommendations.Count < 3)
            {
                foreach (var kvp in eventDictionary)
                {
                    foreach (var ev in kvp.Value)
                    {
                        if (ev.Category != preferredCategory && !recommendations.Any(r => r.Item1.EventId == ev.EventId))
                        {
                            recommendations.Add(new Tuple<EventItem, string>(ev, "Popular related community announcement"));
                            if (recommendations.Count >= 3) break;
                        }
                    }
                    if (recommendations.Count >= 3) break;
                }
            }

            return recommendations.Take(3).ToList();
        }
    }
}
