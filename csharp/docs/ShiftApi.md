# IO.Swagger.Api.ShiftApi

All URIs are relative to *https://api-dev.solvice.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSolution**](ShiftApi.md#getsolution) | **GET** /jobs/{jobId}/solution | Get a solution
[**GetStatus**](ShiftApi.md#getstatus) | **GET** /jobs/{jobId}/status | Get a status
[**SolveShiftProblem**](ShiftApi.md#solveshiftproblem) | **POST** /solve | Solve SHIFT problem

<a name="getsolution"></a>
# **GetSolution**
> ShiftSolution GetSolution (long? jobId)

Get a solution

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSolutionExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ShiftApi();
            var jobId = 789;  // long? | Job ID

            try
            {
                // Get a solution
                ShiftSolution result = apiInstance.GetSolution(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShiftApi.GetSolution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **long?**| Job ID | 

### Return type

[**ShiftSolution**](ShiftSolution.md)

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getstatus"></a>
# **GetStatus**
> StatusJob GetStatus (Guid? jobId)

Get a status

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetStatusExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ShiftApi();
            var jobId = new Guid?(); // Guid? | Job ID

            try
            {
                // Get a status
                StatusJob result = apiInstance.GetStatus(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShiftApi.GetStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | [**Guid?**](Guid?.md)| Job ID | 

### Return type

[**StatusJob**](StatusJob.md)

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="solveshiftproblem"></a>
# **SolveShiftProblem**
> StatusJob SolveShiftProblem (ShiftRequest body, int? seconds = null)

Solve SHIFT problem

Endpoint for solving shift optimisation problem. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SolveShiftProblemExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new ShiftApi();
            var body = new ShiftRequest(); // ShiftRequest | Optional description in *Markdown*
            var seconds = 56;  // int? | The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. (optional) 

            try
            {
                // Solve SHIFT problem
                StatusJob result = apiInstance.SolveShiftProblem(body, seconds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShiftApi.SolveShiftProblem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShiftRequest**](ShiftRequest.md)| Optional description in *Markdown* | 
 **seconds** | **int?**| The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. | [optional] 

### Return type

[**StatusJob**](StatusJob.md)

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
