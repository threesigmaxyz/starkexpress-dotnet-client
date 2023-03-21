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
    /// Request model to transfer assets between users.
    /// </summary>
    [DataContract(Name = "SubmitSettlementModel")]
    public partial class SubmitSettlementModel : IEquatable<SubmitSettlementModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSettlementModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubmitSettlementModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSettlementModel" /> class.
        /// </summary>
        /// <param name="makerOrder">makerOrder (required).</param>
        /// <param name="takerOrder">takerOrder (required).</param>
        /// <param name="settlementInfo">settlementInfo (required).</param>
        public SubmitSettlementModel(SubmitOrderModel makerOrder = default(SubmitOrderModel), SubmitOrderModel takerOrder = default(SubmitOrderModel), SettlementInfoModel settlementInfo = default(SettlementInfoModel))
        {
            // to ensure "makerOrder" is required (not null)
            if (makerOrder == null)
            {
                throw new ArgumentNullException("makerOrder is a required property for SubmitSettlementModel and cannot be null");
            }
            this.MakerOrder = makerOrder;
            // to ensure "takerOrder" is required (not null)
            if (takerOrder == null)
            {
                throw new ArgumentNullException("takerOrder is a required property for SubmitSettlementModel and cannot be null");
            }
            this.TakerOrder = takerOrder;
            // to ensure "settlementInfo" is required (not null)
            if (settlementInfo == null)
            {
                throw new ArgumentNullException("settlementInfo is a required property for SubmitSettlementModel and cannot be null");
            }
            this.SettlementInfo = settlementInfo;
        }

        /// <summary>
        /// Gets or Sets MakerOrder
        /// </summary>
        [DataMember(Name = "makerOrder", IsRequired = true, EmitDefaultValue = true)]
        public SubmitOrderModel MakerOrder { get; set; }

        /// <summary>
        /// Gets or Sets TakerOrder
        /// </summary>
        [DataMember(Name = "takerOrder", IsRequired = true, EmitDefaultValue = true)]
        public SubmitOrderModel TakerOrder { get; set; }

        /// <summary>
        /// Gets or Sets SettlementInfo
        /// </summary>
        [DataMember(Name = "settlementInfo", IsRequired = true, EmitDefaultValue = true)]
        public SettlementInfoModel SettlementInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubmitSettlementModel {\n");
            sb.Append("  MakerOrder: ").Append(MakerOrder).Append("\n");
            sb.Append("  TakerOrder: ").Append(TakerOrder).Append("\n");
            sb.Append("  SettlementInfo: ").Append(SettlementInfo).Append("\n");
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
            return this.Equals(input as SubmitSettlementModel);
        }

        /// <summary>
        /// Returns true if SubmitSettlementModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmitSettlementModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmitSettlementModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MakerOrder == input.MakerOrder ||
                    (this.MakerOrder != null &&
                    this.MakerOrder.Equals(input.MakerOrder))
                ) && 
                (
                    this.TakerOrder == input.TakerOrder ||
                    (this.TakerOrder != null &&
                    this.TakerOrder.Equals(input.TakerOrder))
                ) && 
                (
                    this.SettlementInfo == input.SettlementInfo ||
                    (this.SettlementInfo != null &&
                    this.SettlementInfo.Equals(input.SettlementInfo))
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
                if (this.MakerOrder != null)
                {
                    hashCode = (hashCode * 59) + this.MakerOrder.GetHashCode();
                }
                if (this.TakerOrder != null)
                {
                    hashCode = (hashCode * 59) + this.TakerOrder.GetHashCode();
                }
                if (this.SettlementInfo != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementInfo.GetHashCode();
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
