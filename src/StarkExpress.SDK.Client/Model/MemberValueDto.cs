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
    /// MemberValueDto
    /// </summary>
    [DataContract(Name = "MemberValueDto")]
    public partial class MemberValueDto : IEquatable<MemberValueDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberValueDto" /> class.
        /// </summary>
        /// <param name="typeName">The type name of the variable..</param>
        /// <param name="value">The value of the variable..</param>
        public MemberValueDto(string typeName = default(string), string value = default(string))
        {
            this.TypeName = typeName;
            this.Value = value;
        }

        /// <summary>
        /// The type name of the variable.
        /// </summary>
        /// <value>The type name of the variable.</value>
        [DataMember(Name = "typeName", EmitDefaultValue = true)]
        public string TypeName { get; set; }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        /// <value>The value of the variable.</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MemberValueDto {\n");
            sb.Append("  TypeName: ").Append(TypeName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as MemberValueDto);
        }

        /// <summary>
        /// Returns true if MemberValueDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberValueDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberValueDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TypeName == input.TypeName ||
                    (this.TypeName != null &&
                    this.TypeName.Equals(input.TypeName))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.TypeName != null)
                {
                    hashCode = (hashCode * 59) + this.TypeName.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
