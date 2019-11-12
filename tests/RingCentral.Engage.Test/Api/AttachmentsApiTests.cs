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
    ///  Class for testing AttachmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AttachmentsApiTests
    {
        private AttachmentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AttachmentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AttachmentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AttachmentsApi
            //Assert.IsInstanceOfType(typeof(AttachmentsApi), instance, "instance is a AttachmentsApi");
        }

        /// <summary>
        /// Test CreateAttachment
        /// </summary>
        [Test]
        public void CreateAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body body = null;
            //var response = instance.CreateAttachment(body);
            //Assert.IsInstanceOf<Attachment> (response, "response is Attachment");
        }
        /// <summary>
        /// Test GetAllAttachments
        /// </summary>
        [Test]
        public void GetAllAttachmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllAttachments(offset, limit);
            //Assert.IsInstanceOf<GetAllAttachmentsResponse> (response, "response is GetAllAttachmentsResponse");
        }
        /// <summary>
        /// Test GetAttachment
        /// </summary>
        [Test]
        public void GetAttachmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string attachmentId = null;
            //var response = instance.GetAttachment(attachmentId);
            //Assert.IsInstanceOf<Attachment> (response, "response is Attachment");
        }
    }

}
