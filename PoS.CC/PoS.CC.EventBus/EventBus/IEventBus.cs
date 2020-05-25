using PoS.CC.EventBus.Events;
using System;
using System.Threading.Tasks;

namespace PoS.CC.EventBus.EventBus
{
    public interface IEventBus
    {
        IServiceProvider ServiceProvider { get; set; }

        Task Publish<T>(T payload, MessageEventEnum eventEnum, string correlationToken);

        void Subscribe(MessageEventEnum eventName, Type eventType);
    }
}
