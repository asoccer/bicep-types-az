# Microsoft.Maps @ 2018-05-01

## Microsoft.Maps/accounts
### Properties
* **apiVersion**: '2018-05-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: MapsAccountProperties (ReadOnly)
* **sku**: Sku (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.Maps/accounts' (ReadOnly, DeployTimeConstant)

## MapsAccountProperties
### Properties
* **x-ms-client-id**: string (ReadOnly)

## Sku
### Properties
* **name**: string (Required)
* **tier**: string (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

