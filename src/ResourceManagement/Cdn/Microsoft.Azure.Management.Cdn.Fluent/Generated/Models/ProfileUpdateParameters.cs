// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Profile properties required for profile update.
    /// </summary>
    public partial class ProfileUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ProfileUpdateParameters class.
        /// </summary>
        public ProfileUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the ProfileUpdateParameters class.
        /// </summary>
        /// <param name="tags">Profile tags</param>
        public ProfileUpdateParameters(System.Collections.Generic.IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary>
        /// Gets or sets profile tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Tags == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Tags");
            }
        }
    }
}