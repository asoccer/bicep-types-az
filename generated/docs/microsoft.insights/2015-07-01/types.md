# microsoft.insights @ 2015-07-01

## microsoft.insights/diagnosticSettings
### Properties
* **apiVersion**: '2015-07-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string (Required)
* **name**: 'service' (Required, DeployTimeConstant)
* **properties**: ServiceDiagnosticSettings
* **tags**: Dictionary<string,String>
* **type**: 'microsoft.insights/diagnosticSettings' (ReadOnly, DeployTimeConstant)

## ServiceDiagnosticSettings
### Properties
* **logs**: LogSettings[]
* **metrics**: MetricSettings[]
* **serviceBusRuleId**: string
* **storageAccountId**: string
* **workspaceId**: string

## LogSettings
### Properties
* **category**: string
* **enabled**: bool (Required)
* **retentionPolicy**: RetentionPolicy

## RetentionPolicy
### Properties
* **days**: int (Required)
* **enabled**: bool (Required)

## MetricSettings
### Properties
* **enabled**: bool (Required)
* **retentionPolicy**: RetentionPolicy
* **timeGrain**: string (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

