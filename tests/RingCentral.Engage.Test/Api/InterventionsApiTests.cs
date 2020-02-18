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
    ///  Class for testing InterventionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InterventionsApiTests
    {
        private InterventionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InterventionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InterventionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InterventionsApi
            //Assert.IsInstanceOfType(typeof(InterventionsApi), instance, "instance is a InterventionsApi");
        }

        /// <summary>
        /// Test CancelIntervention
        /// </summary>
        [Test]
        public void CancelInterventionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string interventionId = null;
            //var response = instance.CancelIntervention(interventionId);
            //Assert.IsInstanceOf<Intervention> (response, "response is Intervention");
        }
        /// <summary>
        /// Test CategorizeIntervention
        /// </summary>
        [Test]
        public void CategorizeInterventionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string interventionId = null;
            //List<string> categoryIds = null;
            //var response = instance.CategorizeIntervention(interventionId, categoryIds);
            //Assert.IsInstanceOf<Intervention> (response, "response is Intervention");
        }
        /// <summary>
        /// Test CloseIntervention
        /// </summary>
        [Test]
        public void CloseInterventionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string interventionId = null;
            //var response = instance.CloseIntervention(interventionId);
            //Assert.IsInstanceOf<Intervention> (response, "response is Intervention");
        }
        /// <summary>
        /// Test CreateIntervention
        /// </summary>
        [Test]
        public void CreateInterventionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentId = null;
            //var response = instance.CreateIntervention(contentId);
            //Assert.IsInstanceOf<GetAllInterventionsResponse> (response, "response is GetAllInterventionsResponse");
        }
        /// <summary>
        /// Test GetAllInterventions
        /// </summary>
        [Test]
        public void GetAllInterventionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string threadId = null;
            //string userId = null;
            //string identityGroupId = null;
            //List<string> identityId = null;
            //string sort = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllInterventions(threadId, userId, identityGroupId, identityId, sort, offset, limit);
            //Assert.IsInstanceOf<GetAllInterventionsResponse> (response, "response is GetAllInterventionsResponse");
        }
        /// <summary>
        /// Test GetIntervention
        /// </summary>
        [Test]
        public void GetInterventionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string interventionId = null;
            //var response = instance.GetIntervention(interventionId);
            //Assert.IsInstanceOf<Intervention> (response, "response is Intervention");
        }
        /// <summary>
        /// Test ReassignIntervention
        /// </summary>
        [Test]
        public void ReassignInterventionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string interventionId = null;
            //string userId = null;
            //var response = instance.ReassignIntervention(interventionId, userId);
            //Assert.IsInstanceOf<Intervention> (response, "response is Intervention");
        }
    }

}