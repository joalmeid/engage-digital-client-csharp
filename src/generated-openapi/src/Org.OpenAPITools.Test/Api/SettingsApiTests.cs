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

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing SettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SettingsApiTests : IDisposable
    {
        private SettingsApi instance;

        public SettingsApiTests()
        {
            instance = new SettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SettingsApi
            //Assert.IsType(typeof(SettingsApi), instance, "instance is a SettingsApi");
        }

        
        /// <summary>
        /// Test GetAllSettings
        /// </summary>
        [Fact]
        public void GetAllSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllSettings();
            //Assert.IsType<Settings> (response, "response is Settings");
        }
        
        /// <summary>
        /// Test UpdateSettings
        /// </summary>
        [Fact]
        public void UpdateSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? activityPresenceThreshold = null;
            //bool? activityTracking = null;
            //string beginningOfWeek = null;
            //bool? categoryTagging = null;
            //string contentLanguages = null;
            //bool? dashboard = null;
            //bool? denyIframeIntegration = null;
            //bool? disablePasswordAutocomplete = null;
            //int? expirePasswordAfter = null;
            //bool? expirePasswordEnabled = null;
            //bool? exportInSeconds = null;
            //bool? foldUselessContents = null;
            //int? fteDuration = null;
            //bool? identityMerge = null;
            //List<int> interventionDeferRates = null;
            //int? interventionDeferThreshold = null;
            //List<int> interventionRates = null;
            //string locale = null;
            //bool? multiLang = null;
            //string name = null;
            //bool? passwordArchivableEnabled = null;
            //int? passwordArchivableSize = null;
            //int? passwordMinLength = null;
            //bool? passwordNonWord = null;
            //bool? passwordNumbers = null;
            //bool? passwordRecoveryDisabled = null;
            //bool? pushEnabled = null;
            //bool? replyAsAnyIdentity = null;
            //bool? rtlSupport = null;
            //bool? selfApprovalRequired = null;
            //int? sessionTimeout = null;
            //bool? spellchecking = null;
            //string style = null;
            //bool? thirdPartyServicesDisabled = null;
            //string timezone = null;
            //bool? trackJs = null;
            //string type = null;
            //int? urgentTaskThreshold = null;
            //bool? useSystemFont = null;
            //var response = instance.UpdateSettings(activityPresenceThreshold, activityTracking, beginningOfWeek, categoryTagging, contentLanguages, dashboard, denyIframeIntegration, disablePasswordAutocomplete, expirePasswordAfter, expirePasswordEnabled, exportInSeconds, foldUselessContents, fteDuration, identityMerge, interventionDeferRates, interventionDeferThreshold, interventionRates, locale, multiLang, name, passwordArchivableEnabled, passwordArchivableSize, passwordMinLength, passwordNonWord, passwordNumbers, passwordRecoveryDisabled, pushEnabled, replyAsAnyIdentity, rtlSupport, selfApprovalRequired, sessionTimeout, spellchecking, style, thirdPartyServicesDisabled, timezone, trackJs, type, urgentTaskThreshold, useSystemFont);
            //Assert.IsType<Settings> (response, "response is Settings");
        }
        
    }

}