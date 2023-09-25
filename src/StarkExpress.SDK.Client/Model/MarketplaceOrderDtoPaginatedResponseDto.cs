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
    /// MarketplaceOrderDtoPaginatedResponseDto
    /// </summary>
    [DataContract(Name = "MarketplaceOrderDtoPaginatedResponseDto")]
    public partial class MarketplaceOrderDtoPaginatedResponseDto : IEquatable<MarketplaceOrderDtoPaginatedResponseDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceOrderDtoPaginatedResponseDto" /> class.
        /// </summary>
        /// <param name="data">The data in the paginated response..</param>
        /// <param name="pagination">pagination.</param>
        /// <param name="totalCount">The total count of results available..</param>
        public MarketplaceOrderDtoPaginatedResponseDto(List<MarketplaceOrderDto> data = default(List<MarketplaceOrderDto>), PaginationDto pagination = default(PaginationDto), int totalCount = default(int))
        {
            this.Data = data;
            this.Pagination = pagination;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// The data in the paginated response.
        /// </summary>
        /// <value>The data in the paginated response.</value>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<MarketplaceOrderDto> Data { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public PaginationDto Pagination { get; set; }

        /// <summary>
        /// The total count of results available.
        /// </summary>
        /// <value>The total count of results available.</value>
        [DataMember(Name = "totalCount", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarketplaceOrderDtoPaginatedResponseDto {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as MarketplaceOrderDtoPaginatedResponseDto);
        }

        /// <summary>
        /// Returns true if MarketplaceOrderDtoPaginatedResponseDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketplaceOrderDtoPaginatedResponseDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketplaceOrderDtoPaginatedResponseDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Pagination != null)
                {
                    hashCode = (hashCode * 59) + this.Pagination.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
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
