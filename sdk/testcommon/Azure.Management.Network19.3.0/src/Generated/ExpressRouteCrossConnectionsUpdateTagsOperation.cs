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
    /// <summary> Updates an express route cross connection tags. </summary>
    public partial class ExpressRouteCrossConnectionsUpdateTagsOperation : Operation<ExpressRouteCrossConnection>, IOperationSource<ExpressRouteCrossConnection>
    {
        private readonly ArmOperationHelpers<ExpressRouteCrossConnection> _operation;
        internal ExpressRouteCrossConnectionsUpdateTagsOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<ExpressRouteCrossConnection>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ExpressRouteCrossConnectionsUpdateTagsOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ExpressRouteCrossConnection Value => _operation.Value;

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
        public override ValueTask<Response<ExpressRouteCrossConnection>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ExpressRouteCrossConnection>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ExpressRouteCrossConnection IOperationSource<ExpressRouteCrossConnection>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return ExpressRouteCrossConnection.DeserializeExpressRouteCrossConnection(document.RootElement);
            }
        }

        async ValueTask<ExpressRouteCrossConnection> IOperationSource<ExpressRouteCrossConnection>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            if (document.RootElement.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            else
            {
                return ExpressRouteCrossConnection.DeserializeExpressRouteCrossConnection(document.RootElement);
            }
        }
    }
}
