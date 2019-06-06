# Statute

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **string** | Unique name for a definition of a statute. | 
**min_shift_length** | **int** | The minimum number of hours in a shift for an employee | [optional] 
**max_shift_length** | **int** | The maximum number of hours in a shift for an employee | [optional] 
**min_rest_between_shifts** | **int** | The minimum duration (in hours) of a rest period between two shifts for this employee | [optional] 
**max_consecutive_work_days** | **int** | The maximum days consecutive that this employee can be working | [optional] 
**max_hrs_per_week** | **int** | The maximum number of hours this employee can be working in a week | [optional] 
**min_hrs_per_week** | **int** | The minimum number of hours this employee should be working in a week | [optional] 
**shift_start** | [**BigDecimal**](BigDecimal.md) | The earliest this employee can start working (expressed as decimal in 24 hour-format) | [optional] 
**latest_shift_start** | [**BigDecimal**](BigDecimal.md) | The latest this employee can start working (expressed as decimal in 24 hour-format) | [optional] 
**shift_end** | [**BigDecimal**](BigDecimal.md) | The latest this employee can work on a day (expressed as decimal in 24 hour-format) | [optional] 
**min_hours_month** | **int** | The minimum hours per month this employee should be working | [optional] 
**max_hours_month** | **int** | The maximum hours per month this employee should be working | [optional] 
**over_time_threshold1** | [**BigDecimal**](BigDecimal.md) | The first time threshold for overtime (expressed as decimal in 24 hour-format) | [optional] 
**over_time_raise1** | [**BigDecimal**](BigDecimal.md) | The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour) | [optional] 
**over_time_threshold2** | [**BigDecimal**](BigDecimal.md) | The second time threshold for overtime (expressed as decimal in 24 hour-format) | [optional] 
**over_time_raise2** | [**BigDecimal**](BigDecimal.md) | The raise after the second time threshold for overtime (e.q. 1.2 means a 20% raise per hour) | [optional] 
**over_time_weekly_threshold1** | [**BigDecimal**](BigDecimal.md) | The number of hours per week after which a \&quot;weekly overtime\&quot; raise should be given | [optional] 
**over_time_weekly_raise1** | [**BigDecimal**](BigDecimal.md) | The weekly overtime raise (e.q. 1.2 means a 20% raise per hour) | [optional] 
**nightly_threshold1** | [**BigDecimal**](BigDecimal.md) | The time threshold to be considered for a night raise (expressed as decimal in 24 hour-format) | [optional] 
**nightly_raise** | [**BigDecimal**](BigDecimal.md) | The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

