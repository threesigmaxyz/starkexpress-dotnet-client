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
    /// Request model to fetch details for a signable order.
    /// </summary>
    [DataContract(Name = "OrderDetailsModel")]
    public partial class OrderDetailsModel : IEquatable<OrderDetailsModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [DataMember(Name = "side", IsRequired = true, EmitDefaultValue = true)]
        public OrderSide Side { get; set; }

        /// <summary>
        /// Gets or Sets SellDataAvailabilityMode
        /// </summary>
        [DataMember(Name = "sellDataAvailabilityMode", IsRequired = true, EmitDefaultValue = true)]
        public DataAvailabilityModes SellDataAvailabilityMode { get; set; }

        /// <summary>
        /// Gets or Sets BuyDataAvailabilityMode
        /// </summary>
        [DataMember(Name = "buyDataAvailabilityMode", IsRequired = true, EmitDefaultValue = true)]
        public DataAvailabilityModes BuyDataAvailabilityMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailsModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderDetailsModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailsModel" /> class.
        /// </summary>
        /// <param name="orderbookId">The ID of the orderbook. (required).</param>
        /// <param name="userId">The unique identifier of the user submitting the order. (required).</param>
        /// <param name="side">side (required).</param>
        /// <param name="price">The order price. (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="sellDataAvailabilityMode">sellDataAvailabilityMode (required).</param>
        /// <param name="buyDataAvailabilityMode">buyDataAvailabilityMode (required).</param>
        public OrderDetailsModel(Guid orderbookId = default(Guid), Guid userId = default(Guid), OrderSide side = default(OrderSide), double price = default(double), BigInteger amount = default(BigInteger), DataAvailabilityModes sellDataAvailabilityMode = default(DataAvailabilityModes), DataAvailabilityModes buyDataAvailabilityMode = default(DataAvailabilityModes))
        {
            this.OrderbookId = orderbookId;
            this.UserId = userId;
            this.Side = side;
            this.Price = price;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for OrderDetailsModel and cannot be null");
            }
            this.Amount = amount;
            this.SellDataAvailabilityMode = sellDataAvailabilityMode;
            this.BuyDataAvailabilityMode = buyDataAvailabilityMode;
        }

        /// <summary>
        /// The ID of the orderbook.
        /// </summary>
        /// <value>The ID of the orderbook.</value>
        [DataMember(Name = "orderbookId", IsRequired = true, EmitDefaultValue = true)]
        public Guid OrderbookId { get; set; }

        /// <summary>
        /// The unique identifier of the user submitting the order.
        /// </summary>
        /// <value>The unique identifier of the user submitting the order.</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The order price.
        /// </summary>
        /// <value>The order price.</value>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = true)]
        public double Price { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public BigInteger Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailsModel {\n");
            sb.Append("  OrderbookId: ").Append(OrderbookId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  SellDataAvailabilityMode: ").Append(SellDataAvailabilityMode).Append("\n");
            sb.Append("  BuyDataAvailabilityMode: ").Append(BuyDataAvailabilityMode).Append("\n");
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
            return this.Equals(input as OrderDetailsModel);
        }

        /// <summary>
        /// Returns true if OrderDetailsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderDetailsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderDetailsModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderbookId == input.OrderbookId ||
                    (this.OrderbookId != null &&
                    this.OrderbookId.Equals(input.OrderbookId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Side == input.Side ||
                    this.Side.Equals(input.Side)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.SellDataAvailabilityMode == input.SellDataAvailabilityMode ||
                    this.SellDataAvailabilityMode.Equals(input.SellDataAvailabilityMode)
                ) && 
                (
                    this.BuyDataAvailabilityMode == input.BuyDataAvailabilityMode ||
                    this.BuyDataAvailabilityMode.Equals(input.BuyDataAvailabilityMode)
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
                if (this.OrderbookId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderbookId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Side.GetHashCode();
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SellDataAvailabilityMode.GetHashCode();
                hashCode = (hashCode * 59) + this.BuyDataAvailabilityMode.GetHashCode();
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