/*
 * Arc API Docs
 *
 * An API for the Arc platform.
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
using FileParameter = StarkExpress.SDK.Client.Client.FileParameter;
using OpenAPIDateConverter = StarkExpress.SDK.Client.Client.OpenAPIDateConverter;

namespace StarkExpress.SDK.Client.Model
{
    /// <summary>
    /// RegisterDetailsDto
    /// </summary>
    [DataContract(Name = "RegisterDetailsDto")]
    public partial class RegisterDetailsDto : IEquatable<RegisterDetailsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterDetailsDto" /> class.
        /// </summary>
        /// <param name="domain">domain.</param>
        /// <param name="types">The types in the EIP712 message..</param>
        /// <param name="primaryType">The message primary type..</param>
        /// <param name="message">message.</param>
        /// <param name="domainRawValues">The STARK key of the sender..</param>
        /// <param name="signablePayload">The signable payload..</param>
        public RegisterDetailsDto(DomainDto domain = default(DomainDto), Dictionary<string, List<MemberDescriptionDto>> types = default(Dictionary<string, List<MemberDescriptionDto>>), string primaryType = default(string), MessageDto message = default(MessageDto), List<MemberValueDto> domainRawValues = default(List<MemberValueDto>), string signablePayload = default(string))
        {
            this.Domain = domain;
            this.Types = types;
            this.PrimaryType = primaryType;
            this.Message = message;
            this.DomainRawValues = domainRawValues;
            this.SignablePayload = signablePayload;
        }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public DomainDto Domain { get; set; }

        /// <summary>
        /// The types in the EIP712 message.
        /// </summary>
        /// <value>The types in the EIP712 message.</value>
        [DataMember(Name = "types", EmitDefaultValue = true)]
        public Dictionary<string, List<MemberDescriptionDto>> Types { get; set; }

        /// <summary>
        /// The message primary type.
        /// </summary>
        /// <value>The message primary type.</value>
        [DataMember(Name = "primaryType", EmitDefaultValue = true)]
        public string PrimaryType { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public MessageDto Message { get; set; }

        /// <summary>
        /// The STARK key of the sender.
        /// </summary>
        /// <value>The STARK key of the sender.</value>
        [DataMember(Name = "domainRawValues", EmitDefaultValue = true)]
        public List<MemberValueDto> DomainRawValues { get; set; }

        /// <summary>
        /// The signable payload.
        /// </summary>
        /// <value>The signable payload.</value>
        [DataMember(Name = "signablePayload", EmitDefaultValue = true)]
        public string SignablePayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegisterDetailsDto {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  PrimaryType: ").Append(PrimaryType).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  DomainRawValues: ").Append(DomainRawValues).Append("\n");
            sb.Append("  SignablePayload: ").Append(SignablePayload).Append("\n");
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
            return this.Equals(input as RegisterDetailsDto);
        }

        /// <summary>
        /// Returns true if RegisterDetailsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterDetailsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterDetailsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Types == input.Types ||
                    this.Types != null &&
                    input.Types != null &&
                    this.Types.SequenceEqual(input.Types)
                ) && 
                (
                    this.PrimaryType == input.PrimaryType ||
                    (this.PrimaryType != null &&
                    this.PrimaryType.Equals(input.PrimaryType))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.DomainRawValues == input.DomainRawValues ||
                    this.DomainRawValues != null &&
                    input.DomainRawValues != null &&
                    this.DomainRawValues.SequenceEqual(input.DomainRawValues)
                ) && 
                (
                    this.SignablePayload == input.SignablePayload ||
                    (this.SignablePayload != null &&
                    this.SignablePayload.Equals(input.SignablePayload))
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
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                if (this.Types != null)
                {
                    hashCode = (hashCode * 59) + this.Types.GetHashCode();
                }
                if (this.PrimaryType != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryType.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.DomainRawValues != null)
                {
                    hashCode = (hashCode * 59) + this.DomainRawValues.GetHashCode();
                }
                if (this.SignablePayload != null)
                {
                    hashCode = (hashCode * 59) + this.SignablePayload.GetHashCode();
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
