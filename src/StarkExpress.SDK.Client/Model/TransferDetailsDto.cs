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
    /// TransferDetailsDto
    /// </summary>
    [DataContract(Name = "TransferDetailsDto")]
    public partial class TransferDetailsDto : IEquatable<TransferDetailsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDetailsDto" /> class.
        /// </summary>
        /// <param name="senderStarkKey">The STARK key of the sender..</param>
        /// <param name="senderVaultChainId">The vault chain ID of the sender..</param>
        /// <param name="senderVaultId">The vault ID of the sender..</param>
        /// <param name="receiverStarkKey">The STARK key of the receiver..</param>
        /// <param name="receiverVaultChainId">The vault chain ID of the receiver..</param>
        /// <param name="receiverVaultId">The vault ID of the receiver..</param>
        /// <param name="assetId">The StarkEx ID of the asset being transferred..</param>
        /// <param name="quantizedAmount">The amount of the asset to be transferred, in quantized form..</param>
        /// <param name="feeVaultChainId">The vault chain ID of the fee sender..</param>
        /// <param name="feeVaultId">The vault ID of the fee sender..</param>
        /// <param name="feeQuantizedAmount">The amount of the fee asset to be collected, in quantized form..</param>
        /// <param name="feeAssetId">The StarkEx ID of the fee asset to be collected..</param>
        /// <param name="expirationTimestamp">The timestamp at which this transfer becomes invalid, in seconds since the Unix epoch..</param>
        /// <param name="nonce">The unique nonce for the transfer..</param>
        /// <param name="signablePayload">The signable payload for the transfer..</param>
        public TransferDetailsDto(string senderStarkKey = default(string), string senderVaultChainId = default(string), Guid senderVaultId = default(Guid), string receiverStarkKey = default(string), string receiverVaultChainId = default(string), Guid receiverVaultId = default(Guid), string assetId = default(string), string quantizedAmount = default(string), string feeVaultChainId = default(string), Guid feeVaultId = default(Guid), string feeQuantizedAmount = default(string), string feeAssetId = default(string), long expirationTimestamp = default(long), int nonce = default(int), string signablePayload = default(string))
        {
            this.SenderStarkKey = senderStarkKey;
            this.SenderVaultChainId = senderVaultChainId;
            this.SenderVaultId = senderVaultId;
            this.ReceiverStarkKey = receiverStarkKey;
            this.ReceiverVaultChainId = receiverVaultChainId;
            this.ReceiverVaultId = receiverVaultId;
            this.AssetId = assetId;
            this.QuantizedAmount = quantizedAmount;
            this.FeeVaultChainId = feeVaultChainId;
            this.FeeVaultId = feeVaultId;
            this.FeeQuantizedAmount = feeQuantizedAmount;
            this.FeeAssetId = feeAssetId;
            this.ExpirationTimestamp = expirationTimestamp;
            this.Nonce = nonce;
            this.SignablePayload = signablePayload;
        }

        /// <summary>
        /// The STARK key of the sender.
        /// </summary>
        /// <value>The STARK key of the sender.</value>
        [DataMember(Name = "senderStarkKey", EmitDefaultValue = true)]
        public string SenderStarkKey { get; set; }

        /// <summary>
        /// The vault chain ID of the sender.
        /// </summary>
        /// <value>The vault chain ID of the sender.</value>
        [DataMember(Name = "senderVaultChainId", EmitDefaultValue = false)]
        public string SenderVaultChainId { get; set; }

        /// <summary>
        /// The vault ID of the sender.
        /// </summary>
        /// <value>The vault ID of the sender.</value>
        [DataMember(Name = "senderVaultId", EmitDefaultValue = false)]
        public Guid SenderVaultId { get; set; }

        /// <summary>
        /// The STARK key of the receiver.
        /// </summary>
        /// <value>The STARK key of the receiver.</value>
        [DataMember(Name = "receiverStarkKey", EmitDefaultValue = true)]
        public string ReceiverStarkKey { get; set; }

        /// <summary>
        /// The vault chain ID of the receiver.
        /// </summary>
        /// <value>The vault chain ID of the receiver.</value>
        [DataMember(Name = "receiverVaultChainId", EmitDefaultValue = false)]
        public string ReceiverVaultChainId { get; set; }

        /// <summary>
        /// The vault ID of the receiver.
        /// </summary>
        /// <value>The vault ID of the receiver.</value>
        [DataMember(Name = "receiverVaultId", EmitDefaultValue = false)]
        public Guid ReceiverVaultId { get; set; }

        /// <summary>
        /// The StarkEx ID of the asset being transferred.
        /// </summary>
        /// <value>The StarkEx ID of the asset being transferred.</value>
        [DataMember(Name = "assetId", EmitDefaultValue = true)]
        public string AssetId { get; set; }

        /// <summary>
        /// The amount of the asset to be transferred, in quantized form.
        /// </summary>
        /// <value>The amount of the asset to be transferred, in quantized form.</value>
        [DataMember(Name = "quantizedAmount", EmitDefaultValue = false)]
        public string QuantizedAmount { get; set; }

        /// <summary>
        /// The vault chain ID of the fee sender.
        /// </summary>
        /// <value>The vault chain ID of the fee sender.</value>
        [DataMember(Name = "feeVaultChainId", EmitDefaultValue = false)]
        public string FeeVaultChainId { get; set; }

        /// <summary>
        /// The vault ID of the fee sender.
        /// </summary>
        /// <value>The vault ID of the fee sender.</value>
        [DataMember(Name = "feeVaultId", EmitDefaultValue = false)]
        public Guid FeeVaultId { get; set; }

        /// <summary>
        /// The amount of the fee asset to be collected, in quantized form.
        /// </summary>
        /// <value>The amount of the fee asset to be collected, in quantized form.</value>
        [DataMember(Name = "feeQuantizedAmount", EmitDefaultValue = false)]
        public string FeeQuantizedAmount { get; set; }

        /// <summary>
        /// The StarkEx ID of the fee asset to be collected.
        /// </summary>
        /// <value>The StarkEx ID of the fee asset to be collected.</value>
        [DataMember(Name = "feeAssetId", EmitDefaultValue = true)]
        public string FeeAssetId { get; set; }

        /// <summary>
        /// The timestamp at which this transfer becomes invalid, in seconds since the Unix epoch.
        /// </summary>
        /// <value>The timestamp at which this transfer becomes invalid, in seconds since the Unix epoch.</value>
        [DataMember(Name = "expirationTimestamp", EmitDefaultValue = false)]
        public long ExpirationTimestamp { get; set; }

        /// <summary>
        /// The unique nonce for the transfer.
        /// </summary>
        /// <value>The unique nonce for the transfer.</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public int Nonce { get; set; }

        /// <summary>
        /// The signable payload for the transfer.
        /// </summary>
        /// <value>The signable payload for the transfer.</value>
        [DataMember(Name = "signablePayload", EmitDefaultValue = true)]
        public string SignablePayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferDetailsDto {\n");
            sb.Append("  SenderStarkKey: ").Append(SenderStarkKey).Append("\n");
            sb.Append("  SenderVaultChainId: ").Append(SenderVaultChainId).Append("\n");
            sb.Append("  SenderVaultId: ").Append(SenderVaultId).Append("\n");
            sb.Append("  ReceiverStarkKey: ").Append(ReceiverStarkKey).Append("\n");
            sb.Append("  ReceiverVaultChainId: ").Append(ReceiverVaultChainId).Append("\n");
            sb.Append("  ReceiverVaultId: ").Append(ReceiverVaultId).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  QuantizedAmount: ").Append(QuantizedAmount).Append("\n");
            sb.Append("  FeeVaultChainId: ").Append(FeeVaultChainId).Append("\n");
            sb.Append("  FeeVaultId: ").Append(FeeVaultId).Append("\n");
            sb.Append("  FeeQuantizedAmount: ").Append(FeeQuantizedAmount).Append("\n");
            sb.Append("  FeeAssetId: ").Append(FeeAssetId).Append("\n");
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
            return this.Equals(input as TransferDetailsDto);
        }

        /// <summary>
        /// Returns true if TransferDetailsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferDetailsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferDetailsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SenderStarkKey == input.SenderStarkKey ||
                    (this.SenderStarkKey != null &&
                    this.SenderStarkKey.Equals(input.SenderStarkKey))
                ) && 
                (
                    this.SenderVaultChainId == input.SenderVaultChainId ||
                    (this.SenderVaultChainId != null &&
                    this.SenderVaultChainId.Equals(input.SenderVaultChainId))
                ) && 
                (
                    this.SenderVaultId == input.SenderVaultId ||
                    (this.SenderVaultId != null &&
                    this.SenderVaultId.Equals(input.SenderVaultId))
                ) && 
                (
                    this.ReceiverStarkKey == input.ReceiverStarkKey ||
                    (this.ReceiverStarkKey != null &&
                    this.ReceiverStarkKey.Equals(input.ReceiverStarkKey))
                ) && 
                (
                    this.ReceiverVaultChainId == input.ReceiverVaultChainId ||
                    (this.ReceiverVaultChainId != null &&
                    this.ReceiverVaultChainId.Equals(input.ReceiverVaultChainId))
                ) && 
                (
                    this.ReceiverVaultId == input.ReceiverVaultId ||
                    (this.ReceiverVaultId != null &&
                    this.ReceiverVaultId.Equals(input.ReceiverVaultId))
                ) && 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.QuantizedAmount == input.QuantizedAmount ||
                    (this.QuantizedAmount != null &&
                    this.QuantizedAmount.Equals(input.QuantizedAmount))
                ) && 
                (
                    this.FeeVaultChainId == input.FeeVaultChainId ||
                    (this.FeeVaultChainId != null &&
                    this.FeeVaultChainId.Equals(input.FeeVaultChainId))
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
                    this.FeeAssetId == input.FeeAssetId ||
                    (this.FeeAssetId != null &&
                    this.FeeAssetId.Equals(input.FeeAssetId))
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
                if (this.SenderStarkKey != null)
                {
                    hashCode = (hashCode * 59) + this.SenderStarkKey.GetHashCode();
                }
                if (this.SenderVaultChainId != null)
                {
                    hashCode = (hashCode * 59) + this.SenderVaultChainId.GetHashCode();
                }
                if (this.SenderVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.SenderVaultId.GetHashCode();
                }
                if (this.ReceiverStarkKey != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiverStarkKey.GetHashCode();
                }
                if (this.ReceiverVaultChainId != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiverVaultChainId.GetHashCode();
                }
                if (this.ReceiverVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiverVaultId.GetHashCode();
                }
                if (this.AssetId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetId.GetHashCode();
                }
                if (this.QuantizedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.QuantizedAmount.GetHashCode();
                }
                if (this.FeeVaultChainId != null)
                {
                    hashCode = (hashCode * 59) + this.FeeVaultChainId.GetHashCode();
                }
                if (this.FeeVaultId != null)
                {
                    hashCode = (hashCode * 59) + this.FeeVaultId.GetHashCode();
                }
                if (this.FeeQuantizedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FeeQuantizedAmount.GetHashCode();
                }
                if (this.FeeAssetId != null)
                {
                    hashCode = (hashCode * 59) + this.FeeAssetId.GetHashCode();
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
