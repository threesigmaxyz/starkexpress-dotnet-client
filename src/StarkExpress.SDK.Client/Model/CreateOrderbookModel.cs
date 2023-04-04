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
    /// Request model to create an orderbook.
    /// </summary>
    [DataContract(Name = "CreateOrderbookModel")]
    public partial class CreateOrderbookModel : IEquatable<CreateOrderbookModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderbookModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrderbookModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderbookModel" /> class.
        /// </summary>
        /// <param name="baseAssetId">The ID of the orderbook base asset. (required).</param>
        /// <param name="quoteAssetId">The ID of the orderbook quote asset. (required).</param>
        /// <param name="baseAssetPrecision">The orderbook base asset decimal precision. (required).</param>
        /// <param name="quoteAssetPrecision">The orderbook quote asset decimal precision. (required).</param>
        public CreateOrderbookModel(Guid baseAssetId = default(Guid), Guid quoteAssetId = default(Guid), int baseAssetPrecision = default(int), int quoteAssetPrecision = default(int))
        {
            this.BaseAssetId = baseAssetId;
            this.QuoteAssetId = quoteAssetId;
            this.BaseAssetPrecision = baseAssetPrecision;
            this.QuoteAssetPrecision = quoteAssetPrecision;
        }

        /// <summary>
        /// The ID of the orderbook base asset.
        /// </summary>
        /// <value>The ID of the orderbook base asset.</value>
        [DataMember(Name = "baseAssetId", IsRequired = true, EmitDefaultValue = true)]
        public Guid BaseAssetId { get; set; }

        /// <summary>
        /// The ID of the orderbook quote asset.
        /// </summary>
        /// <value>The ID of the orderbook quote asset.</value>
        [DataMember(Name = "quoteAssetId", IsRequired = true, EmitDefaultValue = true)]
        public Guid QuoteAssetId { get; set; }

        /// <summary>
        /// The orderbook base asset decimal precision.
        /// </summary>
        /// <value>The orderbook base asset decimal precision.</value>
        [DataMember(Name = "baseAssetPrecision", IsRequired = true, EmitDefaultValue = true)]
        public int BaseAssetPrecision { get; set; }

        /// <summary>
        /// The orderbook quote asset decimal precision.
        /// </summary>
        /// <value>The orderbook quote asset decimal precision.</value>
        [DataMember(Name = "quoteAssetPrecision", IsRequired = true, EmitDefaultValue = true)]
        public int QuoteAssetPrecision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateOrderbookModel {\n");
            sb.Append("  BaseAssetId: ").Append(BaseAssetId).Append("\n");
            sb.Append("  QuoteAssetId: ").Append(QuoteAssetId).Append("\n");
            sb.Append("  BaseAssetPrecision: ").Append(BaseAssetPrecision).Append("\n");
            sb.Append("  QuoteAssetPrecision: ").Append(QuoteAssetPrecision).Append("\n");
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
            return this.Equals(input as CreateOrderbookModel);
        }

        /// <summary>
        /// Returns true if CreateOrderbookModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateOrderbookModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderbookModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BaseAssetId == input.BaseAssetId ||
                    (this.BaseAssetId != null &&
                    this.BaseAssetId.Equals(input.BaseAssetId))
                ) && 
                (
                    this.QuoteAssetId == input.QuoteAssetId ||
                    (this.QuoteAssetId != null &&
                    this.QuoteAssetId.Equals(input.QuoteAssetId))
                ) && 
                (
                    this.BaseAssetPrecision == input.BaseAssetPrecision ||
                    this.BaseAssetPrecision.Equals(input.BaseAssetPrecision)
                ) && 
                (
                    this.QuoteAssetPrecision == input.QuoteAssetPrecision ||
                    this.QuoteAssetPrecision.Equals(input.QuoteAssetPrecision)
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
                if (this.BaseAssetId != null)
                {
                    hashCode = (hashCode * 59) + this.BaseAssetId.GetHashCode();
                }
                if (this.QuoteAssetId != null)
                {
                    hashCode = (hashCode * 59) + this.QuoteAssetId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BaseAssetPrecision.GetHashCode();
                hashCode = (hashCode * 59) + this.QuoteAssetPrecision.GetHashCode();
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
