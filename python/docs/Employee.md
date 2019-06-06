# Employee

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **str** | Unique name/id of employee | 
**statute** | **str** | Reference to Statute name | 
**skill** | **str** | Skill name owned by employee | 
**efficiency** | [**BigDecimal**](BigDecimal.md) | Efficiency rate of employee. 1.0 is normal and default | [optional] 
**hourly_pay** | [**BigDecimal**](BigDecimal.md) | Hourly wage/pay for employee. Total costs are minimised by the optimiser. | [optional] 
**last_rest_date** | **date** | The last date on which the employee had a rest before the planning period. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

