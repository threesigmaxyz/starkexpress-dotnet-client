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
    /// WithdrawModel
    /// </summary>
    [DataContract(Name = "WithdrawModel")]
    public partial class WithdrawModel : IEquatable<WithdrawModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WithdrawModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawModel" /> class.
        /// </summary>
        /// <param name="vaultId">The unique identifier of the vault to withdraw from. (required).</param>
        /// <param name="amount">The amount of the asset to be withdrawn, in unquantized form. (required).</param>
        /// <param name="tokenId">The token Id for ERC-721 and ERC-1155 assets..</param>
        /// <param name="mintingBlob">The minting blob for Mintable ERC-20, ERC-721 and ERC-1155 assets..</param>
        public WithdrawModel(Guid vaultId = default(Guid), string amount = default(string), string tokenId = default(string), string mintingBlob = default(string))
        {
            this.VaultId = vaultId;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for WithdrawModel and cannot be null");
            }
            this.Amount = amount;
            this.TokenId = tokenId;
            this.MintingBlob = mintingBlob;
        }

        /// <summary>
        /// The unique identifier of the vault to withdraw from.
        /// </summary>
        /// <value>The unique identifier of the vault to withdraw from.</value>
        [DataMember(Name = "vaultId", IsRequired = true, EmitDefaultValue = true)]
        public Guid VaultId { get; set; }

        /// <summary>
        /// The amount of the asset to be withdrawn, in unquantized form.
        /// </summary>
        /// <value>The amount of the asset to be withdrawn, in unquantized form.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// The token Id for ERC-721 and ERC-1155 assets.
        /// </summary>
        /// <value>The token Id for ERC-721 and ERC-1155 assets.</value>
        [DataMember(Name = "tokenId", EmitDefaultValue = true)]
        public string TokenId { get; set; }

        /// <summary>
        /// The minting blob for Mintable ERC-20, ERC-721 and ERC-1155 assets.
        /// </summary>
        /// <value>The minting blob for Mintable ERC-20, ERC-721 and ERC-1155 assets.</value>
        [DataMember(Name = "mintingBlob", EmitDefaultValue = true)]
        public string MintingBlob { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WithdrawModel {\n");
            sb.Append("  VaultId: ").Append(VaultId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  MintingBlob: ").Append(MintingBlob).Append("\n");
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
            return this.Equals(input as WithdrawModel);
        }

        /// <summary>
        /// Returns true if WithdrawModel instances are equal
        /// </summary>
        /// <param name="input">Instance of WithdrawModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WithdrawModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.MintingBlob == input.MintingBlob ||
                    (this.MintingBlob != null &&
                    this.MintingBlob.Equals(input.MintingBlob))
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
                if (this.VaultId != null)
                {
                    hashCode = (hashCode * 59) + this.VaultId.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.MintingBlob != null)
                {
                    hashCode = (hashCode * 59) + this.MintingBlob.GetHashCode();
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
