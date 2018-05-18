// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties available for a Microsoft.Web resource provider operation.
    /// </summary>
    public partial class CsmOperationDescriptionProperties
    {
        /// <summary>
        /// Initializes a new instance of the CsmOperationDescriptionProperties
        /// class.
        /// </summary>
        public CsmOperationDescriptionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CsmOperationDescriptionProperties
        /// class.
        /// </summary>
        public CsmOperationDescriptionProperties(ServiceSpecification serviceSpecification = default(ServiceSpecification))
        {
            ServiceSpecification = serviceSpecification;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceSpecification")]
        public ServiceSpecification ServiceSpecification { get; set; }

    }
}
