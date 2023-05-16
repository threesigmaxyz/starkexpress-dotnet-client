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
    /// Settlement details model.
    /// </summary>
    [DataContract(Name = "SettlementInfoModel")]
    public partial class SettlementInfoModel : IEquatable<SettlementInfoModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementInfoModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SettlementInfoModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementInfoModel" /> class.
        /// </summary>
        /// <param name="orderAFeeDestinationVaultId">The unique identifier of the fee destination vault. (required).</param>
        /// <param name="orderAFeeAmount">The settlement fee amount. (required).</param>
        /// <param name="orderBFeeDestinationVaultId">The unique identifier of the fee destination vault. (required).</param>
        /// <param name="orderBFeeAmount">The settlement fee amount. (required).</param>
        public SettlementInfoModel(Guid orderAFeeDestinationVaultId = default(Guid), string orderAFeeAmount = default(string), Guid orderBFeeDestinationVaultId = default(Guid), string orderBFeeAmount = default(string))
        {
            this.OrderAFeeDestinationVaultId = orderAFeeDestinationVaultId;
            // to ensure "orderAFeeAmount" is required (not null)
            if (orderAFeeAmount == null)
            {
                throw new ArgumentNullException("orderAFeeAmount is a required property for SettlementInfoModel and cannot be null");
            }
            this.OrderAFeeAmount = orderAFeeAmount;
            this.OrderBFeeDestinationVaultId = orderBFeeDestinationVaultId;
            // to ensure "orderBFeeAmount" is required (not null)
            if (orderBFeeAmount == null)
            {
                throw new ArgumentNullException("orderBFeeAmount is a required property for SettlementInfoModel and cannot be null");
            }
            this.OrderBFeeAmount = orderBFeeAmount;
        }

        /// <summary>
        /// The unique identifier of the fee destination vault.
        /// </summary>
        /// <value>The unique identifier of the fee destination vault.</value>
        [DataMember(Name = "orderAFeeDestinationVaultId", IsRequired = true, EmitDefaultValue = true)]
        public Guid OrderAFeeDestinationVaultId { get; set; }

        /// <summary>
        /// The settlement fee amount.
        /// </summary>
        /// <value>The settlement fee amount.</value>
        [DataMember(Name = "orderAFeeAmount", IsRequired = true, EmitDefaultValue = true)]
        public string OrderAFeeAmount { get; set; }

        /// <summary>
        /// The unique identifier of the fee destination vault.
        /// </summary>
        /// <value>The unique identifier of the fee destination vault.</value>
        [DataMember(Name = "orderBFeeDestinationVaultId", IsRequired = true, EmitDefaultValue = true)]
        public Guid OrderBFeeDestinationVaultId { get; set; }

        /// <summary>
        /// The settlement fee amount.
        /// </summary>
        /// <value>The settlement fee amount.</value>
        [DataMember(Name = "orderBFeeAmount", IsRequired = true, EmitDefaultValue = true)]
        public string OrderBFeeAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettlementInfoModel {\n");
            sb.Append("  OrderAFeeDestinationVaultId: ").Append(OrderAFeeDestinationVaultId).Append("\n");
            sb.Append("  OrderAFeeAmount: ").Append(OrderAFeeAmount).Append("\n");
            sb.Append("  OrderBFeeDestinationVaultId: ").Append(OrderBFeeDestinationVaultId).Append("\n");
            sb.Append("  OrderBFeeAmount: ").Append(OrderBFeeAmount).Append("\n");
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
            return this.Equals(input as SettlementInfoModel);
        }

        /// <summary>
        /// Returns true if SettlementInfoModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SettlementInfoModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettlementInfoModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderAFeeDestinationVaultId == input.OrderAFeeDestinationVaultId ||
                    (this.OrderAFeeDestinationVaultId != null &&
                    this.OrderAFeeDestinationVaultId.Equals(input.OrderAFeeDestinationVaultId))
                ) && 
                (
                    this.OrderAFeeAmount == input.OrderAFeeAmount ||
                    (this.OrderAFeeAmount != null &&
                    this.OrderAFeeAmount.Equals(input.OrderAFeeAmount))
                ) && 
                (
                    this.OrderBFeeDestinationVaultId == input.OrderBFeeDestinationVaultId ||
                    (this.OrderBFeeDestinationVaultId != null &&
                    this.OrderBFeeDestinationVaultId.Equals(input.OrderBFeeDestinationVaultId))
                ) && 
                (
                    this.OrderBFeeAmount == input.OrderBFeeAmount ||
                    (this.OrderBFeeAmount != null &&
                    this.OrderBFeeAmount.Equals(input.OrderBFeeAmount))
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
                if (this.OrderAFeeDestinationVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderAFeeDestinationVaultId.GetHashCode();
                }
                if (this.OrderAFeeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.OrderAFeeAmount.GetHashCode();
                }
                if (this.OrderBFeeDestinationVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderBFeeDestinationVaultId.GetHashCode();
                }
                if (this.OrderBFeeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.OrderBFeeAmount.GetHashCode();
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
