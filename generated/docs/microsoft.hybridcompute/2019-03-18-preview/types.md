# Microsoft.HybridCompute @ 2019-03-18-preview

## Microsoft.HybridCompute/machines
### Properties
* **apiVersion**: '2019-03-18-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **identity**: Identity
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: MachineProperties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.HybridCompute/machines' (ReadOnly, DeployTimeConstant)

## Identity
### Properties
* **principalId**: string (ReadOnly)
* **tenantId**: string (ReadOnly)
* **type**: string

## MachineProperties
### Properties
* **agentVersion**: string (ReadOnly)
* **clientPublicKey**: string
* **displayName**: string (ReadOnly)
* **errorDetails**: ErrorDetail[] (ReadOnly)
* **lastStatusChange**: string (ReadOnly)
* **machineFqdn**: string (ReadOnly)
* **osName**: string (ReadOnly)
* **osProfile**: OSProfile
* **osVersion**: string (ReadOnly)
* **physicalLocation**: string
* **provisioningState**: string (ReadOnly)
* **status**: 'Connected' | 'Disconnected' | 'Error' (ReadOnly)
* **vmId**: string (ReadOnly)

## ErrorDetail
### Properties
* **code**: string (Required)
* **details**: ErrorDetail[]
* **message**: string (Required)
* **target**: string

## OSProfile
### Properties
* **computerName**: string (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

