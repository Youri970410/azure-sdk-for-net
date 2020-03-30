using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Management.Storage
{
    public partial class PrivateEndpointConnectionsClient
    {
        public PrivateEndpointConnectionsClient(string subscriptionId, TokenCredential tokenCredential) : this(subscriptionId, tokenCredential, StorageManagementClientOptions.Default)
        {
        }

        public PrivateEndpointConnectionsClient(string subscriptionId, TokenCredential tokenCredential, StorageManagementClientOptions options) :
            this(new ClientDiagnostics(options), ManagementClientPipeline.Build(options, tokenCredential), subscriptionId, apiVersion: options.VersionString)
        {
        }
    }
}
