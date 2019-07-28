using System;

namespace Whipsaw
{
    public class Subscription
    {
        public EventType EventType { get; set; }
        
        public Uri TargetUrl { get; set; }
    }
}