# Microsoft.Blockchain @ 2018-06-01-preview

## Microsoft.Blockchain/blockchainMembers/transactionNodes
### Properties
* **apiVersion**: '2018-06-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: TransactionNodeProperties
* **type**: 'Microsoft.Blockchain/blockchainMembers/transactionNodes' (ReadOnly, DeployTimeConstant)

## TransactionNodeProperties
### Properties
* **dns**: string (ReadOnly)
* **firewallRules**: FirewallRule[]
* **password**: string
* **provisioningState**: 'Deleting' | 'Failed' | 'NotSpecified' | 'Succeeded' | 'Updating' (ReadOnly)
* **publicKey**: string (ReadOnly)
* **userName**: string (ReadOnly)

## FirewallRule
### Properties
* **endIpAddress**: string
* **ruleName**: string
* **startIpAddress**: string

## Microsoft.Blockchain/blockchainMembers
### Properties
* **apiVersion**: '2018-06-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: BlockchainMemberProperties
* **sku**: Sku
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.Blockchain/blockchainMembers' (ReadOnly, DeployTimeConstant)

## BlockchainMemberProperties
### Properties
* **consortium**: string
* **consortiumManagementAccountAddress**: string (ReadOnly)
* **consortiumManagementAccountPassword**: string
* **consortiumMemberDisplayName**: string
* **consortiumRole**: string
* **dns**: string (ReadOnly)
* **firewallRules**: FirewallRule[]
* **password**: string
* **protocol**: 'Corda' | 'NotSpecified' | 'Parity' | 'Quorum'
* **provisioningState**: 'Deleting' | 'Failed' | 'NotSpecified' | 'Stale' | 'Succeeded' | 'Updating' (ReadOnly)
* **publicKey**: string (ReadOnly)
* **rootContractAddress**: string (ReadOnly)
* **userName**: string (ReadOnly)
* **validatorNodesSku**: BlockchainMemberNodesSku

## BlockchainMemberNodesSku
### Properties
* **capacity**: int

## Sku
### Properties
* **name**: string
* **tier**: string

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

