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
    ///  Class for testing AgentStatusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AgentStatusApiTests
    {
        private AgentStatusApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AgentStatusApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AgentStatusApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AgentStatusApi
            //Assert.IsInstanceOfType(typeof(AgentStatusApi), instance, "instance is a AgentStatusApi");
        }

        /// <summary>
        /// Test ChangeAgentStatus
        /// </summary>
        [Test]
        public void ChangeAgentStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentId = null;
            //string status = null;
            //string customStatusId = null;
            //var response = instance.ChangeAgentStatus(agentId, status, customStatusId);
            //Assert.IsInstanceOf<AgentStatus> (response, "response is AgentStatus");
        }
        /// <summary>
        /// Test GetAgentStatus
        /// </summary>
        [Test]
        public void GetAgentStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string agentId = null;
            //var response = instance.GetAgentStatus(agentId);
            //Assert.IsInstanceOf<AgentStatus> (response, "response is AgentStatus");
        }
        /// <summary>
        /// Test GetAllAgentStatus
        /// </summary>
        [Test]
        public void GetAllAgentStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllAgentStatus();
            //Assert.IsInstanceOf<List<AgentStatus>> (response, "response is List<AgentStatus>");
        }
    }

}