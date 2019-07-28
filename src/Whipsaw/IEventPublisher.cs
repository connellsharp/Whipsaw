using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Whipsaw
{
    public interface IEventPublisher
    {
        Task PublishAsync(object evnt);
    }

    public interface ISubscriptionManager
    {
        Task<IEnumerable<Subscription>> GetSubscriptions(EventType eventType);
        Task CreateEvent(Event evnt);
        Task AddAttempt(Event evnt, NotificationAttempt attempt);
    }

    public class Subscription
    {
        public EventType EventType { get; set; }
        
        public Uri TargetUrl { get; set; }
    }

    public class EventType
    {
        public string Name { get; set; }
        
        //public IEnumerable<Subscription> Subscriptions { get; set; }
    }

    public class Event
    {
        public EventType EventType { get; set; }
        
        public object Payload { get; set; }
        
        public DateTime EventDate { get; set; }
        
        public IEnumerable<Notification> Notifications { get; set; }
    }

    public class Notification
    {
        public Subscription Subscription { get; set; }
        
        public IEnumerable<NotificationAttempt> Attempts { get; set; }
    }
    
    public class NotificationAttempt
    {
        public DateTime AttemptDate { get; set; }
        
        public int ResponseStatus { get; set; }
    }
}