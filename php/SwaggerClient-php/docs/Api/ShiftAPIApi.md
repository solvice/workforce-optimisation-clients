# Swagger\Client\ShiftAPIApi

All URIs are relative to *https://api-dev.solvice.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getSolution**](ShiftAPIApi.md#getSolution) | **GET** /jobs/{jobId}/solution | Get a solution
[**getStatus**](ShiftAPIApi.md#getStatus) | **GET** /jobs/{jobId}/status | Get a status
[**solveShiftProblem**](ShiftAPIApi.md#solveShiftProblem) | **POST** /solve | Solve SHIFT problem

# **getSolution**
> getSolution($job_id)

Get a solution

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new Swagger\Client\Api\ShiftAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$job_id = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Job ID

try {
    $apiInstance->getSolution($job_id);
} catch (Exception $e) {
    echo 'Exception when calling ShiftAPIApi->getSolution: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **job_id** | [**string**](../Model/.md)| Job ID |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **getStatus**
> \Swagger\Client\Model\StatusJob getStatus($job_id)

Get a status

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new Swagger\Client\Api\ShiftAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$job_id = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Job ID

try {
    $result = $apiInstance->getStatus($job_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ShiftAPIApi->getStatus: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **job_id** | [**string**](../Model/.md)| Job ID |

### Return type

[**\Swagger\Client\Model\StatusJob**](../Model/StatusJob.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **solveShiftProblem**
> \Swagger\Client\Model\StatusJob solveShiftProblem($body, $seconds)

Solve SHIFT problem

Endpoint for solving shift optimisation problem.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new Swagger\Client\Api\ShiftAPIApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\ShiftRequest(); // \Swagger\Client\Model\ShiftRequest | Payload for all information concerning the shift problem.
This includes:

 - the demand
 - the pool of employees
 - the statutes

$seconds = 56; // int | The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides.

try {
    $result = $apiInstance->solveShiftProblem($body, $seconds);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ShiftAPIApi->solveShiftProblem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ShiftRequest**](../Model/ShiftRequest.md)| Payload for all information concerning the shift problem.
This includes:

 - the demand
 - the pool of employees
 - the statutes
 |
 **seconds** | **int**| The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. | [optional]

### Return type

[**\Swagger\Client\Model\StatusJob**](../Model/StatusJob.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

