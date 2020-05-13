// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> Updates virtual wan vpn gateway tags. </summary>
    public partial class VpnGatewaysUpdateTagsOperation : Operation<VpnGateway>, IOperationSource<VpnGateway>
    {
        private readonly ArmOperationHelpers<VpnGateway> _operation;
        internal VpnGatewaysUpdateTagsOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<VpnGateway>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VpnGatewaysUpdateTagsOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VpnGateway Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VpnGateway>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VpnGateway>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VpnGateway IOperationSource<VpnGateway>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return VpnGateway.DeserializeVpnGateway(document.RootElement);
            }
        }

        async ValueTask<VpnGateway> IOperationSource<VpnGateway>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return VpnGateway.DeserializeVpnGateway(document.RootElement);
            }
        }
    }
}
