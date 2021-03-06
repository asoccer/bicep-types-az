# Microsoft.Resources @ 2016-09-01

## Microsoft.Resources/deployments
### Properties
* **apiVersion**: '2016-09-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: DeploymentProperties (Required)
* **type**: 'Microsoft.Resources/deployments' (ReadOnly, DeployTimeConstant)

## DeploymentProperties
### Properties
* **correlationId**: string (ReadOnly)
* **debugSetting**: DebugSetting
* **dependencies**: Dependency[] (ReadOnly)
* **mode**: 'Complete' | 'Incremental' (Required)
* **outputs**: any (ReadOnly)
* **parameters**: any
* **parametersLink**: ParametersLink
* **providers**: Provider[] (ReadOnly)
* **provisioningState**: string (ReadOnly)
* **template**: any
* **templateLink**: TemplateLink
* **timestamp**: string (ReadOnly)

## DebugSetting
### Properties
* **detailLevel**: string

## Dependency
### Properties
* **dependsOn**: BasicDependency[] (ReadOnly)
* **id**: string (ReadOnly)
* **resourceName**: string (ReadOnly)
* **resourceType**: string (ReadOnly)

## BasicDependency
### Properties
* **id**: string (ReadOnly)
* **resourceName**: string (ReadOnly)
* **resourceType**: string (ReadOnly)

## ParametersLink
### Properties
* **contentVersion**: string
* **uri**: string (Required)

## Provider
### Properties
* **id**: string (ReadOnly)
* **namespace**: string (ReadOnly)
* **registrationState**: string (ReadOnly)
* **resourceTypes**: ProviderResourceType[] (ReadOnly)

## ProviderResourceType
### Properties
* **aliases**: AliasType[] (ReadOnly)
* **apiVersions**: string[] (ReadOnly)
* **locations**: string[] (ReadOnly)
* **properties**: Dictionary<string,String> (ReadOnly)
* **resourceType**: string (ReadOnly)

## AliasType
### Properties
* **name**: string (ReadOnly)
* **paths**: AliasPathType[] (ReadOnly)

## AliasPathType
### Properties
* **apiVersions**: string[] (ReadOnly)
* **path**: string (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## TemplateLink
### Properties
* **contentVersion**: string
* **uri**: string (Required)

