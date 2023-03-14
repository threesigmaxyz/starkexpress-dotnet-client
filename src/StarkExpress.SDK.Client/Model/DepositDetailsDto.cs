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
    /// DepositDetailsDto
    /// </summary>
    [DataContract(Name = "DepositDetailsDto")]
    public partial class DepositDetailsDto : IEquatable<DepositDetailsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositDetailsDto" /> class.
        /// </summary>
        /// <param name="contractAddress">The smart contract address that processes on-chain deposits..</param>
        /// <param name="depositFunction">The deposit function to use on-chain..</param>
        /// <param name="starkKey">The user&#39;s public STARK key.</param>
        /// <param name="assetType">The asset type identifier..</param>
        /// <param name="tokenId">The asset token Id for NFTs..</param>
        /// <param name="vaultId">The user&#39;s vault id..</param>
        /// <param name="quantizedAmount">The quantized amount to deposit..</param>
        public DepositDetailsDto(string contractAddress = default(string), string depositFunction = default(string), string starkKey = default(string), string assetType = default(string), string tokenId = default(string), string vaultId = default(string), string quantizedAmount = default(string))
        {
            this.ContractAddress = contractAddress;
            this.DepositFunction = depositFunction;
            this.StarkKey = starkKey;
            this.AssetType = assetType;
            this.TokenId = tokenId;
            this.VaultId = vaultId;
            this.QuantizedAmount = quantizedAmount;
        }

        /// <summary>
        /// The smart contract address that processes on-chain deposits.
        /// </summary>
        /// <value>The smart contract address that processes on-chain deposits.</value>
        [DataMember(Name = "contractAddress", EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// The deposit function to use on-chain.
        /// </summary>
        /// <value>The deposit function to use on-chain.</value>
        [DataMember(Name = "depositFunction", EmitDefaultValue = true)]
        public string DepositFunction { get; set; }

        /// <summary>
        /// The user&#39;s public STARK key
        /// </summary>
        /// <value>The user&#39;s public STARK key</value>
        [DataMember(Name = "starkKey", EmitDefaultValue = true)]
        public string StarkKey { get; set; }

        /// <summary>
        /// The asset type identifier.
        /// </summary>
        /// <value>The asset type identifier.</value>
        [DataMember(Name = "assetType", EmitDefaultValue = true)]
        public string AssetType { get; set; }

        /// <summary>
        /// The asset token Id for NFTs.
        /// </summary>
        /// <value>The asset token Id for NFTs.</value>
        [DataMember(Name = "tokenId", EmitDefaultValue = true)]
        public string TokenId { get; set; }

        /// <summary>
        /// The user&#39;s vault id.
        /// </summary>
        /// <value>The user&#39;s vault id.</value>
        [DataMember(Name = "vaultId", EmitDefaultValue = false)]
        public string VaultId { get; set; }

        /// <summary>
        /// The quantized amount to deposit.
        /// </summary>
        /// <value>The quantized amount to deposit.</value>
        [DataMember(Name = "quantizedAmount", EmitDefaultValue = false)]
        public string QuantizedAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DepositDetailsDto {\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  DepositFunction: ").Append(DepositFunction).Append("\n");
            sb.Append("  StarkKey: ").Append(StarkKey).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  VaultId: ").Append(VaultId).Append("\n");
            sb.Append("  QuantizedAmount: ").Append(QuantizedAmount).Append("\n");
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
            return this.Equals(input as DepositDetailsDto);
        }

        /// <summary>
        /// Returns true if DepositDetailsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositDetailsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositDetailsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.DepositFunction == input.DepositFunction ||
                    (this.DepositFunction != null &&
                    this.DepositFunction.Equals(input.DepositFunction))
                ) && 
                (
                    this.StarkKey == input.StarkKey ||
                    (this.StarkKey != null &&
                    this.StarkKey.Equals(input.StarkKey))
                ) && 
                (
                    this.AssetType == input.AssetType ||
                    (this.AssetType != null &&
                    this.AssetType.Equals(input.AssetType))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.VaultId == input.VaultId ||
                    (this.VaultId != null &&
                    this.VaultId.Equals(input.VaultId))
                ) && 
                (
                    this.QuantizedAmount == input.QuantizedAmount ||
                    (this.QuantizedAmount != null &&
                    this.QuantizedAmount.Equals(input.QuantizedAmount))
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
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.DepositFunction != null)
                {
                    hashCode = (hashCode * 59) + this.DepositFunction.GetHashCode();
                }
                if (this.StarkKey != null)
                {
                    hashCode = (hashCode * 59) + this.StarkKey.GetHashCode();
                }
                if (this.AssetType != null)
                {
                    hashCode = (hashCode * 59) + this.AssetType.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.VaultId != null)
                {
                    hashCode = (hashCode * 59) + this.VaultId.GetHashCode();
                }
                if (this.QuantizedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.QuantizedAmount.GetHashCode();
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
