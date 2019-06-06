# swagger_client.TaskApi

All URIs are relative to *https://api-dev.solvice.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_solution**](TaskApi.md#get_solution) | **GET** /jobs/{jobId}/solution | Get a solution
[**get_status**](TaskApi.md#get_status) | **GET** /jobs/{jobId}/status | Get a status
[**solve_task**](TaskApi.md#solve_task) | **POST** /solve/task | Solve TASK problem

# **get_solution**
> ShiftSolution get_solution(job_id)

Get a solution

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint
# Configure HTTP basic authorization: basicAuth
configuration = swagger_client.Configuration()
configuration.username = 'YOUR_USERNAME'
configuration.password = 'YOUR_PASSWORD'

# create an instance of the API class
api_instance = swagger_client.TaskApi(swagger_client.ApiClient(configuration))
job_id = 789 # int | Job ID

try:
    # Get a solution
    api_response = api_instance.get_solution(job_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskApi->get_solution: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **job_id** | **int**| Job ID | 

### Return type

[**ShiftSolution**](ShiftSolution.md)

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

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
# Configure HTTP basic authorization: basicAuth
configuration = swagger_client.Configuration()
configuration.username = 'YOUR_USERNAME'
configuration.password = 'YOUR_PASSWORD'

# create an instance of the API class
api_instance = swagger_client.TaskApi(swagger_client.ApiClient(configuration))
job_id = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Job ID

try:
    # Get a status
    api_response = api_instance.get_status(job_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskApi->get_status: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **job_id** | [**str**](.md)| Job ID | 

### Return type

[**StatusJob**](StatusJob.md)

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **solve_task**
> StatusJob solve_task(seconds=seconds)

Solve TASK problem

Solving task optimisation problem 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint
# Configure HTTP basic authorization: basicAuth
configuration = swagger_client.Configuration()
configuration.username = 'YOUR_USERNAME'
configuration.password = 'YOUR_PASSWORD'

# create an instance of the API class
api_instance = swagger_client.TaskApi(swagger_client.ApiClient(configuration))
seconds = 56 # int | The number of seconds you give the solver to optimise the TASK problem. By default, the solver decides. (optional)

try:
    # Solve TASK problem
    api_response = api_instance.solve_task(seconds=seconds)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskApi->solve_task: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **seconds** | **int**| The number of seconds you give the solver to optimise the TASK problem. By default, the solver decides. | [optional] 

### Return type

[**StatusJob**](StatusJob.md)

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

