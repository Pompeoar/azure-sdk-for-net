// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Url signing key parameters
    /// </summary>
    [Newtonsoft.Json.JsonObject("UrlSigningKey")]
    public partial class UrlSigningKeyParameters : SecretParameters
    {
        /// <summary>
        /// Initializes a new instance of the UrlSigningKeyParameters class.
        /// </summary>
        public UrlSigningKeyParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UrlSigningKeyParameters class.
        /// </summary>
        /// <param name="keyId">Defines the customer defined key Id. This id
        /// will exist in the incoming request to indicate the key used to form
        /// the hash.</param>
        /// <param name="secretSource">Resource reference to the KV
        /// secret</param>
        /// <param name="secretVersion">Version of the secret to be
        /// used</param>
        public UrlSigningKeyParameters(string keyId, ResourceReference secretSource, string secretVersion = default(string))
        {
            KeyId = keyId;
            SecretSource = secretSource;
            SecretVersion = secretVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets defines the customer defined key Id. This id will
        /// exist in the incoming request to indicate the key used to form the
        /// hash.
        /// </summary>
        [JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }

        /// <summary>
        /// Gets or sets resource reference to the KV secret
        /// </summary>
        [JsonProperty(PropertyName = "secretSource")]
        public ResourceReference SecretSource { get; set; }

        /// <summary>
        /// Gets or sets version of the secret to be used
        /// </summary>
        [JsonProperty(PropertyName = "secretVersion")]
        public string SecretVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyId");
            }
            if (SecretSource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecretSource");
            }
        }
    }
}
