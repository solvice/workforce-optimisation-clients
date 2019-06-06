# IO.Swagger.Model.Statute
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Unique name for a definition of a statute. | 
**MinShiftLength** | **int?** | The minimum number of hours in a shift for an employee | [optional] 
**MaxShiftLength** | **int?** | The maximum number of hours in a shift for an employee | [optional] 
**MinRestBetweenShifts** | **int?** | The minimum duration (in hours) of a rest period between two shifts for this employee | [optional] 
**MaxConsecutiveWorkDays** | **int?** | The maximum days consecutive that this employee can be working | [optional] 
**MaxHrsPerWeek** | **int?** | The maximum number of hours this employee can be working in a week | [optional] 
**MinHrsPerWeek** | **int?** | The minimum number of hours this employee should be working in a week | [optional] 
**ShiftStart** | [**BigDecimal**](BigDecimal.md) | The earliest this employee can start working (expressed as decimal in 24 hour-format) | [optional] 
**LatestShiftStart** | [**BigDecimal**](BigDecimal.md) | The latest this employee can start working (expressed as decimal in 24 hour-format) | [optional] 
**ShiftEnd** | [**BigDecimal**](BigDecimal.md) | The latest this employee can work on a day (expressed as decimal in 24 hour-format) | [optional] 
**MinHoursMonth** | **int?** | The minimum hours per month this employee should be working | [optional] 
**MaxHoursMonth** | **int?** | The maximum hours per month this employee should be working | [optional] 
**OverTimeThreshold1** | [**BigDecimal**](BigDecimal.md) | The first time threshold for overtime (expressed as decimal in 24 hour-format) | [optional] 
**OverTimeRaise1** | [**BigDecimal**](BigDecimal.md) | The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour) | [optional] 
**OverTimeThreshold2** | [**BigDecimal**](BigDecimal.md) | The second time threshold for overtime (expressed as decimal in 24 hour-format) | [optional] 
**OverTimeRaise2** | [**BigDecimal**](BigDecimal.md) | The raise after the second time threshold for overtime (e.q. 1.2 means a 20% raise per hour) | [optional] 
**OverTimeWeeklyThreshold1** | [**BigDecimal**](BigDecimal.md) | The number of hours per week after which a \&quot;weekly overtime\&quot; raise should be given | [optional] 
**OverTimeWeeklyRaise1** | [**BigDecimal**](BigDecimal.md) | The weekly overtime raise (e.q. 1.2 means a 20% raise per hour) | [optional] 
**NightlyThreshold1** | [**BigDecimal**](BigDecimal.md) | The time threshold to be considered for a night raise (expressed as decimal in 24 hour-format) | [optional] 
**NightlyRaise** | [**BigDecimal**](BigDecimal.md) | The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

