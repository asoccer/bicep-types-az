# Microsoft.ResourceGraph @ 2018-09-01-preview

## Microsoft.ResourceGraph/queries
### Properties
* **apiVersion**: '2018-09-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **eTag**: string
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: GraphQueryProperties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.ResourceGraph/queries' (ReadOnly, DeployTimeConstant)

## GraphQueryProperties
### Properties
* **description**: string
* **query**: string (Required)
* **resultKind**: 'basic' (ReadOnly)
* **timeModified**: string (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

