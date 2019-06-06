# swagger_client.TaskAPIApi

All URIs are relative to *https://api-dev.solvice.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_solution**](TaskAPIApi.md#get_solution) | **GET** /jobs/{jobId}/solution | Get a solution
[**get_status**](TaskAPIApi.md#get_status) | **GET** /jobs/{jobId}/status | Get a status

# **get_solution**
> Object get_solution(job_id)

Get a solution

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.TaskAPIApi(swagger_client.ApiClient(configuration))
job_id = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Job ID

try:
    # Get a solution
    api_response = api_instance.get_solution(job_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskAPIApi->get_solution: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **job_id** | [**str**](.md)| Job ID | 

### Return type

[**Object**](Object.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_status**
> StatusJob get_status(job_id)

Get a status

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.TaskAPIApi(swagger_client.ApiClient(configuration))
job_id = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Job ID

try:
    # Get a status
    api_response = api_instance.get_status(job_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskAPIApi->get_status: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **job_id** | [**str**](.md)| Job ID | 

### Return type

[**StatusJob**](StatusJob.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

