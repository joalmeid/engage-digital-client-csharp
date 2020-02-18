/* 
 * Engage Digital API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using RingCentral.Engage.Client;
using RingCentral.Engage.Api;
using RingCentral.Engage.Model;

namespace RingCentral.Engage.Test
{
    /// <summary>
    ///  Class for testing SourcesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SourcesApiTests
    {
        private SourcesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SourcesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SourcesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SourcesApi
            //Assert.IsInstanceOfType(typeof(SourcesApi), instance, "instance is a SourcesApi");
        }

        /// <summary>
        /// Test GetAllSources
        /// </summary>
        [Test]
        public void GetAllSourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllSources(offset, limit);
            //Assert.IsInstanceOf<GetAllSourcesResponse> (response, "response is GetAllSourcesResponse");
        }
        /// <summary>
        /// Test GetSource
        /// </summary>
        [Test]
        public void GetSourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sourceId = null;
            //var response = instance.GetSource(sourceId);
            //Assert.IsInstanceOf<Source> (response, "response is Source");
        }
        /// <summary>
        /// Test UpdateSource
        /// </summary>
        [Test]
        public void UpdateSourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sourceId = null;
            //string name = null;
            //bool? active = null;
            //string channelId = null;
            //int? color = null;
            //int? slaResponse = null;
            //string slaExpiredStrategy = null;
            //int? interventionMessagesBoost = null;
            //int? transferredTasksBoost = null;
            //bool? hiddenFromStats = null;
            //List<string> defaultCategoryIds = null;
            //List<string> userThreadDefaultCategoryIds = null;
            //string defaultContentLanguage = null;
            //bool? autoDetectContentLanguage = null;
            //bool? contentArchiving = null;
            //int? contentArchivingPeriod = null;
            //var response = instance.UpdateSource(sourceId, name, active, channelId, color, slaResponse, slaExpiredStrategy, interventionMessagesBoost, transferredTasksBoost, hiddenFromStats, defaultCategoryIds, userThreadDefaultCategoryIds, defaultContentLanguage, autoDetectContentLanguage, contentArchiving, contentArchivingPeriod);
            //Assert.IsInstanceOf<Source> (response, "response is Source");
        }
    }

}