// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties required to create a connection to Azure SQL database
    /// Managed instance
    /// </summary>
    public partial class MiSqlConnectionInfo : ConnectionInfo
    {
        /// <summary>
        /// Initializes a new instance of the MiSqlConnectionInfo class.
        /// </summary>
        public MiSqlConnectionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MiSqlConnectionInfo class.
        /// </summary>
        /// <param name="managedInstanceResourceId">Resource id for Azure SQL
        /// database Managed instance</param>
        /// <param name="userName">User name</param>
        /// <param name="password">Password credential.</param>
        public MiSqlConnectionInfo(string managedInstanceResourceId, string userName = default(string), string password = default(string))
            : base(userName, password)
        {
            ManagedInstanceResourceId = managedInstanceResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource id for Azure SQL database Managed instance
        /// </summary>
        [JsonProperty(PropertyName = "managedInstanceResourceId")]
        public string ManagedInstanceResourceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ManagedInstanceResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ManagedInstanceResourceId");
            }
        }
    }
}