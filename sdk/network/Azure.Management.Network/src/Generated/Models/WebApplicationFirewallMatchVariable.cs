// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> Match Variable. </summary>
    public readonly partial struct WebApplicationFirewallMatchVariable : IEquatable<WebApplicationFirewallMatchVariable>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="WebApplicationFirewallMatchVariable"/> values are the same. </summary>
        public WebApplicationFirewallMatchVariable(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RemoteAddrValue = "RemoteAddr";
        private const string RequestMethodValue = "RequestMethod";
        private const string QueryStringValue = "QueryString";
        private const string PostArgsValue = "PostArgs";
        private const string RequestUriValue = "RequestUri";
        private const string RequestHeadersValue = "RequestHeaders";
        private const string RequestBodyValue = "RequestBody";
        private const string RequestCookiesValue = "RequestCookies";

        /// <summary> RemoteAddr. </summary>
        public static WebApplicationFirewallMatchVariable RemoteAddr { get; } = new WebApplicationFirewallMatchVariable(RemoteAddrValue);
        /// <summary> RequestMethod. </summary>
        public static WebApplicationFirewallMatchVariable RequestMethod { get; } = new WebApplicationFirewallMatchVariable(RequestMethodValue);
        /// <summary> QueryString. </summary>
        public static WebApplicationFirewallMatchVariable QueryString { get; } = new WebApplicationFirewallMatchVariable(QueryStringValue);
        /// <summary> PostArgs. </summary>
        public static WebApplicationFirewallMatchVariable PostArgs { get; } = new WebApplicationFirewallMatchVariable(PostArgsValue);
        /// <summary> RequestUri. </summary>
        public static WebApplicationFirewallMatchVariable RequestUri { get; } = new WebApplicationFirewallMatchVariable(RequestUriValue);
        /// <summary> RequestHeaders. </summary>
        public static WebApplicationFirewallMatchVariable RequestHeaders { get; } = new WebApplicationFirewallMatchVariable(RequestHeadersValue);
        /// <summary> RequestBody. </summary>
        public static WebApplicationFirewallMatchVariable RequestBody { get; } = new WebApplicationFirewallMatchVariable(RequestBodyValue);
        /// <summary> RequestCookies. </summary>
        public static WebApplicationFirewallMatchVariable RequestCookies { get; } = new WebApplicationFirewallMatchVariable(RequestCookiesValue);
        /// <summary> Determines if two <see cref="WebApplicationFirewallMatchVariable"/> values are the same. </summary>
        public static bool operator ==(WebApplicationFirewallMatchVariable left, WebApplicationFirewallMatchVariable right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebApplicationFirewallMatchVariable"/> values are not the same. </summary>
        public static bool operator !=(WebApplicationFirewallMatchVariable left, WebApplicationFirewallMatchVariable right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebApplicationFirewallMatchVariable"/>. </summary>
        public static implicit operator WebApplicationFirewallMatchVariable(string value) => new WebApplicationFirewallMatchVariable(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebApplicationFirewallMatchVariable other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebApplicationFirewallMatchVariable other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
