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
    /// OrderbookLevel2EntryDto
    /// </summary>
    [DataContract(Name = "OrderbookLevel2EntryDto")]
    public partial class OrderbookLevel2EntryDto : IEquatable<OrderbookLevel2EntryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderbookLevel2EntryDto" /> class.
        /// </summary>
        /// <param name="price">The orderbook level price..</param>
        /// <param name="amount">The orderbook level amount..</param>
        public OrderbookLevel2EntryDto(double price = default(double), string amount = default(string))
        {
            this.Price = price;
            this.Amount = amount;
        }

        /// <summary>
        /// The orderbook level price.
        /// </summary>
        /// <value>The orderbook level price.</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public double Price { get; set; }

        /// <summary>
        /// The orderbook level amount.
        /// </summary>
        /// <value>The orderbook level amount.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderbookLevel2EntryDto {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as OrderbookLevel2EntryDto);
        }

        /// <summary>
        /// Returns true if OrderbookLevel2EntryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderbookLevel2EntryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderbookLevel2EntryDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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
