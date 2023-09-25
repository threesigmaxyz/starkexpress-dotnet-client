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
    /// Defines TransactionStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionStatus
    {
        /// <summary>
        /// Enum Created for value: Created
        /// </summary>
        [EnumMember(Value = "Created")]
        Created = 1,

        /// <summary>
        /// Enum Streamed for value: Streamed
        /// </summary>
        [EnumMember(Value = "Streamed")]
        Streamed = 2,

        /// <summary>
        /// Enum Pending for value: Pending
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending = 3,

        /// <summary>
        /// Enum Confirmed for value: Confirmed
        /// </summary>
        [EnumMember(Value = "Confirmed")]
        Confirmed = 4,

        /// <summary>
        /// Enum Reverted for value: Reverted
        /// </summary>
        [EnumMember(Value = "Reverted")]
        Reverted = 5,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 6

    }

}
