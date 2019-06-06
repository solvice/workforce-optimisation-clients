# Swagger\Client\ShiftApi

All URIs are relative to *https://api-dev.solvice.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getSolution**](ShiftApi.md#getSolution) | **GET** /jobs/{jobId}/solution | Get a solution
[**getStatus**](ShiftApi.md#getStatus) | **GET** /jobs/{jobId}/status | Get a status
[**solveShiftProblem**](ShiftApi.md#solveShiftProblem) | **POST** /solve | Solve SHIFT problem

# **getSolution**
> \Swagger\Client\Model\ShiftSolution getSolution($job_id)

Get a solution

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure HTTP basic authorization: basicAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()
              ->setUsername('YOUR_USERNAME')
              ->setPassword('YOUR_PASSWORD');


$apiInstance = new Swagger\Client\Api\ShiftApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$job_id = 789; // int | Job ID

try {
    $result = $apiInstance->getSolution($job_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ShiftApi->getSolution: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **job_id** | **int**| Job ID |

### Return type

[**\Swagger\Client\Model\ShiftSolution**](../Model/ShiftSolution.md)

### Authorization

[basicAuth](../../README.md#basicAuth), [bearerAuth](../../README.md#bearerAuth)

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
// Configure HTTP basic authorization: basicAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()
              ->setUsername('YOUR_USERNAME')
              ->setPassword('YOUR_PASSWORD');


$apiInstance = new Swagger\Client\Api\ShiftApi(
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
    echo 'Exception when calling ShiftApi->getStatus: ', $e->getMessage(), PHP_EOL;
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

[basicAuth](../../README.md#basicAuth), [bearerAuth](../../README.md#bearerAuth)

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
// Configure HTTP basic authorization: basicAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()
              ->setUsername('YOUR_USERNAME')
              ->setPassword('YOUR_PASSWORD');


$apiInstance = new Swagger\Client\Api\ShiftApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\ShiftRequest(); // \Swagger\Client\Model\ShiftRequest | Optional description in *Markdown*
$seconds = 56; // int | The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides.

try {
    $result = $apiInstance->solveShiftProblem($body, $seconds);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ShiftApi->solveShiftProblem: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ShiftRequest**](../Model/ShiftRequest.md)| Optional description in *Markdown* |
 **seconds** | **int**| The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides. | [optional]

### Return type

[**\Swagger\Client\Model\StatusJob**](../Model/StatusJob.md)

### Authorization

[basicAuth](../../README.md#basicAuth), [bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

