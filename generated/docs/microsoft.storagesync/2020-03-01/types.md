# Microsoft.StorageSync @ 2020-03-01

## Microsoft.StorageSync/storageSyncServices/privateEndpointConnections
### Properties
* **apiVersion**: '2020-03-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: PrivateEndpointConnectionProperties
* **type**: 'Microsoft.StorageSync/storageSyncServices/privateEndpointConnections' (ReadOnly, DeployTimeConstant)

## PrivateEndpointConnectionProperties
### Properties
* **privateEndpoint**: PrivateEndpoint (ReadOnly)
* **privateLinkServiceConnectionState**: PrivateLinkServiceConnectionState (ReadOnly)
* **provisioningState**: 'Creating' | 'Deleting' | 'Failed' | 'Succeeded' (ReadOnly)

## PrivateEndpoint
### Properties
* **id**: string (ReadOnly)

## PrivateLinkServiceConnectionState
### Properties
* **actionsRequired**: string (ReadOnly)
* **description**: string (ReadOnly)
* **status**: 'Approved' | 'Pending' | 'Rejected' (ReadOnly)

## Microsoft.StorageSync/storageSyncServices/registeredServers
### Properties
* **apiVersion**: '2020-03-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: RegisteredServerCreateParametersProperties
* **type**: 'Microsoft.StorageSync/storageSyncServices/registeredServers' (ReadOnly, DeployTimeConstant)

## RegisteredServerCreateParametersProperties
### Properties
* **agentVersion**: string
* **clusterId**: string
* **clusterName**: string
* **discoveryEndpointUri**: string (ReadOnly)
* **friendlyName**: string
* **lastHeartBeat**: string
* **lastOperationName**: string (ReadOnly)
* **lastWorkflowId**: string (ReadOnly)
* **managementEndpointUri**: string (ReadOnly)
* **monitoringConfiguration**: string (ReadOnly)
* **monitoringEndpointUri**: string (ReadOnly)
* **provisioningState**: string (ReadOnly)
* **resourceLocation**: string (ReadOnly)
* **serverCertificate**: string
* **serverId**: string
* **serverManagementErrorCode**: int (ReadOnly)
* **serverOSVersion**: string
* **serverRole**: string
* **serviceLocation**: string (ReadOnly)
* **storageSyncServiceUid**: string (ReadOnly)

## Microsoft.StorageSync/storageSyncServices/syncGroups/cloudEndpoints
### Properties
* **apiVersion**: '2020-03-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: CloudEndpointCreateParametersProperties
* **type**: 'Microsoft.StorageSync/storageSyncServices/syncGroups/cloudEndpoints' (ReadOnly, DeployTimeConstant)

## CloudEndpointCreateParametersProperties
### Properties
* **azureFileShareName**: string
* **backupEnabled**: string (ReadOnly)
* **friendlyName**: string
* **lastOperationName**: string (ReadOnly)
* **lastWorkflowId**: string (ReadOnly)
* **partnershipId**: string (ReadOnly)
* **provisioningState**: string (ReadOnly)
* **storageAccountResourceId**: string
* **storageAccountTenantId**: string

## Microsoft.StorageSync/storageSyncServices/syncGroups/serverEndpoints
### Properties
* **apiVersion**: '2020-03-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: ServerEndpointCreateParametersProperties
* **type**: 'Microsoft.StorageSync/storageSyncServices/syncGroups/serverEndpoints' (ReadOnly, DeployTimeConstant)

## ServerEndpointCreateParametersProperties
### Properties
* **cloudTiering**: 'off' | 'on'
* **cloudTieringStatus**: ServerEndpointCloudTieringStatus (ReadOnly)
* **friendlyName**: string
* **initialDownloadPolicy**: 'AvoidTieredFiles' | 'NamespaceOnly' | 'NamespaceThenModifiedFiles'
* **lastOperationName**: string (ReadOnly)
* **lastWorkflowId**: string (ReadOnly)
* **localCacheMode**: 'DownloadNewAndModifiedFiles' | 'UpdateLocallyCachedFiles'
* **offlineDataTransfer**: 'off' | 'on'
* **offlineDataTransferShareName**: string
* **offlineDataTransferStorageAccountResourceId**: string (ReadOnly)
* **offlineDataTransferStorageAccountTenantId**: string (ReadOnly)
* **provisioningState**: string (ReadOnly)
* **recallStatus**: ServerEndpointRecallStatus (ReadOnly)
* **serverLocalPath**: string
* **serverResourceId**: string
* **syncStatus**: ServerEndpointSyncStatus (ReadOnly)
* **tierFilesOlderThanDays**: int
* **volumeFreeSpacePercent**: int

## ServerEndpointCloudTieringStatus
### Properties
* **cachePerformance**: CloudTieringCachePerformance (ReadOnly)
* **datePolicyStatus**: CloudTieringDatePolicyStatus (ReadOnly)
* **filesNotTiering**: CloudTieringFilesNotTiering (ReadOnly)
* **health**: 'Error' | 'Healthy' (ReadOnly)
* **healthLastUpdatedTimestamp**: string (ReadOnly)
* **lastCloudTieringResult**: int (ReadOnly)
* **lastSuccessTimestamp**: string (ReadOnly)
* **lastUpdatedTimestamp**: string (ReadOnly)
* **spaceSavings**: CloudTieringSpaceSavings (ReadOnly)
* **volumeFreeSpacePolicyStatus**: CloudTieringVolumeFreeSpacePolicyStatus (ReadOnly)

## CloudTieringCachePerformance
### Properties
* **cacheHitBytes**: int (ReadOnly)
* **cacheHitBytesPercent**: int (ReadOnly)
* **cacheMissBytes**: int (ReadOnly)
* **lastUpdatedTimestamp**: string (ReadOnly)

## CloudTieringDatePolicyStatus
### Properties
* **lastUpdatedTimestamp**: string (ReadOnly)
* **tieredFilesMostRecentAccessTimestamp**: string (ReadOnly)

## CloudTieringFilesNotTiering
### Properties
* **errors**: FilesNotTieringError[] (ReadOnly)
* **lastUpdatedTimestamp**: string (ReadOnly)
* **totalFileCount**: int (ReadOnly)

## FilesNotTieringError
### Properties
* **errorCode**: int (ReadOnly)
* **fileCount**: int (ReadOnly)

## CloudTieringSpaceSavings
### Properties
* **cachedSizeBytes**: int (ReadOnly)
* **lastUpdatedTimestamp**: string (ReadOnly)
* **spaceSavingsBytes**: int (ReadOnly)
* **spaceSavingsPercent**: int (ReadOnly)
* **totalSizeCloudBytes**: int (ReadOnly)
* **volumeSizeBytes**: int (ReadOnly)

## CloudTieringVolumeFreeSpacePolicyStatus
### Properties
* **currentVolumeFreeSpacePercent**: int (ReadOnly)
* **effectiveVolumeFreeSpacePolicy**: int (ReadOnly)
* **lastUpdatedTimestamp**: string (ReadOnly)

## ServerEndpointRecallStatus
### Properties
* **lastUpdatedTimestamp**: string (ReadOnly)
* **recallErrors**: ServerEndpointRecallError[] (ReadOnly)
* **totalRecallErrorsCount**: int (ReadOnly)

## ServerEndpointRecallError
### Properties
* **count**: int (ReadOnly)
* **errorCode**: int (ReadOnly)

## ServerEndpointSyncStatus
### Properties
* **combinedHealth**: 'Error' | 'Healthy' | 'NoActivity' | 'SyncBlockedForChangeDetectionPostRestore' | 'SyncBlockedForRestore' (ReadOnly)
* **downloadActivity**: ServerEndpointSyncActivityStatus (ReadOnly)
* **downloadHealth**: 'Error' | 'Healthy' | 'NoActivity' | 'SyncBlockedForChangeDetectionPostRestore' | 'SyncBlockedForRestore' (ReadOnly)
* **downloadStatus**: ServerEndpointSyncSessionStatus (ReadOnly)
* **lastUpdatedTimestamp**: string (ReadOnly)
* **offlineDataTransferStatus**: 'Complete' | 'InProgress' | 'NotRunning' | 'Stopping' (ReadOnly)
* **syncActivity**: 'Download' | 'Upload' | 'UploadAndDownload' (ReadOnly)
* **totalPersistentFilesNotSyncingCount**: int (ReadOnly)
* **uploadActivity**: ServerEndpointSyncActivityStatus (ReadOnly)
* **uploadHealth**: 'Error' | 'Healthy' | 'NoActivity' | 'SyncBlockedForChangeDetectionPostRestore' | 'SyncBlockedForRestore' (ReadOnly)
* **uploadStatus**: ServerEndpointSyncSessionStatus (ReadOnly)

## ServerEndpointSyncActivityStatus
### Properties
* **appliedBytes**: int (ReadOnly)
* **appliedItemCount**: int (ReadOnly)
* **perItemErrorCount**: int (ReadOnly)
* **timestamp**: string (ReadOnly)
* **totalBytes**: int (ReadOnly)
* **totalItemCount**: int (ReadOnly)

## ServerEndpointSyncSessionStatus
### Properties
* **filesNotSyncingErrors**: ServerEndpointFilesNotSyncingError[] (ReadOnly)
* **lastSyncPerItemErrorCount**: int (ReadOnly)
* **lastSyncResult**: int (ReadOnly)
* **lastSyncSuccessTimestamp**: string (ReadOnly)
* **lastSyncTimestamp**: string (ReadOnly)
* **persistentFilesNotSyncingCount**: int (ReadOnly)
* **transientFilesNotSyncingCount**: int (ReadOnly)

## ServerEndpointFilesNotSyncingError
### Properties
* **errorCode**: int (ReadOnly)
* **persistentCount**: int (ReadOnly)
* **transientCount**: int (ReadOnly)

## Microsoft.StorageSync/storageSyncServices/syncGroups
### Properties
* **apiVersion**: '2020-03-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: any
* **type**: 'Microsoft.StorageSync/storageSyncServices/syncGroups' (ReadOnly, DeployTimeConstant)

## Microsoft.StorageSync/storageSyncServices
### Properties
* **apiVersion**: '2020-03-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: StorageSyncServiceCreateParametersProperties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.StorageSync/storageSyncServices' (ReadOnly, DeployTimeConstant)

## StorageSyncServiceCreateParametersProperties
### Properties
* **incomingTrafficPolicy**: 'AllowAllTraffic' | 'AllowVirtualNetworksOnly'
* **lastOperationName**: string (ReadOnly)
* **lastWorkflowId**: string (ReadOnly)
* **privateEndpointConnections**: PrivateEndpointConnection[] (ReadOnly)
* **provisioningState**: string (ReadOnly)
* **storageSyncServiceStatus**: int (ReadOnly)
* **storageSyncServiceUid**: string (ReadOnly)

## PrivateEndpointConnection
### Properties
* **id**: string (ReadOnly)
* **name**: string (ReadOnly)
* **properties**: PrivateEndpointConnectionProperties (ReadOnly)
* **type**: string (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

