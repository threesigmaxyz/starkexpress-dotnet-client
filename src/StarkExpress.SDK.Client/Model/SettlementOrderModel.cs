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
    /// SettlementOrderModel
    /// </summary>
    [DataContract(Name = "SettlementOrderModel")]
    public partial class SettlementOrderModel : IEquatable<SettlementOrderModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementOrderModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SettlementOrderModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementOrderModel" /> class.
        /// </summary>
        /// <param name="buyVaultId">The unique identifier of the buy vault. (required).</param>
        /// <param name="buyQuantizedAmount">The amount of the asset to be settled, in quantized form. (required).</param>
        /// <param name="sellVaultId">The unique identifier of the sell vault. (required).</param>
        /// <param name="sellQuantizedAmount">The amount of the asset to be settled, in quantized form. (required).</param>
        /// <param name="feeVaultId">The unique identifier of the transfer sender vault..</param>
        /// <param name="feeQuantizedAmount">The amount of the fee asset to be collected, in quantized form..</param>
        /// <param name="nonce">The unique nonce for the transfer. (required).</param>
        /// <param name="signature">signature (required).</param>
        /// <param name="expirationTimestamp">The timestamp at which this transfer becomes invalid, in seconds since the Unix epoch. (required).</param>
        public SettlementOrderModel(Guid buyVaultId = default(Guid), string buyQuantizedAmount = default(string), Guid sellVaultId = default(Guid), string sellQuantizedAmount = default(string), Guid? feeVaultId = default(Guid?), string feeQuantizedAmount = default(string), int nonce = default(int), SignatureModel signature = default(SignatureModel), long expirationTimestamp = default(long))
        {
            this.BuyVaultId = buyVaultId;
            // to ensure "buyQuantizedAmount" is required (not null)
            if (buyQuantizedAmount == null)
            {
                throw new ArgumentNullException("buyQuantizedAmount is a required property for SettlementOrderModel and cannot be null");
            }
            this.BuyQuantizedAmount = buyQuantizedAmount;
            this.SellVaultId = sellVaultId;
            // to ensure "sellQuantizedAmount" is required (not null)
            if (sellQuantizedAmount == null)
            {
                throw new ArgumentNullException("sellQuantizedAmount is a required property for SettlementOrderModel and cannot be null");
            }
            this.SellQuantizedAmount = sellQuantizedAmount;
            this.Nonce = nonce;
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new ArgumentNullException("signature is a required property for SettlementOrderModel and cannot be null");
            }
            this.Signature = signature;
            this.ExpirationTimestamp = expirationTimestamp;
            this.FeeVaultId = feeVaultId;
            this.FeeQuantizedAmount = feeQuantizedAmount;
        }

        /// <summary>
        /// The unique identifier of the buy vault.
        /// </summary>
        /// <value>The unique identifier of the buy vault.</value>
        [DataMember(Name = "buyVaultId", IsRequired = true, EmitDefaultValue = true)]
        public Guid BuyVaultId { get; set; }

        /// <summary>
        /// The amount of the asset to be settled, in quantized form.
        /// </summary>
        /// <value>The amount of the asset to be settled, in quantized form.</value>
        [DataMember(Name = "buyQuantizedAmount", IsRequired = true, EmitDefaultValue = true)]
        public string BuyQuantizedAmount { get; set; }

        /// <summary>
        /// The unique identifier of the sell vault.
        /// </summary>
        /// <value>The unique identifier of the sell vault.</value>
        [DataMember(Name = "sellVaultId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SellVaultId { get; set; }

        /// <summary>
        /// The amount of the asset to be settled, in quantized form.
        /// </summary>
        /// <value>The amount of the asset to be settled, in quantized form.</value>
        [DataMember(Name = "sellQuantizedAmount", IsRequired = true, EmitDefaultValue = true)]
        public string SellQuantizedAmount { get; set; }

        /// <summary>
        /// The unique identifier of the transfer sender vault.
        /// </summary>
        /// <value>The unique identifier of the transfer sender vault.</value>
        [DataMember(Name = "feeVaultId", EmitDefaultValue = true)]
        public Guid? FeeVaultId { get; set; }

        /// <summary>
        /// The amount of the fee asset to be collected, in quantized form.
        /// </summary>
        /// <value>The amount of the fee asset to be collected, in quantized form.</value>
        [DataMember(Name = "feeQuantizedAmount", EmitDefaultValue = true)]
        public string FeeQuantizedAmount { get; set; }

        /// <summary>
        /// The unique nonce for the transfer.
        /// </summary>
        /// <value>The unique nonce for the transfer.</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = true)]
        public int Nonce { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = true)]
        public SignatureModel Signature { get; set; }

        /// <summary>
        /// The timestamp at which this transfer becomes invalid, in seconds since the Unix epoch.
        /// </summary>
        /// <value>The timestamp at which this transfer becomes invalid, in seconds since the Unix epoch.</value>
        [DataMember(Name = "expirationTimestamp", IsRequired = true, EmitDefaultValue = true)]
        public long ExpirationTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettlementOrderModel {\n");
            sb.Append("  BuyVaultId: ").Append(BuyVaultId).Append("\n");
            sb.Append("  BuyQuantizedAmount: ").Append(BuyQuantizedAmount).Append("\n");
            sb.Append("  SellVaultId: ").Append(SellVaultId).Append("\n");
            sb.Append("  SellQuantizedAmount: ").Append(SellQuantizedAmount).Append("\n");
            sb.Append("  FeeVaultId: ").Append(FeeVaultId).Append("\n");
            sb.Append("  FeeQuantizedAmount: ").Append(FeeQuantizedAmount).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  ExpirationTimestamp: ").Append(ExpirationTimestamp).Append("\n");
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
            return this.Equals(input as SettlementOrderModel);
        }

        /// <summary>
        /// Returns true if SettlementOrderModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SettlementOrderModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettlementOrderModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BuyVaultId == input.BuyVaultId ||
                    (this.BuyVaultId != null &&
                    this.BuyVaultId.Equals(input.BuyVaultId))
                ) && 
                (
                    this.BuyQuantizedAmount == input.BuyQuantizedAmount ||
                    (this.BuyQuantizedAmount != null &&
                    this.BuyQuantizedAmount.Equals(input.BuyQuantizedAmount))
                ) && 
                (
                    this.SellVaultId == input.SellVaultId ||
                    (this.SellVaultId != null &&
                    this.SellVaultId.Equals(input.SellVaultId))
                ) && 
                (
                    this.SellQuantizedAmount == input.SellQuantizedAmount ||
                    (this.SellQuantizedAmount != null &&
                    this.SellQuantizedAmount.Equals(input.SellQuantizedAmount))
                ) && 
                (
                    this.FeeVaultId == input.FeeVaultId ||
                    (this.FeeVaultId != null &&
                    this.FeeVaultId.Equals(input.FeeVaultId))
                ) && 
                (
                    this.FeeQuantizedAmount == input.FeeQuantizedAmount ||
                    (this.FeeQuantizedAmount != null &&
                    this.FeeQuantizedAmount.Equals(input.FeeQuantizedAmount))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.ExpirationTimestamp == input.ExpirationTimestamp ||
                    this.ExpirationTimestamp.Equals(input.ExpirationTimestamp)
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
                if (this.BuyVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.BuyVaultId.GetHashCode();
                }
                if (this.BuyQuantizedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.BuyQuantizedAmount.GetHashCode();
                }
                if (this.SellVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.SellVaultId.GetHashCode();
                }
                if (this.SellQuantizedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SellQuantizedAmount.GetHashCode();
                }
                if (this.FeeVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.FeeVaultId.GetHashCode();
                }
                if (this.FeeQuantizedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FeeQuantizedAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpirationTimestamp.GetHashCode();
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
            // Nonce (int) maximum
            if (this.Nonce > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nonce, must be a value less than or equal to 2147483647.", new [] { "Nonce" });
            }

            // Nonce (int) minimum
            if (this.Nonce < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nonce, must be a value greater than or equal to 0.", new [] { "Nonce" });
            }

            yield break;
        }
    }

}
