namespace Zony.Abp.gRpc
{
    public class ConsulBuildParameters
    {
        protected ConsulBuildParameters()
        {
            
        }

        public ConsulBuildParameters(string host, int port, string token)
        {
            Host = string.IsNullOrEmpty(host) ? "localhost" : host;
            Port = port > 0 ? port : 8500;
            Token = token;
        }

        public string Host { get; }

        public int Port { get; }

        public string Token { get; }
    }
}