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
    ///  Class for testing RolesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RolesApiTests
    {
        private RolesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RolesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RolesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RolesApi
            //Assert.IsInstanceOfType(typeof(RolesApi), instance, "instance is a RolesApi");
        }

        /// <summary>
        /// Test CreateRole
        /// </summary>
        [Test]
        public void CreateRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string label = null;
            //bool? accessHelpCenter = null;
            //bool? accessPreviousMessages = null;
            //bool? accessPullMode = null;
            //bool? adminStampAnswer = null;
            //bool? approveContent = null;
            //bool? assignIntervention = null;
            //bool? authorBlockContent = null;
            //bool? closeContentThread = null;
            //bool? createAndDestroyExtension = null;
            //bool? createCommunity = null;
            //bool? createContentSource = null;
            //bool? createUser = null;
            //bool? delayExportContent = null;
            //bool? deleteContentThread = null;
            //bool? impersonateUser = null;
            //bool? inviteUser = null;
            //bool? manageApiAccessTokens = null;
            //bool? manageAppSdkApplications = null;
            //bool? manageAutomaticExportsTasks = null;
            //bool? manageCategories = null;
            //bool? manageChat = null;
            //bool? manageCustomFields = null;
            //bool? manageCustomNotifications = null;
            //bool? manageEmailsTemplates = null;
            //bool? manageFolders = null;
            //bool? manageIce = null;
            //bool? manageIdentities = null;
            //bool? manageOwnNotifications = null;
            //bool? manageReplyAssistant = null;
            //bool? manageRoles = null;
            //bool? manageRulesEngineRules = null;
            //bool? manageSurveys = null;
            //bool? manageTags = null;
            //bool? manageTeams = null;
            //bool? manageTopologies = null;
            //bool? manageUsersOfMyTeams = null;
            //bool? monitorTasks = null;
            //bool? monitorTeamTasks = null;
            //bool? muteContent = null;
            //bool? openContentThread = null;
            //bool? publishContent = null;
            //bool? readCommunity = null;
            //bool? readContentSource = null;
            //bool? readEvent = null;
            //bool? readExport = null;
            //bool? readIdentity = null;
            //bool? readOwnStats = null;
            //bool? readPresence = null;
            //bool? readStats = null;
            //bool? readSurveys = null;
            //bool? readUser = null;
            //bool? receiveTasks = null;
            //bool? replyWithAssistant = null;
            //bool? searchContents = null;
            //bool? searchEvent = null;
            //bool? updateCommunity = null;
            //bool? updateContentSource = null;
            //bool? updateExtension = null;
            //bool? updateIdentity = null;
            //bool? updateIntervention = null;
            //bool? updateOwnIntervention = null;
            //bool? updateSettings = null;
            //bool? updateTimeSheet = null;
            //bool? updateUser = null;
            //bool? useEmoji = null;
            //var response = instance.CreateRole(label, accessHelpCenter, accessPreviousMessages, accessPullMode, adminStampAnswer, approveContent, assignIntervention, authorBlockContent, closeContentThread, createAndDestroyExtension, createCommunity, createContentSource, createUser, delayExportContent, deleteContentThread, impersonateUser, inviteUser, manageApiAccessTokens, manageAppSdkApplications, manageAutomaticExportsTasks, manageCategories, manageChat, manageCustomFields, manageCustomNotifications, manageEmailsTemplates, manageFolders, manageIce, manageIdentities, manageOwnNotifications, manageReplyAssistant, manageRoles, manageRulesEngineRules, manageSurveys, manageTags, manageTeams, manageTopologies, manageUsersOfMyTeams, monitorTasks, monitorTeamTasks, muteContent, openContentThread, publishContent, readCommunity, readContentSource, readEvent, readExport, readIdentity, readOwnStats, readPresence, readStats, readSurveys, readUser, receiveTasks, replyWithAssistant, searchContents, searchEvent, updateCommunity, updateContentSource, updateExtension, updateIdentity, updateIntervention, updateOwnIntervention, updateSettings, updateTimeSheet, updateUser, useEmoji);
            //Assert.IsInstanceOf<Role> (response, "response is Role");
        }
        /// <summary>
        /// Test GetAllRoles
        /// </summary>
        [Test]
        public void GetAllRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllRoles(offset, limit);
            //Assert.IsInstanceOf<GetAllRolesResponse> (response, "response is GetAllRolesResponse");
        }
        /// <summary>
        /// Test GetRole
        /// </summary>
        [Test]
        public void GetRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //var response = instance.GetRole(roleId);
            //Assert.IsInstanceOf<Role> (response, "response is Role");
        }
        /// <summary>
        /// Test UpdateRole
        /// </summary>
        [Test]
        public void UpdateRoleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string roleId = null;
            //bool? accessHelpCenter = null;
            //bool? accessPreviousMessages = null;
            //bool? accessPullMode = null;
            //bool? adminStampAnswer = null;
            //bool? approveContent = null;
            //bool? assignIntervention = null;
            //bool? authorBlockContent = null;
            //bool? closeContentThread = null;
            //bool? createAndDestroyExtension = null;
            //bool? createCommunity = null;
            //bool? createContentSource = null;
            //bool? createUser = null;
            //bool? delayExportContent = null;
            //bool? deleteContentThread = null;
            //bool? impersonateUser = null;
            //bool? inviteUser = null;
            //bool? manageApiAccessTokens = null;
            //bool? manageAppSdkApplications = null;
            //bool? manageAutomaticExportsTasks = null;
            //bool? manageCategories = null;
            //bool? manageChat = null;
            //bool? manageCustomFields = null;
            //bool? manageCustomNotifications = null;
            //bool? manageEmailsTemplates = null;
            //bool? manageFolders = null;
            //bool? manageIce = null;
            //bool? manageIdentities = null;
            //bool? manageOwnNotifications = null;
            //bool? manageReplyAssistant = null;
            //bool? manageRoles = null;
            //bool? manageRulesEngineRules = null;
            //bool? manageSurveys = null;
            //bool? manageTags = null;
            //bool? manageTeams = null;
            //bool? manageTopologies = null;
            //bool? manageUsersOfMyTeams = null;
            //bool? monitorTasks = null;
            //bool? monitorTeamTasks = null;
            //bool? muteContent = null;
            //bool? openContentThread = null;
            //bool? publishContent = null;
            //bool? readCommunity = null;
            //bool? readContentSource = null;
            //bool? readEvent = null;
            //bool? readExport = null;
            //bool? readIdentity = null;
            //bool? readOwnStats = null;
            //bool? readPresence = null;
            //bool? readStats = null;
            //bool? readSurveys = null;
            //bool? readUser = null;
            //bool? receiveTasks = null;
            //bool? replyWithAssistant = null;
            //bool? searchContents = null;
            //bool? searchEvent = null;
            //bool? updateCommunity = null;
            //bool? updateContentSource = null;
            //bool? updateExtension = null;
            //bool? updateIdentity = null;
            //bool? updateIntervention = null;
            //bool? updateOwnIntervention = null;
            //bool? updateSettings = null;
            //bool? updateTimeSheet = null;
            //bool? updateUser = null;
            //bool? useEmoji = null;
            //var response = instance.UpdateRole(roleId, accessHelpCenter, accessPreviousMessages, accessPullMode, adminStampAnswer, approveContent, assignIntervention, authorBlockContent, closeContentThread, createAndDestroyExtension, createCommunity, createContentSource, createUser, delayExportContent, deleteContentThread, impersonateUser, inviteUser, manageApiAccessTokens, manageAppSdkApplications, manageAutomaticExportsTasks, manageCategories, manageChat, manageCustomFields, manageCustomNotifications, manageEmailsTemplates, manageFolders, manageIce, manageIdentities, manageOwnNotifications, manageReplyAssistant, manageRoles, manageRulesEngineRules, manageSurveys, manageTags, manageTeams, manageTopologies, manageUsersOfMyTeams, monitorTasks, monitorTeamTasks, muteContent, openContentThread, publishContent, readCommunity, readContentSource, readEvent, readExport, readIdentity, readOwnStats, readPresence, readStats, readSurveys, readUser, receiveTasks, replyWithAssistant, searchContents, searchEvent, updateCommunity, updateContentSource, updateExtension, updateIdentity, updateIntervention, updateOwnIntervention, updateSettings, updateTimeSheet, updateUser, useEmoji);
            //Assert.IsInstanceOf<Role> (response, "response is Role");
        }
    }

}
