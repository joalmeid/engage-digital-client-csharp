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
    ///  Class for testing TasksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TasksApiTests : IDisposable
    {
        private TasksApi instance;

        public TasksApiTests()
        {
            instance = new TasksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TasksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TasksApi
            //Assert.IsType(typeof(TasksApi), instance, "instance is a TasksApi");
        }

        
        /// <summary>
        /// Test GetAllTasks
        /// </summary>
        [Fact]
        public void GetAllTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string queue = null;
            //string channelId = null;
            //string step = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllTasks(queue, channelId, step, offset, limit);
            //Assert.IsType<GetAllTasksResponse> (response, "response is GetAllTasksResponse");
        }
        
        /// <summary>
        /// Test GetTask
        /// </summary>
        [Fact]
        public void GetTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //var response = instance.GetTask(taskId);
            //Assert.IsType<Task> (response, "response is Task");
        }
        
        /// <summary>
        /// Test MoveTask
        /// </summary>
        [Fact]
        public void MoveTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //string queue = null;
            //var response = instance.MoveTask(taskId, queue);
            //Assert.IsType<Task> (response, "response is Task");
        }
        
        /// <summary>
        /// Test TransferTask
        /// </summary>
        [Fact]
        public void TransferTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //List<string> agentIds = null;
            //string bypass = null;
            //List<string> categoryIds = null;
            //string language = null;
            //List<string> teamIds = null;
            //string comment = null;
            //var response = instance.TransferTask(taskId, agentIds, bypass, categoryIds, language, teamIds, comment);
            //Assert.IsType<Task> (response, "response is Task");
        }
        
    }

}