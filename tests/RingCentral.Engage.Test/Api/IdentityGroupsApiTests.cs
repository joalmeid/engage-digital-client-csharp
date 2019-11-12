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
    ///  Class for testing IdentityGroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class IdentityGroupsApiTests
    {
        private IdentityGroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IdentityGroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IdentityGroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IdentityGroupsApi
            //Assert.IsInstanceOfType(typeof(IdentityGroupsApi), instance, "instance is a IdentityGroupsApi");
        }

        /// <summary>
        /// Test GetAllIdentityGroups
        /// </summary>
        [Test]
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
            //Assert.IsInstanceOf<GetAllIdentityGroupsResponse> (response, "response is GetAllIdentityGroupsResponse");
        }
        /// <summary>
        /// Test GetIdentityGroup
        /// </summary>
        [Test]
        public void GetIdentityGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identityGroupId = null;
            //var response = instance.GetIdentityGroup(identityGroupId);
            //Assert.IsInstanceOf<IdentityGroup> (response, "response is IdentityGroup");
        }
        /// <summary>
        /// Test UpdateIdentityGroup
        /// </summary>
        [Test]
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
            //Assert.IsInstanceOf<IdentityGroup> (response, "response is IdentityGroup");
        }
    }

}
