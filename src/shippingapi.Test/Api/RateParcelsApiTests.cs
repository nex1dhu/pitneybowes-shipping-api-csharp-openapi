/* 
 * Shipping API
 *
 * Shipping API Sample.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@pb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using shippingapi.Client;
using shippingapi.Api;
using shippingapi.Model;

namespace shippingapi.Test
{
    /// <summary>
    ///  Class for testing RateParcelsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RateParcelsApiTests
    {
        private RateParcelsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RateParcelsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RateParcelsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' RateParcelsApi
            //Assert.IsInstanceOf(typeof(RateParcelsApi), instance);
        }

        
        /// <summary>
        /// Test RateParcel
        /// </summary>
        [Test]
        public void RateParcelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Shipment shipment = null;
            //bool? xPBUnifiedErrorStructure = null;
            //string xPBShipperRatePlan = null;
            //string xPBIntegratorCarrierId = null;
            //string xPBShipperCarrierAccountId = null;
            //bool? includeDeliveryCommitment = null;
            //string carrier = null;
            //var response = instance.RateParcel(shipment, xPBUnifiedErrorStructure, xPBShipperRatePlan, xPBIntegratorCarrierId, xPBShipperCarrierAccountId, includeDeliveryCommitment, carrier);
            //Assert.IsInstanceOf(typeof(Shipment), response, "response is Shipment");
        }
        
    }

}
