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
    ///  Class for testing TimeSheetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TimeSheetsApiTests
    {
        private TimeSheetsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TimeSheetsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TimeSheetsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TimeSheetsApi
            //Assert.IsInstanceOfType(typeof(TimeSheetsApi), instance, "instance is a TimeSheetsApi");
        }

        /// <summary>
        /// Test CreateTimeSheet
        /// </summary>
        [Test]
        public void CreateTimeSheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string label = null;
            //bool? active = null;
            //List<string> sourceIds = null;
            //string holidaysRegion = null;
            //string holidays = null;
            //string mondayHours = null;
            //string tuesdayHours = null;
            //string wednesdayHours = null;
            //string thursdayHours = null;
            //string fridayHours = null;
            //string saturdayHours = null;
            //string sundayHours = null;
            //var response = instance.CreateTimeSheet(label, active, sourceIds, holidaysRegion, holidays, mondayHours, tuesdayHours, wednesdayHours, thursdayHours, fridayHours, saturdayHours, sundayHours);
            //Assert.IsInstanceOf<TimeSheet> (response, "response is TimeSheet");
        }
        /// <summary>
        /// Test DeleteTimeSheet
        /// </summary>
        [Test]
        public void DeleteTimeSheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timeSheetId = null;
            //var response = instance.DeleteTimeSheet(timeSheetId);
            //Assert.IsInstanceOf<TimeSheet> (response, "response is TimeSheet");
        }
        /// <summary>
        /// Test GetAllTimeSheets
        /// </summary>
        [Test]
        public void GetAllTimeSheetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllTimeSheets(offset, limit);
            //Assert.IsInstanceOf<GetAllTimeSheetsResponse> (response, "response is GetAllTimeSheetsResponse");
        }
        /// <summary>
        /// Test GetTimeSheet
        /// </summary>
        [Test]
        public void GetTimeSheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timeSheetId = null;
            //var response = instance.GetTimeSheet(timeSheetId);
            //Assert.IsInstanceOf<TimeSheet> (response, "response is TimeSheet");
        }
        /// <summary>
        /// Test UpdateTimeSheet
        /// </summary>
        [Test]
        public void UpdateTimeSheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timeSheetId = null;
            //bool? active = null;
            //string label = null;
            //List<string> sourceIds = null;
            //string holidays = null;
            //string mondayHours = null;
            //string tuesdayHours = null;
            //string wednesdayHours = null;
            //string thursdayHours = null;
            //string fridayHours = null;
            //string saturdayHours = null;
            //string sundayHours = null;
            //var response = instance.UpdateTimeSheet(timeSheetId, active, label, sourceIds, holidays, mondayHours, tuesdayHours, wednesdayHours, thursdayHours, fridayHours, saturdayHours, sundayHours);
            //Assert.IsInstanceOf<TimeSheet> (response, "response is TimeSheet");
        }
    }

}
