# IO.Swagger.Model.ShiftRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Solver** | [**Solver**](Solver.md) |  | [optional] 
**Hook** | **string** | Webhook returns solution status after solving in the form of a POST request to the uri given. | [optional] 
**Demand** | [**List&lt;Demand&gt;**](Demand.md) | Demand blocks for which a certain number of employees by a certain skill and on a certain location are required. | 
**Employees** | [**List&lt;Employee&gt;**](Employee.md) | Group of employees available to be planned in the planning period defined by the demand. | 
**Statutes** | [**List&lt;Statute&gt;**](Statute.md) | Statute definitions used by employees. | 
**Assignments** | [**List&lt;ShiftAssignment&gt;**](ShiftAssignment.md) | Pre made assignments that the solver should take into account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

