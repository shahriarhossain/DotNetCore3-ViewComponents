using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Entity
{
    public class Conference
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; } = DateTime.Now;
        [DisplayName("Attendee Total")] public int TotalAttendee { get; set; }
    }
}
