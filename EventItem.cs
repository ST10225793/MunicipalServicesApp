using System;

namespace MunicipalServicesApp
{
    public class EventItem
    {
        public string EventId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public bool IsUrgentAnnouncement { get; set; }

        public EventItem(string id, string title, string category, DateTime date, string location, string description, bool isUrgent = false)
        {
            EventId = id;
            Title = title;
            Category = category;
            EventDate = date.Date;
            Location = location;
            Description = description;
            IsUrgentAnnouncement = isUrgent;
        }

        public override string ToString()
        {
            string flag = IsUrgentAnnouncement ? "📢 [ANNOUNCEMENT] " : "📅 [EVENT] ";
            return $"{flag}{Title} ({Category}) - {EventDate.ToString("yyyy-MM-dd")} @ {Location}";
        }
    }
}
