using Consul;
using Volo.Abp.DependencyInjection;

namespace Zony.Abp.gRpc
{
    public interface IConsulFactory : ISingletonDependency
    {
        IConsulClient CreateConsulClient(ConsulBuildParameters config);
    }
}