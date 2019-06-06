# IO.Swagger.Api.TaskAPIApi

All URIs are relative to *https://api-dev.solvice.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSolution**](TaskAPIApi.md#getsolution) | **GET** /jobs/{jobId}/solution | Get a solution
[**GetStatus**](TaskAPIApi.md#getstatus) | **GET** /jobs/{jobId}/status | Get a status

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

            var apiInstance = new TaskAPIApi();
            var jobId = new Guid?(); // Guid? | Job ID

            try
            {
                // Get a solution
                apiInstance.GetSolution(jobId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskAPIApi.GetSolution: " + e.Message );
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

            var apiInstance = new TaskAPIApi();
            var jobId = new Guid?(); // Guid? | Job ID

            try
            {
                // Get a status
                StatusJob result = apiInstance.GetStatus(jobId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaskAPIApi.GetStatus: " + e.Message );
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
