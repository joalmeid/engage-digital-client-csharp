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

using RingCentral.EngageDigital.Client;
using RingCentral.EngageDigital.Api;
using RingCentral.EngageDigital.Model;

namespace RingCentral.EngageDigital.Test
{
    /// <summary>
    ///  Class for testing EventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventsApiTests : IDisposable
    {
        private EventsApi instance;

        public EventsApiTests()
        {
            instance = new EventsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EventsApi
            //Assert.IsType(typeof(EventsApi), instance, "instance is a EventsApi");
        }

        
        /// <summary>
        /// Test GetAllEvents
        /// </summary>
        [Fact]
        public void GetAllEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllEvents(q, offset, limit);
            //Assert.IsType<GetAllEventsResponse> (response, "response is GetAllEventsResponse");
        }
        
        /// <summary>
        /// Test GetEvent
        /// </summary>
        [Fact]
        public void GetEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string eventId = null;
            //var response = instance.GetEvent(eventId);
            //Assert.IsType<Event> (response, "response is Event");
        }
        
    }

}
