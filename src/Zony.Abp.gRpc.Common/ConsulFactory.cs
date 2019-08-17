using System;
using Consul;

namespace Zony.Abp.gRpc
{
    public class ConsulFactory : IConsulFactory
    {
        public IConsulClient CreateConsulClient(ConsulBuildParameters config)
        {
            if (config == null) throw new ArgumentNullException(nameof(config), "传入的 Consul Client 配置参数不能够为 NULL。");

            return new ConsulClient(builder =>
            {
                builder.Address = new Uri($"http://{config.Host}:{config.Port}");

                if (!string.IsNullOrEmpty(config.Token)) builder.Token = config.Token;
            });
        }
    }
}