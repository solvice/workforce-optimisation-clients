/* 
 * Workforce Optimisation API
 *
 * Solver engine for solving workforce optimisation problems
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@solvice.io
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

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ShiftApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ShiftApiTests
    {
        private ShiftApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ShiftApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ShiftApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ShiftApi
            //Assert.IsInstanceOfType(typeof(ShiftApi), instance, "instance is a ShiftApi");
        }

        /// <summary>
        /// Test GetSolution
        /// </summary>
        [Test]
        public void GetSolutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? jobId = null;
            //var response = instance.GetSolution(jobId);
            //Assert.IsInstanceOf<ShiftSolution> (response, "response is ShiftSolution");
        }
        /// <summary>
        /// Test GetStatus
        /// </summary>
        [Test]
        public void GetStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? jobId = null;
            //var response = instance.GetStatus(jobId);
            //Assert.IsInstanceOf<StatusJob> (response, "response is StatusJob");
        }
        /// <summary>
        /// Test SolveShiftProblem
        /// </summary>
        [Test]
        public void SolveShiftProblemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ShiftRequest body = null;
            //int? seconds = null;
            //var response = instance.SolveShiftProblem(body, seconds);
            //Assert.IsInstanceOf<StatusJob> (response, "response is StatusJob");
        }
    }

}
