using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLegalGuide.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public int CaseId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string Location { get; set; }
        public string EventName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public Case Case { get; set; }
    }
}
