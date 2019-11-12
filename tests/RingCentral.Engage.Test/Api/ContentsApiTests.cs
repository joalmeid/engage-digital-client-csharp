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
    ///  Class for testing ContentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContentsApiTests
    {
        private ContentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ContentsApi
            //Assert.IsInstanceOfType(typeof(ContentsApi), instance, "instance is a ContentsApi");
        }

        /// <summary>
        /// Test CategorizeContent
        /// </summary>
        [Test]
        public void CategorizeContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentId = null;
            //List<string> categoryIds = null;
            //var response = instance.CategorizeContent(contentId, categoryIds);
            //Assert.IsInstanceOf<Content> (response, "response is Content");
        }
        /// <summary>
        /// Test CreateContent
        /// </summary>
        [Test]
        public void CreateContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //string authorId = null;
            //string inReplyToId = null;
            //int? _private = null;
            //string sourceId = null;
            //List<string> attachmentIds = null;
            //string title = null;
            //List<string> to = null;
            //List<string> cc = null;
            //List<string> bcc = null;
            //var response = instance.CreateContent(body, authorId, inReplyToId, _private, sourceId, attachmentIds, title, to, cc, bcc);
            //Assert.IsInstanceOf<Content> (response, "response is Content");
        }
        /// <summary>
        /// Test GetAllContents
        /// </summary>
        [Test]
        public void GetAllContentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllContents(q, offset, limit);
            //Assert.IsInstanceOf<GetAllContentsResponse> (response, "response is GetAllContentsResponse");
        }
        /// <summary>
        /// Test GetContent
        /// </summary>
        [Test]
        public void GetContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentId = null;
            //var response = instance.GetContent(contentId);
            //Assert.IsInstanceOf<Content> (response, "response is Content");
        }
        /// <summary>
        /// Test IgnoreContent
        /// </summary>
        [Test]
        public void IgnoreContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentId = null;
            //var response = instance.IgnoreContent(contentId);
            //Assert.IsInstanceOf<Content> (response, "response is Content");
        }
    }

}
