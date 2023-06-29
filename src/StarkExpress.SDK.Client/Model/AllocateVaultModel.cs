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
    /// AllocateVaultModel
    /// </summary>
    [DataContract(Name = "AllocateVaultModel")]
    public partial class AllocateVaultModel : IEquatable<AllocateVaultModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DataAvailabilityMode
        /// </summary>
        [DataMember(Name = "dataAvailabilityMode", IsRequired = true, EmitDefaultValue = true)]
        public DataAvailabilityModes DataAvailabilityMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocateVaultModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AllocateVaultModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocateVaultModel" /> class.
        /// </summary>
        /// <param name="assetId">The unique identifier of the asset..</param>
        /// <param name="userId">The unique identifier of the user..</param>
        /// <param name="dataAvailabilityMode">dataAvailabilityMode (required).</param>
        /// <param name="tokenId">The hexadecimal string representation of the vault&#39;s asset token ID, if applicable (ie. ERC-721/ERC-1155)..</param>
        /// <param name="mintingBlob">The hexadecimal string representation of the vault&#39;s asset minting blob, if applicable (ie. Mintable ERC-20/Mintable ERC-721/Mintable ERC-1155)..</param>
        public AllocateVaultModel(Guid assetId = default(Guid), Guid userId = default(Guid), DataAvailabilityModes dataAvailabilityMode = default(DataAvailabilityModes), string tokenId = default(string), string mintingBlob = default(string))
        {
            this.DataAvailabilityMode = dataAvailabilityMode;
            this.AssetId = assetId;
            this.UserId = userId;
            this.TokenId = tokenId;
            this.MintingBlob = mintingBlob;
        }

        /// <summary>
        /// The unique identifier of the asset.
        /// </summary>
        /// <value>The unique identifier of the asset.</value>
        [DataMember(Name = "assetId", EmitDefaultValue = false)]
        public Guid AssetId { get; set; }

        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        /// <value>The unique identifier of the user.</value>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The hexadecimal string representation of the vault&#39;s asset token ID, if applicable (ie. ERC-721/ERC-1155).
        /// </summary>
        /// <value>The hexadecimal string representation of the vault&#39;s asset token ID, if applicable (ie. ERC-721/ERC-1155).</value>
        [DataMember(Name = "tokenId", EmitDefaultValue = true)]
        public string TokenId { get; set; }

        /// <summary>
        /// The hexadecimal string representation of the vault&#39;s asset minting blob, if applicable (ie. Mintable ERC-20/Mintable ERC-721/Mintable ERC-1155).
        /// </summary>
        /// <value>The hexadecimal string representation of the vault&#39;s asset minting blob, if applicable (ie. Mintable ERC-20/Mintable ERC-721/Mintable ERC-1155).</value>
        [DataMember(Name = "mintingBlob", EmitDefaultValue = true)]
        public string MintingBlob { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AllocateVaultModel {\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  DataAvailabilityMode: ").Append(DataAvailabilityMode).Append("\n");
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
            return this.Equals(input as AllocateVaultModel);
        }

        /// <summary>
        /// Returns true if AllocateVaultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AllocateVaultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllocateVaultModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.DataAvailabilityMode == input.DataAvailabilityMode ||
                    this.DataAvailabilityMode.Equals(input.DataAvailabilityMode)
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
                if (this.AssetId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DataAvailabilityMode.GetHashCode();
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
