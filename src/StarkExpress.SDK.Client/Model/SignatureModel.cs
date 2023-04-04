/*
 * StarkExpress API Docs
 *
 * An API for the StarkExpress platform.
 *
 * The version of the OpenAPI document: 1.0
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
    /// Model representing an ECDSA signature data.
    /// </summary>
    [DataContract(Name = "SignatureModel")]
    public partial class SignatureModel : IEquatable<SignatureModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignatureModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureModel" /> class.
        /// </summary>
        /// <param name="r">The R component of the ECDSA signature, represented as a hexadecimal string. (required).</param>
        /// <param name="s">The S component of the ECDSA signature, represented as a hexadecimal string. (required).</param>
        public SignatureModel(string r = default(string), string s = default(string))
        {
            // to ensure "r" is required (not null)
            if (r == null)
            {
                throw new ArgumentNullException("r is a required property for SignatureModel and cannot be null");
            }
            this.R = r;
            // to ensure "s" is required (not null)
            if (s == null)
            {
                throw new ArgumentNullException("s is a required property for SignatureModel and cannot be null");
            }
            this.S = s;
        }

        /// <summary>
        /// The R component of the ECDSA signature, represented as a hexadecimal string.
        /// </summary>
        /// <value>The R component of the ECDSA signature, represented as a hexadecimal string.</value>
        [DataMember(Name = "r", IsRequired = true, EmitDefaultValue = true)]
        public string R { get; set; }

        /// <summary>
        /// The S component of the ECDSA signature, represented as a hexadecimal string.
        /// </summary>
        /// <value>The S component of the ECDSA signature, represented as a hexadecimal string.</value>
        [DataMember(Name = "s", IsRequired = true, EmitDefaultValue = true)]
        public string S { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignatureModel {\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  S: ").Append(S).Append("\n");
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
            return this.Equals(input as SignatureModel);
        }

        /// <summary>
        /// Returns true if SignatureModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SignatureModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.R == input.R ||
                    (this.R != null &&
                    this.R.Equals(input.R))
                ) && 
                (
                    this.S == input.S ||
                    (this.S != null &&
                    this.S.Equals(input.S))
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
                if (this.R != null)
                {
                    hashCode = (hashCode * 59) + this.R.GetHashCode();
                }
                if (this.S != null)
                {
                    hashCode = (hashCode * 59) + this.S.GetHashCode();
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
            // R (string) minLength
            if (this.R != null && this.R.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for R, length must be greater than 1.", new [] { "R" });
            }

            // S (string) minLength
            if (this.S != null && this.S.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for S, length must be greater than 1.", new [] { "S" });
            }

            yield break;
        }
    }

}
