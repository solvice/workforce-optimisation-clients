# IO.Swagger.Api.ShiftAPIApi

All URIs are relative to *https://api-dev.solvice.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSolution**](ShiftAPIApi.md#getsolution) | **GET** /jobs/{jobId}/solution | Get a solution
[**GetStatus**](ShiftAPIApi.md#getstatus) | **GET** /jobs/{jobId}/status | Get a status
[**SolveShiftProblem**](ShiftAPIApi.md#solveshiftproblem) | **POST** /solve | Solve SHIFT problem

<a name="getsolution"></a>
# **GetSolution**
> void GetSolution (Guid? jobId)

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

            var apiInstance = new ShiftAPIApi();
            var jobId = new Guid?(); // Guid? | Job ID

            try
            {
                // Get a solution
                apiInstance.GetSolution(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShiftAPIApi.GetSolution: " + e.Message );
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

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

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

            var apiInstance = new ShiftAPIApi();
            var jobId = new Guid?(); // Guid? | Job ID

            try
            {
                // Get a status
                StatusJob result = apiInstance.GetStatus(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShiftAPIApi.GetStatus: " + e.Message );
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

[bearerAuth](../README.md#bearerAuth)

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

            var apiInstance = new ShiftAPIApi();
            var body = new ShiftRequest(); // ShiftRequest | Payload for all information concerning the shift problem.
This includes:

 - the demand
 - the pool of employees
 - the statutes

            var seconds = 56;  // int? | The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. (optional) 

            try
            {
                // Solve SHIFT problem
                StatusJob result = apiInstance.SolveShiftProblem(body, seconds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShiftAPIApi.SolveShiftProblem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShiftRequest**](ShiftRequest.md)| Payload for all information concerning the shift problem.
This includes:

 - the demand
 - the pool of employees
 - the statutes
 | 
 **seconds** | **int?**| The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. | [optional] 

### Return type

[**StatusJob**](StatusJob.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
