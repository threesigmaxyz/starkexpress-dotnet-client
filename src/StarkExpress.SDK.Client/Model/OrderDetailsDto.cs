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
    /// OrderDetailsDto
    /// </summary>
    [DataContract(Name = "OrderDetailsDto")]
    public partial class OrderDetailsDto : IEquatable<OrderDetailsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailsDto" /> class.
        /// </summary>
        /// <param name="starkKey">The STARK key of the user..</param>
        /// <param name="sellQuantizedAmount">The amount to be sold, in quantized form..</param>
        /// <param name="buyQuantizedAmount">The amount to be bough, in quantized form..</param>
        /// <param name="sellVaultChainId">The vault chain ID for the asset being sold..</param>
        /// <param name="buyVaultChainId">The vault chain ID for the asset being bought..</param>
        /// <param name="sellVaultId">The vault ID for the asset being sold..</param>
        /// <param name="buyVaultId">The vault ID for the asset being bought..</param>
        /// <param name="fee">fee.</param>
        /// <param name="expirationTimestamp">The timestamp at which this order becomes invalid, in seconds since the Unix epoch..</param>
        /// <param name="nonce">The unique nonce for the order..</param>
        /// <param name="signablePayload">The signable payload for the order..</param>
        public OrderDetailsDto(string starkKey = default(string), string sellQuantizedAmount = default(string), string buyQuantizedAmount = default(string), string sellVaultChainId = default(string), string buyVaultChainId = default(string), string sellVaultId = default(string), string buyVaultId = default(string), FeeDto fee = default(FeeDto), long expirationTimestamp = default(long), int nonce = default(int), string signablePayload = default(string))
        {
            this.StarkKey = starkKey;
            this.SellQuantizedAmount = sellQuantizedAmount;
            this.BuyQuantizedAmount = buyQuantizedAmount;
            this.SellVaultChainId = sellVaultChainId;
            this.BuyVaultChainId = buyVaultChainId;
            this.SellVaultId = sellVaultId;
            this.BuyVaultId = buyVaultId;
            this.Fee = fee;
            this.ExpirationTimestamp = expirationTimestamp;
            this.Nonce = nonce;
            this.SignablePayload = signablePayload;
        }

        /// <summary>
        /// The STARK key of the user.
        /// </summary>
        /// <value>The STARK key of the user.</value>
        [DataMember(Name = "starkKey", EmitDefaultValue = true)]
        public string StarkKey { get; set; }

        /// <summary>
        /// The amount to be sold, in quantized form.
        /// </summary>
        /// <value>The amount to be sold, in quantized form.</value>
        [DataMember(Name = "sellQuantizedAmount", EmitDefaultValue = false)]
        public string SellQuantizedAmount { get; set; }

        /// <summary>
        /// The amount to be bough, in quantized form.
        /// </summary>
        /// <value>The amount to be bough, in quantized form.</value>
        [DataMember(Name = "buyQuantizedAmount", EmitDefaultValue = false)]
        public string BuyQuantizedAmount { get; set; }

        /// <summary>
        /// The vault chain ID for the asset being sold.
        /// </summary>
        /// <value>The vault chain ID for the asset being sold.</value>
        [DataMember(Name = "sellVaultChainId", EmitDefaultValue = false)]
        public string SellVaultChainId { get; set; }

        /// <summary>
        /// The vault chain ID for the asset being bought.
        /// </summary>
        /// <value>The vault chain ID for the asset being bought.</value>
        [DataMember(Name = "buyVaultChainId", EmitDefaultValue = false)]
        public string BuyVaultChainId { get; set; }

        /// <summary>
        /// The vault ID for the asset being sold.
        /// </summary>
        /// <value>The vault ID for the asset being sold.</value>
        [DataMember(Name = "sellVaultId", EmitDefaultValue = false)]
        public string SellVaultId { get; set; }

        /// <summary>
        /// The vault ID for the asset being bought.
        /// </summary>
        /// <value>The vault ID for the asset being bought.</value>
        [DataMember(Name = "buyVaultId", EmitDefaultValue = false)]
        public string BuyVaultId { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public FeeDto Fee { get; set; }

        /// <summary>
        /// The timestamp at which this order becomes invalid, in seconds since the Unix epoch.
        /// </summary>
        /// <value>The timestamp at which this order becomes invalid, in seconds since the Unix epoch.</value>
        [DataMember(Name = "expirationTimestamp", EmitDefaultValue = false)]
        public long ExpirationTimestamp { get; set; }

        /// <summary>
        /// The unique nonce for the order.
        /// </summary>
        /// <value>The unique nonce for the order.</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public int Nonce { get; set; }

        /// <summary>
        /// The signable payload for the order.
        /// </summary>
        /// <value>The signable payload for the order.</value>
        [DataMember(Name = "signablePayload", EmitDefaultValue = true)]
        public string SignablePayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailsDto {\n");
            sb.Append("  StarkKey: ").Append(StarkKey).Append("\n");
            sb.Append("  SellQuantizedAmount: ").Append(SellQuantizedAmount).Append("\n");
            sb.Append("  BuyQuantizedAmount: ").Append(BuyQuantizedAmount).Append("\n");
            sb.Append("  SellVaultChainId: ").Append(SellVaultChainId).Append("\n");
            sb.Append("  BuyVaultChainId: ").Append(BuyVaultChainId).Append("\n");
            sb.Append("  SellVaultId: ").Append(SellVaultId).Append("\n");
            sb.Append("  BuyVaultId: ").Append(BuyVaultId).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  ExpirationTimestamp: ").Append(ExpirationTimestamp).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
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
            return this.Equals(input as OrderDetailsDto);
        }

        /// <summary>
        /// Returns true if OrderDetailsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderDetailsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderDetailsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StarkKey == input.StarkKey ||
                    (this.StarkKey != null &&
                    this.StarkKey.Equals(input.StarkKey))
                ) && 
                (
                    this.SellQuantizedAmount == input.SellQuantizedAmount ||
                    (this.SellQuantizedAmount != null &&
                    this.SellQuantizedAmount.Equals(input.SellQuantizedAmount))
                ) && 
                (
                    this.BuyQuantizedAmount == input.BuyQuantizedAmount ||
                    (this.BuyQuantizedAmount != null &&
                    this.BuyQuantizedAmount.Equals(input.BuyQuantizedAmount))
                ) && 
                (
                    this.SellVaultChainId == input.SellVaultChainId ||
                    (this.SellVaultChainId != null &&
                    this.SellVaultChainId.Equals(input.SellVaultChainId))
                ) && 
                (
                    this.BuyVaultChainId == input.BuyVaultChainId ||
                    (this.BuyVaultChainId != null &&
                    this.BuyVaultChainId.Equals(input.BuyVaultChainId))
                ) && 
                (
                    this.SellVaultId == input.SellVaultId ||
                    (this.SellVaultId != null &&
                    this.SellVaultId.Equals(input.SellVaultId))
                ) && 
                (
                    this.BuyVaultId == input.BuyVaultId ||
                    (this.BuyVaultId != null &&
                    this.BuyVaultId.Equals(input.BuyVaultId))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.ExpirationTimestamp == input.ExpirationTimestamp ||
                    this.ExpirationTimestamp.Equals(input.ExpirationTimestamp)
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
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
                if (this.StarkKey != null)
                {
                    hashCode = (hashCode * 59) + this.StarkKey.GetHashCode();
                }
                if (this.SellQuantizedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SellQuantizedAmount.GetHashCode();
                }
                if (this.BuyQuantizedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.BuyQuantizedAmount.GetHashCode();
                }
                if (this.SellVaultChainId != null)
                {
                    hashCode = (hashCode * 59) + this.SellVaultChainId.GetHashCode();
                }
                if (this.BuyVaultChainId != null)
                {
                    hashCode = (hashCode * 59) + this.BuyVaultChainId.GetHashCode();
                }
                if (this.SellVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.SellVaultId.GetHashCode();
                }
                if (this.BuyVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.BuyVaultId.GetHashCode();
                }
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpirationTimestamp.GetHashCode();
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
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
