# Microsoft.CostManagement @ 2019-01-01

## Microsoft.CostManagement/exports
### Properties
* **apiVersion**: '2019-01-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: ExportProperties
* **tags**: Dictionary<string,String> (ReadOnly)
* **type**: 'Microsoft.CostManagement/exports' (ReadOnly, DeployTimeConstant)

## ExportProperties
### Properties
* **definition**: QueryDefinition (Required)
* **deliveryInfo**: ExportDeliveryInfo (Required)
* **format**: 'Csv'
* **schedule**: ExportSchedule

## QueryDefinition
### Properties
* **dataset**: QueryDataset
* **timePeriod**: QueryTimePeriod
* **timeframe**: 'BillingMonthToDate' | 'Custom' | 'MonthToDate' | 'TheLastBillingMonth' | 'TheLastMonth' | 'TheLastWeek' | 'TheLastYear' | 'WeekToDate' | 'YearToDate' (Required)
* **type**: string (Required)

## QueryDataset
### Properties
* **aggregation**: Dictionary<string,QueryAggregation>
* **configuration**: QueryDatasetConfiguration
* **filter**: QueryFilter
* **granularity**: 'Daily' | 'Hourly'
* **grouping**: QueryGrouping[]
* **sorting**: QuerySortingConfiguration[]

## Dictionary<string,QueryAggregation>
### Additional Properties
* **Additional Properties Type**: QueryAggregation

## QueryAggregation
### Properties
* **function**: string (Required)
* **name**: string (Required)

## QueryDatasetConfiguration
### Properties
* **columns**: string[]

## QueryFilter
### Properties
* **and**: QueryFilter[]
* **dimension**: QueryComparisonExpression
* **not**: QueryFilter
* **or**: QueryFilter[]
* **tag**: QueryComparisonExpression

## QueryComparisonExpression
### Properties
* **name**: string (Required)
* **operator**: string (Required)
* **values**: string[] (Required)

## QueryGrouping
### Properties
* **name**: string (Required)
* **type**: 'Dimension' | 'Tag' (Required)

## QuerySortingConfiguration
### Properties
* **name**: string
* **querySortingDirection**: 'Ascending' | 'Descending'

## QueryTimePeriod
### Properties
* **from**: string (Required)
* **to**: string (Required)

## ExportDeliveryInfo
### Properties
* **destination**: ExportDeliveryDestination (Required)

## ExportDeliveryDestination
### Properties
* **container**: string (Required)
* **resourceId**: string (Required)
* **rootFolderPath**: string

## ExportSchedule
### Properties
* **recurrence**: 'Annually' | 'Daily' | 'Monthly' | 'Weekly' (Required)
* **recurrencePeriod**: ExportRecurrencePeriod
* **status**: 'Active' | 'Inactive'

## ExportRecurrencePeriod
### Properties
* **from**: string (Required)
* **to**: string

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

