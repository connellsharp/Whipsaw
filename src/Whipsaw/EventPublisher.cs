using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whipsaw
{
    internal class EventPublisher : IEventPublisher
    {
        private readonly ISubscriptionManager _manager;
        private readonly ITranslator _translator;

        public EventPublisher(ISubscriptionManager manager, ITranslator translator)
        {
            _manager = manager;
            _translator = translator;
        }
        
        public async Task PublishAsync(object evnt)
        {
            EventType eventType = _translator.GetEventType(evnt);

            var subscriptions = await _manager.GetSubscriptions(eventType);

            await _manager.CreateEvent(new Event
            {
                EventType = eventType,
                Payload = evnt,
                EventDate = DateTime.UtcNow,
                Notifications = subscriptions.Select(s => new Notification
                {
                    Subscription = s,
                    Attempts = new List<NotificationAttempt>()
                })
            });
        }
    }
}