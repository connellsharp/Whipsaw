namespace Whipsaw
{
    internal class EventTypeTranslator : ITranslator
    {
        public EventType GetEventType(object evnt)
        {
            return new EventType
            {
                Name = evnt.GetType().FullName
            };
        }
    }
}