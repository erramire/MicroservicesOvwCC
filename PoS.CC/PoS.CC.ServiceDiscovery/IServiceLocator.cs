namespace PoS.CC.ServiceDiscovery
{
    public interface IServiceLocator
    {
        string GetServiceUri(ServiceEnum serviceName);
    }
}
