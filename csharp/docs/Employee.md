# IO.Swagger.Model.Employee
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Unique name/id of employee | 
**Statute** | **string** | Reference to Statute name | 
**Skill** | **string** | Skill name owned by employee | 
**Efficiency** | [**BigDecimal**](BigDecimal.md) | Efficiency rate of employee. 1.0 is normal and default | [optional] 
**HourlyPay** | [**BigDecimal**](BigDecimal.md) | Hourly wage/pay for employee. Total costs are minimised by the optimiser. | [optional] 
**LastRestDate** | **DateTime?** | The last date on which the employee had a rest before the planning period. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

