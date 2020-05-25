using System;
using Microsoft.Azure.ServiceBus;

namespace PoS.CC.EventBus.Connection
{
    public class DefaultServiceBusPersisterConnection : IServiceBusPersisterConnection
    {
        private bool _disposed;
        private ITopicClient _topicClient;

        public DefaultServiceBusPersisterConnection(ServiceBusConnectionStringBuilder serviceBusConnectionStringBuilder)
        {
            ServiceBusConnectionStringBuilder = serviceBusConnectionStringBuilder ??
                                                throw new ArgumentNullException(
                                                    nameof(serviceBusConnectionStringBuilder));
            _topicClient = new TopicClient(ServiceBusConnectionStringBuilder, RetryPolicy.Default);
        }


        // Use this string
        //Endpoint=sb://activateazure.servicebus.windows.net/;SharedAccessKeyName=Manage;SharedAccessKey=M49KsX67/3yrdDVVUJaMkRZuCoi/4UlOqhZY3BUVNtE=;EntityPath=eventbustopic


        public ServiceBusConnectionStringBuilder ServiceBusConnectionStringBuilder { get; }

        public ITopicClient CreateModel()
        {
            if (_topicClient.IsClosedOrClosing)
                _topicClient = new TopicClient(ServiceBusConnectionStringBuilder, RetryPolicy.Default);

            return _topicClient;
        }

        public void Dispose()
        {
            if (_disposed) return;

            _disposed = true;
        }
    }
}
