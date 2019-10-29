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

using Engage.Digital.Client;
using Engage.Digital.Client.Api;
using Engage.Digital.Model;

namespace Engage.Digital.Api.Test
{
    /// <summary>
    ///  Class for testing IdentityGroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IdentityGroupsApiTests : IDisposable
    {
        private IdentityGroupsApi instance;

        public IdentityGroupsApiTests()
        {
            instance = new IdentityGroupsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdentityGroupsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IdentityGroupsApi
            //Assert.IsType(typeof(IdentityGroupsApi), instance, "instance is a IdentityGroupsApi");
        }

        
        /// <summary>
        /// Test GetAllIdentityGroups
        /// </summary>
        [Fact]
        public void GetAllIdentityGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string firstname = null;
            //string lastname = null;
            //string email = null;
            //string uuid = null;
            //string sort = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllIdentityGroups(firstname, lastname, email, uuid, sort, offset, limit);
            //Assert.IsType<GetAllIdentityGroupsResponse> (response, "response is GetAllIdentityGroupsResponse");
        }
        
        /// <summary>
        /// Test GetIdentityGroup
        /// </summary>
        [Fact]
        public void GetIdentityGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identityGroupId = null;
            //var response = instance.GetIdentityGroup(identityGroupId);
            //Assert.IsType<IdentityGroup> (response, "response is IdentityGroup");
        }
        
        /// <summary>
        /// Test UpdateIdentityGroup
        /// </summary>
        [Fact]
        public void UpdateIdentityGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identityGroupId = null;
            //string company = null;
            //string customFieldValuesCustomFieldKey = null;
            //List<string> emails = null;
            //string firstname = null;
            //string gender = null;
            //List<string> homePhones = null;
            //string lastname = null;
            //List<string> mobilePhones = null;
            //string notes = null;
            //List<string> tagIds = null;
            //var response = instance.UpdateIdentityGroup(identityGroupId, company, customFieldValuesCustomFieldKey, emails, firstname, gender, homePhones, lastname, mobilePhones, notes, tagIds);
            //Assert.IsType<IdentityGroup> (response, "response is IdentityGroup");
        }
        
    }

}