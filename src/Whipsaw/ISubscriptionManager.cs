using System.Collections.Generic;
using System.Threading.Tasks;

namespace Whipsaw
{
    public interface ISubscriptionManager
    {
        Task<IEnumerable<Subscription>> GetSubscriptions(EventType eventType);
        Task CreateEvent(Event evnt);
        Task AddAttempt(Event evnt, NotificationAttempt attempt);
    }
}