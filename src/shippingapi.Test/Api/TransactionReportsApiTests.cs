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
    ///  Class for testing TransactionReportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TransactionReportsApiTests
    {
        private TransactionReportsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransactionReportsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransactionReportsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TransactionReportsApi
            //Assert.IsInstanceOf(typeof(TransactionReportsApi), instance);
        }

        
        /// <summary>
        /// Test GetTransactionReport
        /// </summary>
        [Test]
        public void GetTransactionReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string developerId = null;
            //bool? xPBUnifiedErrorStructure = null;
            //DateTime? fromDate = null;
            //int? shipDetails = null;
            //int? page = null;
            //int? size = null;
            //string printStatus = null;
            //DateTime? toDate = null;
            //string transactionType = null;
            //string merchantId = null;
            //string sort = null;
            //string parcelTrackingNumber = null;
            //string transactionId = null;
            //var response = instance.GetTransactionReport(developerId, xPBUnifiedErrorStructure, fromDate, shipDetails, page, size, printStatus, toDate, transactionType, merchantId, sort, parcelTrackingNumber, transactionId);
            //Assert.IsInstanceOf(typeof(PageRealTransactionDetailReport), response, "response is PageRealTransactionDetailReport");
        }
        
    }

}
