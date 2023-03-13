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
    /// Domain
    /// </summary>
    [DataContract(Name = "Domain")]
    public partial class Domain : IEquatable<Domain>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Domain" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="version">version.</param>
        /// <param name="chainId">chainId.</param>
        /// <param name="verifyingContract">verifyingContract.</param>
        public Domain(string name = default(string), string version = default(string), string chainId = default(string), string verifyingContract = default(string))
        {
            this.Name = name;
            this._Version = version;
            this.ChainId = chainId;
            this.VerifyingContract = verifyingContract;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string _Version { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [DataMember(Name = "chainId", EmitDefaultValue = true)]
        public string ChainId { get; set; }

        /// <summary>
        /// Gets or Sets VerifyingContract
        /// </summary>
        [DataMember(Name = "verifyingContract", EmitDefaultValue = true)]
        public string VerifyingContract { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Domain {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  VerifyingContract: ").Append(VerifyingContract).Append("\n");
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
            return this.Equals(input as Domain);
        }

        /// <summary>
        /// Returns true if Domain instances are equal
        /// </summary>
        /// <param name="input">Instance of Domain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Domain input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    (this.ChainId != null &&
                    this.ChainId.Equals(input.ChainId))
                ) && 
                (
                    this.VerifyingContract == input.VerifyingContract ||
                    (this.VerifyingContract != null &&
                    this.VerifyingContract.Equals(input.VerifyingContract))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.ChainId != null)
                {
                    hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                }
                if (this.VerifyingContract != null)
                {
                    hashCode = (hashCode * 59) + this.VerifyingContract.GetHashCode();
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
