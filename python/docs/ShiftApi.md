# swagger_client.ShiftApi

All URIs are relative to *https://api-dev.solvice.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_solution**](ShiftApi.md#get_solution) | **GET** /jobs/{jobId}/solution | Get a solution
[**get_status**](ShiftApi.md#get_status) | **GET** /jobs/{jobId}/status | Get a status
[**solve_shift_problem**](ShiftApi.md#solve_shift_problem) | **POST** /solve | Solve SHIFT problem

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
api_instance = swagger_client.ShiftApi(swagger_client.ApiClient(configuration))
job_id = 789 # int | Job ID

try:
    # Get a solution
    api_response = api_instance.get_solution(job_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ShiftApi->get_solution: %s\n" % e)
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
api_instance = swagger_client.ShiftApi(swagger_client.ApiClient(configuration))
job_id = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Job ID

try:
    # Get a status
    api_response = api_instance.get_status(job_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ShiftApi->get_status: %s\n" % e)
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

# **solve_shift_problem**
> StatusJob solve_shift_problem(body, seconds=seconds)

Solve SHIFT problem

Endpoint for solving shift optimisation problem. 

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
api_instance = swagger_client.ShiftApi(swagger_client.ApiClient(configuration))
body = swagger_client.ShiftRequest() # ShiftRequest | Optional description in *Markdown*
seconds = 56 # int | The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. (optional)

try:
    # Solve SHIFT problem
    api_response = api_instance.solve_shift_problem(body, seconds=seconds)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ShiftApi->solve_shift_problem: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShiftRequest**](ShiftRequest.md)| Optional description in *Markdown* | 
 **seconds** | **int**| The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. | [optional] 

### Return type

[**StatusJob**](StatusJob.md)

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

