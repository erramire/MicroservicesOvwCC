using System;
using Microsoft.Azure.ServiceBus;

namespace PoS.CC.EventBus.Connection
{
    public interface IServiceBusPersisterConnection : IDisposable
    {
        ServiceBusConnectionStringBuilder ServiceBusConnectionStringBuilder { get; }

        ITopicClient CreateModel();
    }
}
