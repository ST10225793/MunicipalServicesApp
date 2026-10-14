using System;

namespace MunicipalServicesApp
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachedFilePath { get; set; }
        public DateTime DateReported { get; set; }

        public Issue(string location, string category, string description, string attachedFilePath)
        {
            Location = location;
            Category = category;
            Description = description;
            AttachedFilePath = attachedFilePath;
            DateReported = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{DateReported.ToShortDateString()}] {Category} - {Location}";
        }
    }
}
