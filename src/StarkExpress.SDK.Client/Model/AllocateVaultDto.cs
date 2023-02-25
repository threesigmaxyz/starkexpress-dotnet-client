/*
 * StarkExpress API Docs
 *
 * An API for the StarkExpress platform.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = StarkExpress.SDK.Client.Client.OpenAPIDateConverter;

namespace StarkExpress.SDK.Client.Model
{
    /// <summary>
    /// AllocateVaultDto
    /// </summary>
    [DataContract(Name = "AllocateVaultDto")]
    public partial class AllocateVaultDto : IEquatable<AllocateVaultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocateVaultDto" /> class.
        /// </summary>
        /// <param name="allocated">A boolean value indicating if a new vault has been allocated..</param>
        /// <param name="vault">vault.</param>
        public AllocateVaultDto(bool allocated = default(bool), VaultDto vault = default(VaultDto))
        {
            this.Allocated = allocated;
            this.Vault = vault;
        }

        /// <summary>
        /// A boolean value indicating if a new vault has been allocated.
        /// </summary>
        /// <value>A boolean value indicating if a new vault has been allocated.</value>
        [DataMember(Name = "allocated", EmitDefaultValue = true)]
        public bool Allocated { get; set; }

        /// <summary>
        /// Gets or Sets Vault
        /// </summary>
        [DataMember(Name = "vault", EmitDefaultValue = false)]
        public VaultDto Vault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AllocateVaultDto {\n");
            sb.Append("  Allocated: ").Append(Allocated).Append("\n");
            sb.Append("  Vault: ").Append(Vault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AllocateVaultDto);
        }

        /// <summary>
        /// Returns true if AllocateVaultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AllocateVaultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllocateVaultDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Allocated == input.Allocated ||
                    this.Allocated.Equals(input.Allocated)
                ) && 
                (
                    this.Vault == input.Vault ||
                    (this.Vault != null &&
                    this.Vault.Equals(input.Vault))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Allocated.GetHashCode();
                if (this.Vault != null)
                {
                    hashCode = (hashCode * 59) + this.Vault.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
