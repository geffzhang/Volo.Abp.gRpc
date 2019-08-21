using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Zony.Abp.gRpc.Tests
{
    [DependsOn(typeof(AbpTestBaseModule),
        typeof(AbpAutofacModule),
        typeof(AbpgRpcCommonModule))]
    public class AbpgRpcCommonTestsModule : AbpModule
    {
        
    }
}