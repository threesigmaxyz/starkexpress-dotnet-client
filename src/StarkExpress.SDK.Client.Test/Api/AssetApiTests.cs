/*
 * StarkExpress API Docs
 *
 * An API for the StarkExpress platform.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Api;
// uncomment below to import models
//using StarkExpress.SDK.Client.Model;

namespace StarkExpress.SDK.Client.Test.Api
{
    /// <summary>
    ///  Class for testing AssetApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AssetApiTests : IDisposable
    {
        private AssetApi instance;

        public AssetApiTests()
        {
            instance = new AssetApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AssetApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AssetApi
            //Assert.IsType<AssetApi>(instance);
        }

        /// <summary>
        /// Test EnableAsset
        /// </summary>
        [Fact]
        public void EnableAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EnableAssetModel enableAssetModel = null;
            //var response = instance.EnableAsset(enableAssetModel);
            //Assert.IsType<TenantAssetDto>(response);
        }

        /// <summary>
        /// Test GetAllAssets
        /// </summary>
        [Fact]
        public void GetAllAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllAssets();
            //Assert.IsType<List<TenantAssetDto>>(response);
        }

        /// <summary>
        /// Test GetAsset
        /// </summary>
        [Fact]
        public void GetAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid assetId = null;
            //var response = instance.GetAsset(assetId);
            //Assert.IsType<TenantAssetDto>(response);
        }
    }
}
