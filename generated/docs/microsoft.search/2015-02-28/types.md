# Microsoft.Search @ 2015-02-28

## Microsoft.Search/searchServices
### Properties
* **apiVersion**: '2015-02-28' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: SearchServiceProperties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.Search/searchServices' (ReadOnly, DeployTimeConstant)

## SearchServiceProperties
### Properties
* **partitionCount**: int
* **replicaCount**: int
* **sku**: Sku

## Sku
### Properties
* **name**: 'free' | 'standard' | 'standard2'

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

