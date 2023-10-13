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
    ///  Class for testing MarketplaceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MarketplaceApiTests : IDisposable
    {
        private MarketplaceApi instance;

        public MarketplaceApiTests()
        {
            instance = new MarketplaceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MarketplaceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MarketplaceApi
            //Assert.IsType<MarketplaceApi>(instance);
        }

        /// <summary>
        /// Test BuyOrderDetails
        /// </summary>
        [Fact]
        public void BuyOrderDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BuyOrderDetailsModel buyOrderDetailsModel = null;
            //var response = instance.BuyOrderDetails(buyOrderDetailsModel);
            //Assert.IsType<OrderDetailsDto>(response);
        }

        /// <summary>
        /// Test DeleteSellOffer
        /// </summary>
        [Fact]
        public void DeleteSellOfferTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid offerId = null;
            //var response = instance.DeleteSellOffer(offerId);
            //Assert.IsType<OfferDto>(response);
        }

        /// <summary>
        /// Test ListBuyOrders
        /// </summary>
        [Fact]
        public void ListBuyOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string offerId = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //string sortBy = null;
            //var response = instance.ListBuyOrders(offerId, pageNumber, pageSize, sortBy);
            //Assert.IsType<MarketplaceOrderDtoPaginatedResponseDto>(response);
        }

        /// <summary>
        /// Test ListSellOffers
        /// </summary>
        [Fact]
        public void ListSellOffersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productId = null;
            //OfferStatus offerStatus = null;
            //string userId = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //string sortBy = null;
            //var response = instance.ListSellOffers(productId, offerStatus, userId, pageNumber, pageSize, sortBy);
            //Assert.IsType<OfferDtoPaginatedResponseDto>(response);
        }

        /// <summary>
        /// Test RegisterBuyOrder
        /// </summary>
        [Fact]
        public void RegisterBuyOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RegisterBuyOrderModel registerBuyOrderModel = null;
            //var response = instance.RegisterBuyOrder(registerBuyOrderModel);
            //Assert.IsType<OfferDto>(response);
        }

        /// <summary>
        /// Test RegisterSellOffer
        /// </summary>
        [Fact]
        public void RegisterSellOfferTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RegisterSellOfferModel registerSellOfferModel = null;
            //var response = instance.RegisterSellOffer(registerSellOfferModel);
            //Assert.IsType<OfferDto>(response);
        }

        /// <summary>
        /// Test SellOfferDetails
        /// </summary>
        [Fact]
        public void SellOfferDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SellOfferDetailsModel sellOfferDetailsModel = null;
            //var response = instance.SellOfferDetails(sellOfferDetailsModel);
            //Assert.IsType<OrderDetailsDto>(response);
        }
    }
}