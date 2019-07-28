using System;
using System.Collections.Generic;

namespace Whipsaw
{
    public class Event
    {
        public EventType EventType { get; set; }
        
        public object Payload { get; set; }
        
        public DateTime EventDate { get; set; }
        
        public IEnumerable<Notification> Notifications { get; set; }
    }
}