# Microsoft.StorageCache @ 2020-03-01

## Microsoft.StorageCache/caches/storageTargets
### Properties
* **apiVersion**: '2020-03-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: StorageTargetProperties
* **type**: 'Microsoft.StorageCache/caches/storageTargets' (ReadOnly, DeployTimeConstant)

## StorageTargetProperties
* **Discriminator**: targetType
### Base Properties
* **clfs**: ClfsTarget
* **junctions**: NamespaceJunction[]
* **nfs3**: Nfs3Target
* **provisioningState**: 'Cancelled' | 'Creating' | 'Deleting' | 'Failed' | 'Succeeded' | 'Updating'
* **unknown**: UnknownTarget
### clfs
#### Properties
* **targetType**: 'clfs' (Required)

### nfs3
#### Properties
* **targetType**: 'nfs3' (Required)

### unknown
#### Properties
* **targetType**: 'unknown' (Required)


## ClfsTarget
### Properties
* **target**: string

## NamespaceJunction
### Properties
* **namespacePath**: string
* **nfsExport**: string
* **targetPath**: string

## Nfs3Target
### Properties
* **target**: string
* **usageModel**: string

## UnknownTarget
### Properties
* **unknownMap**: Dictionary<string,String>

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## clfs
### Properties
* **targetType**: 'clfs' (Required)

## nfs3
### Properties
* **targetType**: 'nfs3' (Required)

## unknown
### Properties
* **targetType**: 'unknown' (Required)

## Microsoft.StorageCache/caches
### Properties
* **apiVersion**: '2020-03-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **identity**: CacheIdentity
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: schemas:6_properties
* **sku**: schemas:6_sku
* **tags**: any
* **type**: 'Microsoft.StorageCache/caches' (ReadOnly, DeployTimeConstant)

## CacheIdentity
### Properties
* **principalId**: string (ReadOnly)
* **tenantId**: string (ReadOnly)
* **type**: 'None' | 'SystemAssigned'

## schemas:6_properties
### Properties
* **cacheSizeGB**: int
* **encryptionSettings**: CacheEncryptionSettings
* **health**: CacheHealth (ReadOnly)
* **mountAddresses**: string[] (ReadOnly)
* **networkSettings**: CacheNetworkSettings
* **provisioningState**: 'Cancelled' | 'Creating' | 'Deleting' | 'Failed' | 'Succeeded' | 'Updating'
* **securitySettings**: CacheSecuritySettings
* **subnet**: string
* **upgradeStatus**: CacheUpgradeStatus

## CacheEncryptionSettings
### Properties
* **keyEncryptionKey**: KeyVaultKeyReference

## KeyVaultKeyReference
### Properties
* **keyUrl**: string (Required)
* **sourceVault**: schemas:11_sourceVault (Required)

## schemas:11_sourceVault
### Properties
* **id**: string

## CacheHealth
### Properties
* **state**: 'Degraded' | 'Down' | 'Flushing' | 'Healthy' | 'Stopped' | 'Stopping' | 'Transitioning' | 'Unknown' | 'Upgrading'
* **statusDescription**: string

## CacheNetworkSettings
### Properties
* **mtu**: int
* **utilityAddresses**: string[] (ReadOnly)

## CacheSecuritySettings
### Properties
* **rootSquash**: bool

## CacheUpgradeStatus
### Properties
* **currentFirmwareVersion**: string (ReadOnly)
* **firmwareUpdateDeadline**: string (ReadOnly)
* **firmwareUpdateStatus**: 'available' | 'unavailable' (ReadOnly)
* **lastFirmwareUpdate**: string (ReadOnly)
* **pendingFirmwareVersion**: string (ReadOnly)

## schemas:6_sku
### Properties
* **name**: string

