using Volo.Abp;
using Volo.Abp.Modularity;

namespace Zony.Abp.gRpc.Tests
{
    public class AbpgRpcCommonTestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}