using Amazon.Extensions.NETCore.Setup;
using Xerris.DotNet.Core;
using Xerris.DotNet.Core.Aws.Secrets;

namespace Sizing.Poker.Api
{
    public interface IApplicationConfig
    {
        SecretConfigCollection SecretConfigurations { get; }
    }

    public class ApplicationConfig : IApplicationConfig, IApplicationConfigBase
    {
        public SecretConfigCollection SecretConfigurations { get; set; }
        public AWSOptions AwsOptions { get; set; }
    }
}