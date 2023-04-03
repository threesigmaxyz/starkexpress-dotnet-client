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
    /// TransactionDto
    /// </summary>
    [DataContract(Name = "TransactionDto")]
    public partial class TransactionDto : IEquatable<TransactionDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "operation", EmitDefaultValue = false)]
        public StarkExOperation? Operation { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public TransactionStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDto" /> class.
        /// </summary>
        /// <param name="transactionId">The ID of the transaction..</param>
        /// <param name="starkExTransactionId">The sequence ID of the transaction in StarkEx..</param>
        /// <param name="starkExInstanceId">The ID of the StarkEx instance..</param>
        /// <param name="tenantId">The ID of the tenant..</param>
        /// <param name="operation">operation.</param>
        /// <param name="status">status.</param>
        /// <param name="creationDate">The date the transaction was created..</param>
        /// <param name="rawTransaction">rawTransaction.</param>
        public TransactionDto(Guid transactionId = default(Guid), long? starkExTransactionId = default(long?), Guid starkExInstanceId = default(Guid), Guid tenantId = default(Guid), StarkExOperation? operation = default(StarkExOperation?), TransactionStatus? status = default(TransactionStatus?), DateTime creationDate = default(DateTime), TransactionModel rawTransaction = default(TransactionModel))
        {
            this.TransactionId = transactionId;
            this.StarkExTransactionId = starkExTransactionId;
            this.StarkExInstanceId = starkExInstanceId;
            this.TenantId = tenantId;
            this.Operation = operation;
            this.Status = status;
            this.CreationDate = creationDate;
            this.RawTransaction = rawTransaction;
        }

        /// <summary>
        /// The ID of the transaction.
        /// </summary>
        /// <value>The ID of the transaction.</value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public Guid TransactionId { get; set; }

        /// <summary>
        /// The sequence ID of the transaction in StarkEx.
        /// </summary>
        /// <value>The sequence ID of the transaction in StarkEx.</value>
        [DataMember(Name = "starkExTransactionId", EmitDefaultValue = true)]
        public long? StarkExTransactionId { get; set; }

        /// <summary>
        /// The ID of the StarkEx instance.
        /// </summary>
        /// <value>The ID of the StarkEx instance.</value>
        [DataMember(Name = "starkExInstanceId", EmitDefaultValue = false)]
        public Guid StarkExInstanceId { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        /// <value>The ID of the tenant.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public Guid TenantId { get; set; }

        /// <summary>
        /// The date the transaction was created.
        /// </summary>
        /// <value>The date the transaction was created.</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets RawTransaction
        /// </summary>
        [DataMember(Name = "rawTransaction", EmitDefaultValue = false)]
        public TransactionModel RawTransaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionDto {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  StarkExTransactionId: ").Append(StarkExTransactionId).Append("\n");
            sb.Append("  StarkExInstanceId: ").Append(StarkExInstanceId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  RawTransaction: ").Append(RawTransaction).Append("\n");
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
            return this.Equals(input as TransactionDto);
        }

        /// <summary>
        /// Returns true if TransactionDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.StarkExTransactionId == input.StarkExTransactionId ||
                    (this.StarkExTransactionId != null &&
                    this.StarkExTransactionId.Equals(input.StarkExTransactionId))
                ) && 
                (
                    this.StarkExInstanceId == input.StarkExInstanceId ||
                    (this.StarkExInstanceId != null &&
                    this.StarkExInstanceId.Equals(input.StarkExInstanceId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Operation == input.Operation ||
                    this.Operation.Equals(input.Operation)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.RawTransaction == input.RawTransaction ||
                    (this.RawTransaction != null &&
                    this.RawTransaction.Equals(input.RawTransaction))
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
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.StarkExTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.StarkExTransactionId.GetHashCode();
                }
                if (this.StarkExInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.StarkExInstanceId.GetHashCode();
                }
                if (this.TenantId != null)
                {
                    hashCode = (hashCode * 59) + this.TenantId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.CreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
                }
                if (this.RawTransaction != null)
                {
                    hashCode = (hashCode * 59) + this.RawTransaction.GetHashCode();
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
