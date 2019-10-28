/* 
 * Engage Digital API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
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

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing IdentitiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IdentitiesApiTests : IDisposable
    {
        private IdentitiesApi instance;

        public IdentitiesApiTests()
        {
            instance = new IdentitiesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdentitiesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IdentitiesApi
            //Assert.IsType(typeof(IdentitiesApi), instance, "instance is a IdentitiesApi");
        }

        
        /// <summary>
        /// Test GetAllIdentities
        /// </summary>
        [Fact]
        public void GetAllIdentitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string communityId = null;
            //string identityGroupId = null;
            //string userId = null;
            //string sort = null;
            //string foreignId = null;
            //string uuid = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllIdentities(communityId, identityGroupId, userId, sort, foreignId, uuid, offset, limit);
            //Assert.IsType<GetAllIdentitiesResponse> (response, "response is GetAllIdentitiesResponse");
        }
        
        /// <summary>
        /// Test GetIdentity
        /// </summary>
        [Fact]
        public void GetIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identityId = null;
            //var response = instance.GetIdentity(identityId);
            //Assert.IsType<Identity> (response, "response is Identity");
        }
        
    }

}
