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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IShiftApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a solution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>ShiftSolution</returns>
        ShiftSolution GetSolution (long? jobId);

        /// <summary>
        /// Get a solution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of ShiftSolution</returns>
        ApiResponse<ShiftSolution> GetSolutionWithHttpInfo (long? jobId);
        /// <summary>
        /// Get a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>StatusJob</returns>
        StatusJob GetStatus (Guid? jobId);

        /// <summary>
        /// Get a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of StatusJob</returns>
        ApiResponse<StatusJob> GetStatusWithHttpInfo (Guid? jobId);
        /// <summary>
        /// Solve SHIFT problem
        /// </summary>
        /// <remarks>
        /// Endpoint for solving shift optimisation problem. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Optional description in *Markdown*</param>
        /// <param name="seconds">The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. (optional)</param>
        /// <returns>StatusJob</returns>
        StatusJob SolveShiftProblem (ShiftRequest body, int? seconds = null);

        /// <summary>
        /// Solve SHIFT problem
        /// </summary>
        /// <remarks>
        /// Endpoint for solving shift optimisation problem. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Optional description in *Markdown*</param>
        /// <param name="seconds">The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. (optional)</param>
        /// <returns>ApiResponse of StatusJob</returns>
        ApiResponse<StatusJob> SolveShiftProblemWithHttpInfo (ShiftRequest body, int? seconds = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a solution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ShiftSolution</returns>
        System.Threading.Tasks.Task<ShiftSolution> GetSolutionAsync (long? jobId);

        /// <summary>
        /// Get a solution
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (ShiftSolution)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShiftSolution>> GetSolutionAsyncWithHttpInfo (long? jobId);
        /// <summary>
        /// Get a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of StatusJob</returns>
        System.Threading.Tasks.Task<StatusJob> GetStatusAsync (Guid? jobId);

        /// <summary>
        /// Get a status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (StatusJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusJob>> GetStatusAsyncWithHttpInfo (Guid? jobId);
        /// <summary>
        /// Solve SHIFT problem
        /// </summary>
        /// <remarks>
        /// Endpoint for solving shift optimisation problem. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Optional description in *Markdown*</param>
        /// <param name="seconds">The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. (optional)</param>
        /// <returns>Task of StatusJob</returns>
        System.Threading.Tasks.Task<StatusJob> SolveShiftProblemAsync (ShiftRequest body, int? seconds = null);

        /// <summary>
        /// Solve SHIFT problem
        /// </summary>
        /// <remarks>
        /// Endpoint for solving shift optimisation problem. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Optional description in *Markdown*</param>
        /// <param name="seconds">The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. (optional)</param>
        /// <returns>Task of ApiResponse (StatusJob)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusJob>> SolveShiftProblemAsyncWithHttpInfo (ShiftRequest body, int? seconds = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ShiftApi : IShiftApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShiftApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShiftApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get a solution 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>ShiftSolution</returns>
        public ShiftSolution GetSolution (long? jobId)
        {
             ApiResponse<ShiftSolution> localVarResponse = GetSolutionWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a solution 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of ShiftSolution</returns>
        public ApiResponse< ShiftSolution > GetSolutionWithHttpInfo (long? jobId)
        {
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling ShiftApi->GetSolution");

            var localVarPath = "/jobs/{jobId}/solution";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId)); // path parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSolution", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ShiftSolution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShiftSolution) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShiftSolution)));
        }

        /// <summary>
        /// Get a solution 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ShiftSolution</returns>
        public async System.Threading.Tasks.Task<ShiftSolution> GetSolutionAsync (long? jobId)
        {
             ApiResponse<ShiftSolution> localVarResponse = await GetSolutionAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a solution 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (ShiftSolution)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShiftSolution>> GetSolutionAsyncWithHttpInfo (long? jobId)
        {
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling ShiftApi->GetSolution");

            var localVarPath = "/jobs/{jobId}/solution";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId)); // path parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSolution", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ShiftSolution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShiftSolution) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShiftSolution)));
        }

        /// <summary>
        /// Get a status 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>StatusJob</returns>
        public StatusJob GetStatus (Guid? jobId)
        {
             ApiResponse<StatusJob> localVarResponse = GetStatusWithHttpInfo(jobId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a status 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>ApiResponse of StatusJob</returns>
        public ApiResponse< StatusJob > GetStatusWithHttpInfo (Guid? jobId)
        {
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling ShiftApi->GetStatus");

            var localVarPath = "/jobs/{jobId}/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId)); // path parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StatusJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusJob)));
        }

        /// <summary>
        /// Get a status 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of StatusJob</returns>
        public async System.Threading.Tasks.Task<StatusJob> GetStatusAsync (Guid? jobId)
        {
             ApiResponse<StatusJob> localVarResponse = await GetStatusAsyncWithHttpInfo(jobId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a status 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobId">Job ID</param>
        /// <returns>Task of ApiResponse (StatusJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusJob>> GetStatusAsyncWithHttpInfo (Guid? jobId)
        {
            // verify the required parameter 'jobId' is set
            if (jobId == null)
                throw new ApiException(400, "Missing required parameter 'jobId' when calling ShiftApi->GetStatus");

            var localVarPath = "/jobs/{jobId}/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (jobId != null) localVarPathParams.Add("jobId", this.Configuration.ApiClient.ParameterToString(jobId)); // path parameter

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StatusJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusJob)));
        }

        /// <summary>
        /// Solve SHIFT problem Endpoint for solving shift optimisation problem. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Optional description in *Markdown*</param>
        /// <param name="seconds">The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. (optional)</param>
        /// <returns>StatusJob</returns>
        public StatusJob SolveShiftProblem (ShiftRequest body, int? seconds = null)
        {
             ApiResponse<StatusJob> localVarResponse = SolveShiftProblemWithHttpInfo(body, seconds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Solve SHIFT problem Endpoint for solving shift optimisation problem. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Optional description in *Markdown*</param>
        /// <param name="seconds">The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. (optional)</param>
        /// <returns>ApiResponse of StatusJob</returns>
        public ApiResponse< StatusJob > SolveShiftProblemWithHttpInfo (ShiftRequest body, int? seconds = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ShiftApi->SolveShiftProblem");

            var localVarPath = "/solve";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (seconds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "seconds", seconds)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SolveShiftProblem", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StatusJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusJob)));
        }

        /// <summary>
        /// Solve SHIFT problem Endpoint for solving shift optimisation problem. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Optional description in *Markdown*</param>
        /// <param name="seconds">The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. (optional)</param>
        /// <returns>Task of StatusJob</returns>
        public async System.Threading.Tasks.Task<StatusJob> SolveShiftProblemAsync (ShiftRequest body, int? seconds = null)
        {
             ApiResponse<StatusJob> localVarResponse = await SolveShiftProblemAsyncWithHttpInfo(body, seconds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Solve SHIFT problem Endpoint for solving shift optimisation problem. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Optional description in *Markdown*</param>
        /// <param name="seconds">The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. (optional)</param>
        /// <returns>Task of ApiResponse (StatusJob)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StatusJob>> SolveShiftProblemAsyncWithHttpInfo (ShiftRequest body, int? seconds = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ShiftApi->SolveShiftProblem");

            var localVarPath = "/solve";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (seconds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "seconds", seconds)); // query parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }
            // authentication (bearerAuth) required

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SolveShiftProblem", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StatusJob>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StatusJob) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusJob)));
        }

    }
}
