using System;

namespace DS.SystemsCommunication.Common.Models
{
    public class SessionClass
    {
        public int ClassId { get; set; }
        public string CourseName { get; set; }
        public DateTime SessionDate { get; set; }
        public DateTime SessionEndDate { get; set; }
        public int TotalCapacity { get; set; }
        public string Speacker { get; set; }
    }
}