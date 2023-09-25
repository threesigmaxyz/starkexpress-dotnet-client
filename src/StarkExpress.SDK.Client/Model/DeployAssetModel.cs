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
    /// DeployAssetModel
    /// </summary>
    [DataContract(Name = "DeployAssetModel")]
    public partial class DeployAssetModel : IEquatable<DeployAssetModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public AssetType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployAssetModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeployAssetModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployAssetModel" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="name">The token&#39;s name (eg. USD Coin). (required).</param>
        /// <param name="symbol">The token&#39;s symbol (eg. USDC). (required).</param>
        /// <param name="uri">The token&#39;s metadata uri (for ERC-721 and ERC-1155 tokens)..</param>
        /// <param name="quantum">The token&#39;s StarkEx asset quantum (for ERC-20 and ERC-1155 tokens)..</param>
        public DeployAssetModel(AssetType type = default(AssetType), string name = default(string), string symbol = default(string), string uri = default(string), string quantum = default(string))
        {
            this.Type = type;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DeployAssetModel and cannot be null");
            }
            this.Name = name;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for DeployAssetModel and cannot be null");
            }
            this.Symbol = symbol;
            this.Uri = uri;
            this.Quantum = quantum;
        }

        /// <summary>
        /// The token&#39;s name (eg. USD Coin).
        /// </summary>
        /// <value>The token&#39;s name (eg. USD Coin).</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The token&#39;s symbol (eg. USDC).
        /// </summary>
        /// <value>The token&#39;s symbol (eg. USDC).</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// The token&#39;s metadata uri (for ERC-721 and ERC-1155 tokens).
        /// </summary>
        /// <value>The token&#39;s metadata uri (for ERC-721 and ERC-1155 tokens).</value>
        [DataMember(Name = "uri", EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// The token&#39;s StarkEx asset quantum (for ERC-20 and ERC-1155 tokens).
        /// </summary>
        /// <value>The token&#39;s StarkEx asset quantum (for ERC-20 and ERC-1155 tokens).</value>
        [DataMember(Name = "quantum", EmitDefaultValue = false)]
        public string Quantum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeployAssetModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Quantum: ").Append(Quantum).Append("\n");
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
            return this.Equals(input as DeployAssetModel);
        }

        /// <summary>
        /// Returns true if DeployAssetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployAssetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployAssetModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Quantum == input.Quantum ||
                    (this.Quantum != null &&
                    this.Quantum.Equals(input.Quantum))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.Uri != null)
                {
                    hashCode = (hashCode * 59) + this.Uri.GetHashCode();
                }
                if (this.Quantum != null)
                {
                    hashCode = (hashCode * 59) + this.Quantum.GetHashCode();
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Symbol (string) minLength
            if (this.Symbol != null && this.Symbol.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Symbol, length must be greater than 1.", new [] { "Symbol" });
            }

            yield break;
        }
    }

}
