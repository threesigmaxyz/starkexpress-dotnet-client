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
    /// OrderDto
    /// </summary>
    [DataContract(Name = "OrderDto")]
    public partial class OrderDto : IEquatable<OrderDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDto" /> class.
        /// </summary>
        /// <param name="orderId">The ID of the order..</param>
        /// <param name="orderbookId">The ID of the orderbook..</param>
        /// <param name="price">The order price..</param>
        /// <param name="originalAmount">The original order amount..</param>
        /// <param name="executedAmount">The executed order amount..</param>
        /// <param name="fills">The order fills..</param>
        public OrderDto(Guid orderId = default(Guid), Guid orderbookId = default(Guid), double price = default(double), string originalAmount = default(string), string executedAmount = default(string), List<OrderFillDto> fills = default(List<OrderFillDto>))
        {
            this.OrderId = orderId;
            this.OrderbookId = orderbookId;
            this.Price = price;
            this.OriginalAmount = originalAmount;
            this.ExecutedAmount = executedAmount;
            this.Fills = fills;
        }

        /// <summary>
        /// The ID of the order.
        /// </summary>
        /// <value>The ID of the order.</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public Guid OrderId { get; set; }

        /// <summary>
        /// The ID of the orderbook.
        /// </summary>
        /// <value>The ID of the orderbook.</value>
        [DataMember(Name = "orderbookId", EmitDefaultValue = false)]
        public Guid OrderbookId { get; set; }

        /// <summary>
        /// The order price.
        /// </summary>
        /// <value>The order price.</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public double Price { get; set; }

        /// <summary>
        /// The original order amount.
        /// </summary>
        /// <value>The original order amount.</value>
        [DataMember(Name = "originalAmount", EmitDefaultValue = false)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// The executed order amount.
        /// </summary>
        /// <value>The executed order amount.</value>
        [DataMember(Name = "executedAmount", EmitDefaultValue = false)]
        public string ExecutedAmount { get; set; }

        /// <summary>
        /// The order fills.
        /// </summary>
        /// <value>The order fills.</value>
        [DataMember(Name = "fills", EmitDefaultValue = true)]
        public List<OrderFillDto> Fills { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDto {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderbookId: ").Append(OrderbookId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  OriginalAmount: ").Append(OriginalAmount).Append("\n");
            sb.Append("  ExecutedAmount: ").Append(ExecutedAmount).Append("\n");
            sb.Append("  Fills: ").Append(Fills).Append("\n");
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
            return this.Equals(input as OrderDto);
        }

        /// <summary>
        /// Returns true if OrderDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OrderbookId == input.OrderbookId ||
                    (this.OrderbookId != null &&
                    this.OrderbookId.Equals(input.OrderbookId))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.OriginalAmount == input.OriginalAmount ||
                    (this.OriginalAmount != null &&
                    this.OriginalAmount.Equals(input.OriginalAmount))
                ) && 
                (
                    this.ExecutedAmount == input.ExecutedAmount ||
                    (this.ExecutedAmount != null &&
                    this.ExecutedAmount.Equals(input.ExecutedAmount))
                ) && 
                (
                    this.Fills == input.Fills ||
                    this.Fills != null &&
                    input.Fills != null &&
                    this.Fills.SequenceEqual(input.Fills)
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
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.OrderbookId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderbookId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                if (this.OriginalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalAmount.GetHashCode();
                }
                if (this.ExecutedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ExecutedAmount.GetHashCode();
                }
                if (this.Fills != null)
                {
                    hashCode = (hashCode * 59) + this.Fills.GetHashCode();
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
