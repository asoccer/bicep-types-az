# microsoft.insights @ 2018-04-16

## microsoft.insights/scheduledQueryRules
### Properties
* **apiVersion**: '2018-04-16' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: LogSearchRule (Required)
* **tags**: Dictionary<string,String>
* **type**: 'microsoft.insights/scheduledQueryRules' (ReadOnly, DeployTimeConstant)

## LogSearchRule
### Properties
* **action**: Action (Required)
* **description**: string
* **enabled**: 'false' | 'true'
* **lastUpdatedTime**: string (ReadOnly)
* **provisioningState**: 'Canceled' | 'Deploying' | 'Failed' | 'Succeeded' (ReadOnly)
* **schedule**: Schedule
* **source**: Source (Required)

## Action
* **Discriminator**: odata.type
### Base Properties
### Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.AlertingAction
#### Properties
* **aznsAction**: AzNsActionGroup
* **odata.type**: 'Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.AlertingAction' (Required)
* **severity**: '0' | '1' | '2' | '3' | '4' (Required)
* **throttlingInMin**: int
* **trigger**: TriggerCondition (Required)

### Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.LogToMetricAction
#### Properties
* **criteria**: Criteria[] (Required)
* **odata.type**: 'Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.LogToMetricAction' (Required)


## Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.AlertingAction
### Properties
* **aznsAction**: AzNsActionGroup
* **odata.type**: 'Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.AlertingAction' (Required)
* **severity**: '0' | '1' | '2' | '3' | '4' (Required)
* **throttlingInMin**: int
* **trigger**: TriggerCondition (Required)

## AzNsActionGroup
### Properties
* **actionGroup**: string[]
* **customWebhookPayload**: string
* **emailSubject**: string

## TriggerCondition
### Properties
* **metricTrigger**: LogMetricTrigger
* **threshold**: int (Required)
* **thresholdOperator**: 'Equal' | 'GreaterThan' | 'LessThan' (Required)

## LogMetricTrigger
### Properties
* **metricColumn**: string
* **metricTriggerType**: 'Consecutive' | 'Total'
* **threshold**: int
* **thresholdOperator**: 'Equal' | 'GreaterThan' | 'LessThan'

## Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.LogToMetricAction
### Properties
* **criteria**: Criteria[] (Required)
* **odata.type**: 'Microsoft.WindowsAzure.Management.Monitoring.Alerts.Models.Microsoft.AppInsights.Nexus.DataContracts.Resources.ScheduledQueryRules.LogToMetricAction' (Required)

## Criteria
### Properties
* **dimensions**: Dimension[]
* **metricName**: string (Required)

## Dimension
### Properties
* **name**: string (Required)
* **operator**: string (Required)
* **values**: string[] (Required)

## Schedule
### Properties
* **frequencyInMinutes**: int (Required)
* **timeWindowInMinutes**: int (Required)

## Source
### Properties
* **authorizedResources**: string[]
* **dataSourceId**: string (Required)
* **query**: string
* **queryType**: 'ResultCount'

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

