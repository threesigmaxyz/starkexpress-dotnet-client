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
    /// Defines AssetType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssetType
    {
        /// <summary>
        /// Enum Eth for value: Eth
        /// </summary>
        [EnumMember(Value = "Eth")]
        Eth = 1,

        /// <summary>
        /// Enum Erc20 for value: Erc20
        /// </summary>
        [EnumMember(Value = "Erc20")]
        Erc20 = 2,

        /// <summary>
        /// Enum Erc721 for value: Erc721
        /// </summary>
        [EnumMember(Value = "Erc721")]
        Erc721 = 3,

        /// <summary>
        /// Enum Erc1155 for value: Erc1155
        /// </summary>
        [EnumMember(Value = "Erc1155")]
        Erc1155 = 4,

        /// <summary>
        /// Enum MintableErc20 for value: MintableErc20
        /// </summary>
        [EnumMember(Value = "MintableErc20")]
        MintableErc20 = 5,

        /// <summary>
        /// Enum MintableErc721 for value: MintableErc721
        /// </summary>
        [EnumMember(Value = "MintableErc721")]
        MintableErc721 = 6

    }

}
