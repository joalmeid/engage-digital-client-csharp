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
    ///  Class for testing CommunitiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CommunitiesApiTests
    {
        private CommunitiesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CommunitiesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CommunitiesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CommunitiesApi
            //Assert.IsInstanceOfType(typeof(CommunitiesApi), instance, "instance is a CommunitiesApi");
        }

        /// <summary>
        /// Test GetAllCommunities
        /// </summary>
        [Test]
        public void GetAllCommunitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllCommunities(offset, limit);
            //Assert.IsInstanceOf<GetAllCommunitiesResponse> (response, "response is GetAllCommunitiesResponse");
        }
        /// <summary>
        /// Test GetCommunity
        /// </summary>
        [Test]
        public void GetCommunityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string communityId = null;
            //var response = instance.GetCommunity(communityId);
            //Assert.IsInstanceOf<Community> (response, "response is Community");
        }
    }

}
