using System;

namespace MunicipalServicesApp
{
    public class Issue
    {
        public string RequestId { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachedFilePath { get; set; }
        public DateTime DateReported { get; set; }
        public string Status { get; set; }
        public int PriorityLevel { get; set; } // 1 = Critical, 2 = High, 3 = Medium, 4 = Low

        public Issue(string requestId, string location, string category, string description, string attachedFilePath, int priorityLevel = 3, string status = "Pending")
        {
            RequestId = requestId;
            Location = location;
            Category = category;
            Description = description;
            AttachedFilePath = attachedFilePath;
            DateReported = DateTime.Now;
            PriorityLevel = priorityLevel;
            Status = status;
        }

        public override string ToString()
        {
            return $"[{RequestId}] {Status.ToUpper()} | {Category} - {Location} (Priority: {PriorityLevel})";
        }
    }
}
