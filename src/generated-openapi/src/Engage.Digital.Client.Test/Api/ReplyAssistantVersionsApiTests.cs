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
    ///  Class for testing ReplyAssistantVersionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReplyAssistantVersionsApiTests : IDisposable
    {
        private ReplyAssistantVersionsApi instance;

        public ReplyAssistantVersionsApiTests()
        {
            instance = new ReplyAssistantVersionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReplyAssistantVersionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReplyAssistantVersionsApi
            //Assert.IsType(typeof(ReplyAssistantVersionsApi), instance, "instance is a ReplyAssistantVersionsApi");
        }

        
        /// <summary>
        /// Test CreateReplyAssistantVersion
        /// </summary>
        [Fact]
        public void CreateReplyAssistantVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //string entryId = null;
            //List<string> sourceIds = null;
            //string format = null;
            //string language = null;
            //var response = instance.CreateReplyAssistantVersion(body, entryId, sourceIds, format, language);
            //Assert.IsType<ReplyAssistantVersion> (response, "response is ReplyAssistantVersion");
        }
        
        /// <summary>
        /// Test DeleteReplyAssistantVersion
        /// </summary>
        [Fact]
        public void DeleteReplyAssistantVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string replyAssistantVersionId = null;
            //var response = instance.DeleteReplyAssistantVersion(replyAssistantVersionId);
            //Assert.IsType<ReplyAssistantVersion> (response, "response is ReplyAssistantVersion");
        }
        
        /// <summary>
        /// Test GetAllReplyAssistantVersions
        /// </summary>
        [Fact]
        public void GetAllReplyAssistantVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllReplyAssistantVersions(offset, limit);
            //Assert.IsType<GetAllReplyAssistantVersionsResponse> (response, "response is GetAllReplyAssistantVersionsResponse");
        }
        
        /// <summary>
        /// Test GetReplyAssistantVersion
        /// </summary>
        [Fact]
        public void GetReplyAssistantVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string replyAssistantVersionId = null;
            //var response = instance.GetReplyAssistantVersion(replyAssistantVersionId);
            //Assert.IsType<ReplyAssistantVersion> (response, "response is ReplyAssistantVersion");
        }
        
        /// <summary>
        /// Test UpdateReplyAssistantVersion
        /// </summary>
        [Fact]
        public void UpdateReplyAssistantVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string replyAssistantVersionId = null;
            //string body = null;
            //string entryId = null;
            //List<string> sourceIds = null;
            //string format = null;
            //string language = null;
            //var response = instance.UpdateReplyAssistantVersion(replyAssistantVersionId, body, entryId, sourceIds, format, language);
            //Assert.IsType<ReplyAssistantVersion> (response, "response is ReplyAssistantVersion");
        }
        
    }

}