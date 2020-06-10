// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The AuthenticationMechanism. </summary>
    public partial class AuthenticationMechanism
    {
        /// <summary> Initializes a new instance of AuthenticationMechanism. </summary>
        public AuthenticationMechanism()
        {
        }

        /// <summary> Initializes a new instance of AuthenticationMechanism. </summary>
        /// <param name="symmetricKey"> . </param>
        /// <param name="x509Thumbprint"> . </param>
        /// <param name="type"> . </param>
        internal AuthenticationMechanism(SymmetricKey symmetricKey, X509Thumbprint x509Thumbprint, AuthenticationMechanismType? type)
        {
            SymmetricKey = symmetricKey;
            X509Thumbprint = x509Thumbprint;
            Type = type;
        }

        public SymmetricKey SymmetricKey { get; set; }
        public X509Thumbprint X509Thumbprint { get; set; }
        public AuthenticationMechanismType? Type { get; set; }
    }
}