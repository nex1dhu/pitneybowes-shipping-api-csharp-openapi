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
    ///  Class for testing ShipmentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ShipmentApiTests
    {
        private ShipmentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ShipmentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ShipmentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ShipmentApi
            //Assert.IsInstanceOf(typeof(ShipmentApi), instance);
        }

        
        /// <summary>
        /// Test CancelShipment
        /// </summary>
        [Test]
        public void CancelShipmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xPBTransactionId = null;
            //string shipmentId = null;
            //string xPBUnifiedErrorStructure = null;
            //string xPBShipperCarrierAccountId = null;
            //string cancelInitiator = null;
            //Carrier? carrier = null;
            //var response = instance.CancelShipment(xPBTransactionId, shipmentId, xPBUnifiedErrorStructure, xPBShipperCarrierAccountId, cancelInitiator, carrier);
            //Assert.IsInstanceOf(typeof(CancelShipment), response, "response is CancelShipment");
        }
        
        /// <summary>
        /// Test CreateShipmentLabel
        /// </summary>
        [Test]
        public void CreateShipmentLabelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xPBTransactionId = null;
            //Shipment shipment = null;
            //bool? xPBUnifiedErrorStructure = null;
            //string xPBIntegratorCarrierId = null;
            //string xPBShipperRatePlan = null;
            //string xPBShipmentGroupId = null;
            //string xPBShipperCarrierAccountId = null;
            //string includeDeliveryCommitment = null;
            //var response = instance.CreateShipmentLabel(xPBTransactionId, shipment, xPBUnifiedErrorStructure, xPBIntegratorCarrierId, xPBShipperRatePlan, xPBShipmentGroupId, xPBShipperCarrierAccountId, includeDeliveryCommitment);
            //Assert.IsInstanceOf(typeof(Shipment), response, "response is Shipment");
        }
        
        /// <summary>
        /// Test ReprintShipment
        /// </summary>
        [Test]
        public void ReprintShipmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string shipmentId = null;
            //bool? xPBUnifiedErrorStructure = null;
            //Carrier? carrier = null;
            //var response = instance.ReprintShipment(shipmentId, xPBUnifiedErrorStructure, carrier);
            //Assert.IsInstanceOf(typeof(Shipment), response, "response is Shipment");
        }
        
        /// <summary>
        /// Test RetryShipment
        /// </summary>
        [Test]
        public void RetryShipmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string originalTransactionId = null;
            //bool? xPBUnifiedErrorStructure = null;
            //Carrier? carrier = null;
            //var response = instance.RetryShipment(originalTransactionId, xPBUnifiedErrorStructure, carrier);
            //Assert.IsInstanceOf(typeof(Shipment), response, "response is Shipment");
        }
        
    }

}
