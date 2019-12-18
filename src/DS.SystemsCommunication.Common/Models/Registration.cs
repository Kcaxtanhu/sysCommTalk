using System;
using DS.SystemsCommunication.Common.Enums;

namespace DS.SystemsCommunication.Common.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public Status Status { get; set; }
    }
}