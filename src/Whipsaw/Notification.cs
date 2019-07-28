using System.Collections.Generic;

namespace Whipsaw
{
    public class Notification
    {
        public Subscription Subscription { get; set; }
        
        public IEnumerable<NotificationAttempt> Attempts { get; set; }
    }
}