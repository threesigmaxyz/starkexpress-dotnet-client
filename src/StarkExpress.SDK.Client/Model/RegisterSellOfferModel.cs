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
    /// RegisterSellOfferModel
    /// </summary>
    [DataContract(Name = "RegisterSellOfferModel")]
    public partial class RegisterSellOfferModel : IEquatable<RegisterSellOfferModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterSellOfferModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegisterSellOfferModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterSellOfferModel" /> class.
        /// </summary>
        /// <param name="sellerId">The unique identifier of the user who is placing the sell offer. (required).</param>
        /// <param name="productVaultId">The unique identifier of the product vault. (required).</param>
        /// <param name="productAmount">The quantized amount of the product being sold. (required).</param>
        /// <param name="currencyVaultId">The unique identifier of the currency vault. (required).</param>
        /// <param name="currencyAmount">The quantized amount of the currency for which the product is being sold. (required).</param>
        /// <param name="expirationTimestamp">The timestamp at which this settlement becomes invalid, in seconds since the Unix epoch. (required).</param>
        /// <param name="nonce">The unique nonce for the transfer. (required).</param>
        /// <param name="productName">The product name if the product hasn&#39;t been listed before in the marketplace..</param>
        /// <param name="productDescription">The product description if the product hasn&#39;t been listed before in the marketplace..</param>
        /// <param name="signature">signature (required).</param>
        public RegisterSellOfferModel(Guid sellerId = default(Guid), Guid productVaultId = default(Guid), string productAmount = default(string), Guid currencyVaultId = default(Guid), string currencyAmount = default(string), long expirationTimestamp = default(long), int nonce = default(int), string productName = default(string), string productDescription = default(string), SignatureModel signature = default(SignatureModel))
        {
            this.SellerId = sellerId;
            this.ProductVaultId = productVaultId;
            // to ensure "productAmount" is required (not null)
            if (productAmount == null)
            {
                throw new ArgumentNullException("productAmount is a required property for RegisterSellOfferModel and cannot be null");
            }
            this.ProductAmount = productAmount;
            this.CurrencyVaultId = currencyVaultId;
            // to ensure "currencyAmount" is required (not null)
            if (currencyAmount == null)
            {
                throw new ArgumentNullException("currencyAmount is a required property for RegisterSellOfferModel and cannot be null");
            }
            this.CurrencyAmount = currencyAmount;
            this.ExpirationTimestamp = expirationTimestamp;
            this.Nonce = nonce;
            // to ensure "signature" is required (not null)
            if (signature == null)
            {
                throw new ArgumentNullException("signature is a required property for RegisterSellOfferModel and cannot be null");
            }
            this.Signature = signature;
            this.ProductName = productName;
            this.ProductDescription = productDescription;
        }

        /// <summary>
        /// The unique identifier of the user who is placing the sell offer.
        /// </summary>
        /// <value>The unique identifier of the user who is placing the sell offer.</value>
        [DataMember(Name = "sellerId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SellerId { get; set; }

        /// <summary>
        /// The unique identifier of the product vault.
        /// </summary>
        /// <value>The unique identifier of the product vault.</value>
        [DataMember(Name = "productVaultId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ProductVaultId { get; set; }

        /// <summary>
        /// The quantized amount of the product being sold.
        /// </summary>
        /// <value>The quantized amount of the product being sold.</value>
        [DataMember(Name = "productAmount", IsRequired = true, EmitDefaultValue = true)]
        public string ProductAmount { get; set; }

        /// <summary>
        /// The unique identifier of the currency vault.
        /// </summary>
        /// <value>The unique identifier of the currency vault.</value>
        [DataMember(Name = "currencyVaultId", IsRequired = true, EmitDefaultValue = true)]
        public Guid CurrencyVaultId { get; set; }

        /// <summary>
        /// The quantized amount of the currency for which the product is being sold.
        /// </summary>
        /// <value>The quantized amount of the currency for which the product is being sold.</value>
        [DataMember(Name = "currencyAmount", IsRequired = true, EmitDefaultValue = true)]
        public string CurrencyAmount { get; set; }

        /// <summary>
        /// The timestamp at which this settlement becomes invalid, in seconds since the Unix epoch.
        /// </summary>
        /// <value>The timestamp at which this settlement becomes invalid, in seconds since the Unix epoch.</value>
        [DataMember(Name = "expirationTimestamp", IsRequired = true, EmitDefaultValue = true)]
        public long ExpirationTimestamp { get; set; }

        /// <summary>
        /// The unique nonce for the transfer.
        /// </summary>
        /// <value>The unique nonce for the transfer.</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = true)]
        public int Nonce { get; set; }

        /// <summary>
        /// The product name if the product hasn&#39;t been listed before in the marketplace.
        /// </summary>
        /// <value>The product name if the product hasn&#39;t been listed before in the marketplace.</value>
        [DataMember(Name = "productName", EmitDefaultValue = true)]
        public string ProductName { get; set; }

        /// <summary>
        /// The product description if the product hasn&#39;t been listed before in the marketplace.
        /// </summary>
        /// <value>The product description if the product hasn&#39;t been listed before in the marketplace.</value>
        [DataMember(Name = "productDescription", EmitDefaultValue = true)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = true)]
        public SignatureModel Signature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegisterSellOfferModel {\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  ProductVaultId: ").Append(ProductVaultId).Append("\n");
            sb.Append("  ProductAmount: ").Append(ProductAmount).Append("\n");
            sb.Append("  CurrencyVaultId: ").Append(CurrencyVaultId).Append("\n");
            sb.Append("  CurrencyAmount: ").Append(CurrencyAmount).Append("\n");
            sb.Append("  ExpirationTimestamp: ").Append(ExpirationTimestamp).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as RegisterSellOfferModel);
        }

        /// <summary>
        /// Returns true if RegisterSellOfferModel instances are equal
        /// </summary>
        /// <param name="input">Instance of RegisterSellOfferModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterSellOfferModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) && 
                (
                    this.ProductVaultId == input.ProductVaultId ||
                    (this.ProductVaultId != null &&
                    this.ProductVaultId.Equals(input.ProductVaultId))
                ) && 
                (
                    this.ProductAmount == input.ProductAmount ||
                    (this.ProductAmount != null &&
                    this.ProductAmount.Equals(input.ProductAmount))
                ) && 
                (
                    this.CurrencyVaultId == input.CurrencyVaultId ||
                    (this.CurrencyVaultId != null &&
                    this.CurrencyVaultId.Equals(input.CurrencyVaultId))
                ) && 
                (
                    this.CurrencyAmount == input.CurrencyAmount ||
                    (this.CurrencyAmount != null &&
                    this.CurrencyAmount.Equals(input.CurrencyAmount))
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
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.ProductDescription == input.ProductDescription ||
                    (this.ProductDescription != null &&
                    this.ProductDescription.Equals(input.ProductDescription))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
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
                if (this.SellerId != null)
                {
                    hashCode = (hashCode * 59) + this.SellerId.GetHashCode();
                }
                if (this.ProductVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.ProductVaultId.GetHashCode();
                }
                if (this.ProductAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ProductAmount.GetHashCode();
                }
                if (this.CurrencyVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyVaultId.GetHashCode();
                }
                if (this.CurrencyAmount != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpirationTimestamp.GetHashCode();
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                if (this.ProductName != null)
                {
                    hashCode = (hashCode * 59) + this.ProductName.GetHashCode();
                }
                if (this.ProductDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ProductDescription.GetHashCode();
                }
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
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

            // ProductName (string) maxLength
            if (this.ProductName != null && this.ProductName.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductName, length must be less than 100.", new [] { "ProductName" });
            }

            // ProductDescription (string) maxLength
            if (this.ProductDescription != null && this.ProductDescription.Length > 300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductDescription, length must be less than 300.", new [] { "ProductDescription" });
            }

            yield break;
        }
    }

}
