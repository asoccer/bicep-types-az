# Microsoft.KeyVault @ 2018-02-14

## Microsoft.KeyVault/vaults/accessPolicies
### Properties
* **apiVersion**: '2018-02-14' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string (ReadOnly)
* **name**: 'add' | 'remove' | 'replace' (Required, DeployTimeConstant)
* **properties**: VaultAccessPolicyProperties (Required)
* **type**: 'Microsoft.KeyVault/vaults/accessPolicies' (ReadOnly, DeployTimeConstant)

## VaultAccessPolicyProperties
### Properties
* **accessPolicies**: AccessPolicyEntry[] (Required)

## AccessPolicyEntry
### Properties
* **applicationId**: string
* **objectId**: string (Required)
* **permissions**: Permissions (Required)
* **tenantId**: string (Required)

## Permissions
### Properties
* **certificates**: 'backup' | 'create' | 'delete' | 'deleteissuers' | 'get' | 'getissuers' | 'import' | 'list' | 'listissuers' | 'managecontacts' | 'manageissuers' | 'purge' | 'recover' | 'restore' | 'setissuers' | 'update'[]
* **keys**: 'backup' | 'create' | 'decrypt' | 'delete' | 'encrypt' | 'get' | 'import' | 'list' | 'purge' | 'recover' | 'restore' | 'sign' | 'unwrapKey' | 'update' | 'verify' | 'wrapKey'[]
* **secrets**: 'backup' | 'delete' | 'get' | 'list' | 'purge' | 'recover' | 'restore' | 'set'[]
* **storage**: 'backup' | 'delete' | 'deletesas' | 'get' | 'getsas' | 'list' | 'listsas' | 'purge' | 'recover' | 'regeneratekey' | 'restore' | 'set' | 'setsas' | 'update'[]

## Microsoft.KeyVault/vaults/privateEndpointConnections
### Properties
* **apiVersion**: '2018-02-14' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string (ReadOnly)
* **name**: string (Required, DeployTimeConstant)
* **properties**: PrivateEndpointConnectionProperties
* **tags**: Dictionary<string,String> (ReadOnly)
* **type**: 'Microsoft.KeyVault/vaults/privateEndpointConnections' (ReadOnly, DeployTimeConstant)

## PrivateEndpointConnectionProperties
### Properties
* **privateEndpoint**: PrivateEndpoint
* **privateLinkServiceConnectionState**: PrivateLinkServiceConnectionState
* **provisioningState**: 'Creating' | 'Deleting' | 'Disconnected' | 'Failed' | 'Succeeded' | 'Updating'

## PrivateEndpoint
### Properties
* **id**: string (ReadOnly)

## PrivateLinkServiceConnectionState
### Properties
* **actionRequired**: string
* **description**: string
* **status**: 'Approved' | 'Disconnected' | 'Pending' | 'Rejected'

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.KeyVault/vaults
### Properties
* **apiVersion**: '2018-02-14' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: VaultProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.KeyVault/vaults' (ReadOnly, DeployTimeConstant)

## VaultProperties
### Properties
* **accessPolicies**: AccessPolicyEntry[]
* **createMode**: 'default' | 'recover'
* **enablePurgeProtection**: bool
* **enableSoftDelete**: bool
* **enabledForDeployment**: bool
* **enabledForDiskEncryption**: bool
* **enabledForTemplateDeployment**: bool
* **networkAcls**: NetworkRuleSet
* **privateEndpointConnections**: PrivateEndpointConnectionItem[] (ReadOnly)
* **sku**: Sku (Required)
* **tenantId**: string (Required)
* **vaultUri**: string

## NetworkRuleSet
### Properties
* **bypass**: 'AzureServices' | 'None'
* **defaultAction**: 'Allow' | 'Deny'
* **ipRules**: IPRule[]
* **virtualNetworkRules**: VirtualNetworkRule[]

## IPRule
### Properties
* **value**: string (Required)

## VirtualNetworkRule
### Properties
* **id**: string (Required)

## PrivateEndpointConnectionItem
### Properties
* **properties**: PrivateEndpointConnectionProperties

## Sku
### Properties
* **family**: string (Required)
* **name**: 'premium' | 'standard' (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

