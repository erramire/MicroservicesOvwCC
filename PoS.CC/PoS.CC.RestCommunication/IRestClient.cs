using PoS.CC.ServiceDiscovery;
using System.Threading.Tasks;

namespace PoS.CC.RestCommunication
{
    public interface IRestClient
    {
        Task<TReturnMessage> GetAsync<TReturnMessage>(ServiceEnum serviceName, string path)
            where TReturnMessage : class, new();

        Task<TReturnMessage> PostAsync<TReturnMessage>(ServiceEnum serviceName, string path, object dataObject = null)
            where TReturnMessage : class, new();

        Task<TReturnMessage> PutAsync<TReturnMessage>(ServiceEnum serviceName, string path, object dataObject = null)
            where TReturnMessage : class, new();

        Task<bool> DeleteAsync(ServiceEnum serviceName, string path);
    }
}
