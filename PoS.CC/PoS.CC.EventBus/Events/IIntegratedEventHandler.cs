using Microsoft.Azure.ServiceBus;
using System.Threading.Tasks;

namespace PoS.CC.EventBus.Events
{
    public interface IIntegratedEventHandler
    {
        Task HandleAsync(Message message);
    }
}
