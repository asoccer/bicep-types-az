# Microsoft.CostManagement @ 2019-11-01

## Microsoft.CostManagement/exports
### Properties
* **apiVersion**: '2019-11-01' (ReadOnly, DeployTimeConstant)
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
* **timeframe**: 'BillingMonthToDate' | 'Custom' | 'MonthToDate' | 'TheLastBillingMonth' | 'TheLastMonth' | 'WeekToDate' (Required)
* **type**: 'ActualCost' | 'AmortizedCost' | 'Usage' (Required)

## QueryDataset
### Properties
* **aggregation**: Dictionary<string,QueryAggregation>
* **configuration**: QueryDatasetConfiguration
* **filter**: QueryFilter
* **granularity**: 'Daily'
* **grouping**: QueryGrouping[]

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

## Microsoft.CostManagement/views
### Properties
* **apiVersion**: '2019-11-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **eTag**: string
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: ViewProperties
* **type**: 'Microsoft.CostManagement/views' (ReadOnly, DeployTimeConstant)

## ViewProperties
### Properties
* **accumulated**: 'false' | 'true'
* **chart**: 'Area' | 'GroupedColumn' | 'Line' | 'StackedColumn' | 'Table'
* **createdOn**: string (ReadOnly)
* **displayName**: string
* **kpis**: KpiProperties[]
* **metric**: 'AHUB' | 'ActualCost' | 'AmortizedCost'
* **modifiedOn**: string (ReadOnly)
* **pivots**: PivotProperties[]
* **query**: ReportConfigDefinition
* **scope**: string

## KpiProperties
### Properties
* **enabled**: bool
* **id**: string
* **type**: 'Budget' | 'Forecast'

## PivotProperties
### Properties
* **name**: string
* **type**: 'Dimension' | 'TagKey'

## ReportConfigDefinition
### Properties
* **dataset**: ReportConfigDataset
* **timePeriod**: ReportConfigTimePeriod
* **timeframe**: 'Custom' | 'MonthToDate' | 'WeekToDate' | 'YearToDate' (Required)
* **type**: string (Required)

## ReportConfigDataset
### Properties
* **aggregation**: Dictionary<string,ReportConfigAggregation>
* **configuration**: ReportConfigDatasetConfiguration
* **filter**: ReportConfigFilter
* **granularity**: 'Daily' | 'Monthly'
* **grouping**: ReportConfigGrouping[]
* **sorting**: ReportConfigSorting[]

## Dictionary<string,ReportConfigAggregation>
### Additional Properties
* **Additional Properties Type**: ReportConfigAggregation

## ReportConfigAggregation
### Properties
* **function**: string (Required)
* **name**: string (Required)

## ReportConfigDatasetConfiguration
### Properties
* **columns**: string[]

## ReportConfigFilter
### Properties
* **and**: ReportConfigFilter[]
* **dimension**: ReportConfigComparisonExpression
* **not**: ReportConfigFilter
* **or**: ReportConfigFilter[]
* **tag**: ReportConfigComparisonExpression

## ReportConfigComparisonExpression
### Properties
* **name**: string (Required)
* **operator**: 'Contains' | 'In' (Required)
* **values**: string[] (Required)

## ReportConfigGrouping
### Properties
* **name**: string (Required)
* **type**: 'Dimension' | 'Tag' (Required)

## ReportConfigSorting
### Properties
* **direction**: 'Ascending' | 'Descending'
* **name**: string (Required)

## ReportConfigTimePeriod
### Properties
* **from**: string (Required)
* **to**: string (Required)

## Microsoft.CostManagement/views
### Properties
* **apiVersion**: '2019-11-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **eTag**: string
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: ViewProperties
* **type**: 'Microsoft.CostManagement/views' (ReadOnly, DeployTimeConstant)

