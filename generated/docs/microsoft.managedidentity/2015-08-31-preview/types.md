# Microsoft.ManagedIdentity @ 2015-08-31-preview

## Microsoft.ManagedIdentity/userAssignedIdentities
### Properties
* **apiVersion**: '2015-08-31-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: IdentityProperties (ReadOnly)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.ManagedIdentity/userAssignedIdentities' (ReadOnly, DeployTimeConstant)

## IdentityProperties
### Properties
* **clientId**: string (ReadOnly)
* **clientSecretUrl**: string (ReadOnly)
* **principalId**: string (ReadOnly)
* **tenantId**: string (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

