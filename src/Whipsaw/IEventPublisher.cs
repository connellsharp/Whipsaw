using System.Threading.Tasks;

namespace Whipsaw
{
    public interface IEventPublisher
    {
        Task PublishAsync(object evnt);
    }
}