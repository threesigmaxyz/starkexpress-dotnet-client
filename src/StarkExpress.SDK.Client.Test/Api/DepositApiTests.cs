/*
 * StarkExpress API Docs
 *
 * An API for the StarkExpress platform.
 *
 * The version of the OpenAPI document: 1.0
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
    ///  Class for testing DepositApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DepositApiTests : IDisposable
    {
        private DepositApi instance;

        public DepositApiTests()
        {
            instance = new DepositApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DepositApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DepositApi
            //Assert.IsType<DepositApi>(instance);
        }

        /// <summary>
        /// Test DepositDetails
        /// </summary>
        [Fact]
        public void DepositDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DepositDetailsModel depositDetailsModel = null;
            //var response = instance.DepositDetails(depositDetailsModel);
            //Assert.IsType<DepositDetailsDto>(response);
        }
    }
}
