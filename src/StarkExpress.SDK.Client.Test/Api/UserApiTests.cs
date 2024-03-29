/*
 * Arc API Docs
 *
 * An API for the Arc platform.
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
using Xunit;

using StarkExpress.SDK.Client.Client;
using StarkExpress.SDK.Client.Api;
// uncomment below to import models
//using StarkExpress.SDK.Client.Model;

namespace StarkExpress.SDK.Client.Test.Api
{
    /// <summary>
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserApiTests : IDisposable
    {
        private UserApi instance;

        public UserApiTests()
        {
            instance = new UserApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserApi
            //Assert.IsType<UserApi>(instance);
        }

        /// <summary>
        /// Test EIP712Details
        /// </summary>
        [Fact]
        public void EIP712DetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string starkKey = null;
            //string address = null;
            //var response = instance.EIP712Details(username, starkKey, address);
            //Assert.IsType<RegisterDetailsDto>(response);
        }

        /// <summary>
        /// Test GetAllUsers
        /// </summary>
        [Fact]
        public void GetAllUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //FilterOptions usernameComparison = null;
            //string address = null;
            //string creationDate = null;
            //FilterOptions creationDateComparison = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //string sortBy = null;
            //var response = instance.GetAllUsers(username, usernameComparison, address, creationDate, creationDateComparison, pageNumber, pageSize, sortBy);
            //Assert.IsType<UserDtoPaginatedResponseDto>(response);
        }

        /// <summary>
        /// Test GetUser
        /// </summary>
        [Fact]
        public void GetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid userId = null;
            //var response = instance.GetUser(userId);
            //Assert.IsType<UserWithVaultsDto>(response);
        }

        /// <summary>
        /// Test RegisterUser
        /// </summary>
        [Fact]
        public void RegisterUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RegisterUserModel registerUserModel = null;
            //var response = instance.RegisterUser(registerUserModel);
            //Assert.IsType<UserDto>(response);
        }
    }
}
