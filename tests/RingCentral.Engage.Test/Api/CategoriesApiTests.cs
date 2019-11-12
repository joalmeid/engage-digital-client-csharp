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
    ///  Class for testing CategoriesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CategoriesApiTests
    {
        private CategoriesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CategoriesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CategoriesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CategoriesApi
            //Assert.IsInstanceOfType(typeof(CategoriesApi), instance, "instance is a CategoriesApi");
        }

        /// <summary>
        /// Test CreateCategory
        /// </summary>
        [Test]
        public void CreateCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string parentId = null;
            //int? color = null;
            //bool? mandatory = null;
            //bool? multiple = null;
            //bool? postQualification = null;
            //bool? unselectable = null;
            //List<string> sourceIds = null;
            //var response = instance.CreateCategory(name, parentId, color, mandatory, multiple, postQualification, unselectable, sourceIds);
            //Assert.IsInstanceOf<Category> (response, "response is Category");
        }
        /// <summary>
        /// Test DeleteCategory
        /// </summary>
        [Test]
        public void DeleteCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryId = null;
            //string takeOverCategoryId = null;
            //var response = instance.DeleteCategory(categoryId, takeOverCategoryId);
            //Assert.IsInstanceOf<Category> (response, "response is Category");
        }
        /// <summary>
        /// Test GetAllCategories
        /// </summary>
        [Test]
        public void GetAllCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parentId = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetAllCategories(parentId, offset, limit);
            //Assert.IsInstanceOf<GetAllCategoriesResponse> (response, "response is GetAllCategoriesResponse");
        }
        /// <summary>
        /// Test GetCategory
        /// </summary>
        [Test]
        public void GetCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryId = null;
            //var response = instance.GetCategory(categoryId);
            //Assert.IsInstanceOf<Category> (response, "response is Category");
        }
        /// <summary>
        /// Test UpdateCategory
        /// </summary>
        [Test]
        public void UpdateCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryId = null;
            //string name = null;
            //string parentId = null;
            //int? color = null;
            //bool? mandatory = null;
            //bool? multiple = null;
            //bool? postQualification = null;
            //bool? unselectable = null;
            //List<string> sourceIds = null;
            //var response = instance.UpdateCategory(categoryId, name, parentId, color, mandatory, multiple, postQualification, unselectable, sourceIds);
            //Assert.IsInstanceOf<Category> (response, "response is Category");
        }
    }

}
