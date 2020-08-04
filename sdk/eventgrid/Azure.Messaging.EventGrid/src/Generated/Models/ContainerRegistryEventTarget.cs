// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The target of the event. </summary>
    public partial class ContainerRegistryEventTarget
    {
        /// <summary> Initializes a new instance of ContainerRegistryEventTarget. </summary>
        internal ContainerRegistryEventTarget()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryEventTarget. </summary>
        /// <param name="mediaType"> The MIME type of the referenced object. </param>
        /// <param name="size"> The number of bytes of the content. Same as Length field. </param>
        /// <param name="digest"> The digest of the content, as defined by the Registry V2 HTTP API Specification. </param>
        /// <param name="length"> The number of bytes of the content. Same as Size field. </param>
        /// <param name="repository"> The repository name. </param>
        /// <param name="url"> The direct URL to the content. </param>
        /// <param name="tag"> The tag name. </param>
        internal ContainerRegistryEventTarget(string mediaType, long? size, string digest, long? length, string repository, string url, string tag)
        {
            MediaType = mediaType;
            Size = size;
            Digest = digest;
            Length = length;
            Repository = repository;
            Url = url;
            Tag = tag;
        }

        /// <summary> The MIME type of the referenced object. </summary>
        public string MediaType { get; }
        /// <summary> The number of bytes of the content. Same as Length field. </summary>
        public long? Size { get; }
        /// <summary> The digest of the content, as defined by the Registry V2 HTTP API Specification. </summary>
        public string Digest { get; }
        /// <summary> The number of bytes of the content. Same as Size field. </summary>
        public long? Length { get; }
        /// <summary> The repository name. </summary>
        public string Repository { get; }
        /// <summary> The direct URL to the content. </summary>
        public string Url { get; }
        /// <summary> The tag name. </summary>
        public string Tag { get; }
    }
}
