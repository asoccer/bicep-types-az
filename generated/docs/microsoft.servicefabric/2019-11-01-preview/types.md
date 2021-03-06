# Microsoft.ServiceFabric @ 2019-11-01-preview

## Microsoft.ServiceFabric/clusters/applicationTypes/versions
### Properties
* **apiVersion**: '2019-11-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string (ReadOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ApplicationTypeVersionResourceProperties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.ServiceFabric/clusters/applicationTypes/versions' (ReadOnly, DeployTimeConstant)

## ApplicationTypeVersionResourceProperties
### Properties
* **appPackageUrl**: string (Required)
* **defaultParameterList**: Dictionary<string,String> (ReadOnly)
* **provisioningState**: string (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.ServiceFabric/clusters/applicationTypes
### Properties
* **apiVersion**: '2019-11-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string (ReadOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ApplicationTypeResourceProperties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.ServiceFabric/clusters/applicationTypes' (ReadOnly, DeployTimeConstant)

## ApplicationTypeResourceProperties
### Properties
* **provisioningState**: string (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.ServiceFabric/clusters/applications/services
### Properties
* **apiVersion**: '2019-11-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string (ReadOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ServiceResourceProperties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.ServiceFabric/clusters/applications/services' (ReadOnly, DeployTimeConstant)

## ServiceResourceProperties
* **Discriminator**: serviceKind
### Base Properties
* **correlationScheme**: ServiceCorrelationDescription[]
* **defaultMoveCost**: 'High' | 'Low' | 'Medium' | 'Zero'
* **partitionDescription**: PartitionSchemeDescription
* **placementConstraints**: string
* **provisioningState**: string (ReadOnly)
* **serviceDnsName**: string
* **serviceLoadMetrics**: ServiceLoadMetricDescription[]
* **servicePackageActivationMode**: 'ExclusiveProcess' | 'SharedProcess'
* **servicePlacementPolicies**: ServicePlacementPolicyDescription[]
* **serviceTypeName**: string
### Stateful
#### Properties
* **hasPersistedState**: bool
* **minReplicaSetSize**: int
* **quorumLossWaitDuration**: string
* **replicaRestartWaitDuration**: string
* **serviceKind**: 'Stateful' (Required)
* **standByReplicaKeepDuration**: string
* **targetReplicaSetSize**: int

### Stateless
#### Properties
* **instanceCloseDelayDuration**: string
* **instanceCount**: int
* **serviceKind**: 'Stateless' (Required)


## ServiceCorrelationDescription
### Properties
* **scheme**: 'Affinity' | 'AlignedAffinity' | 'Invalid' | 'NonAlignedAffinity' (Required)
* **serviceName**: string (Required)

## PartitionSchemeDescription
* **Discriminator**: partitionScheme
### Base Properties
### Named
#### Properties
* **count**: int (Required)
* **names**: string[] (Required)
* **partitionScheme**: 'Named' (Required)

### Singleton
#### Properties
* **partitionScheme**: 'Singleton' (Required)

### UniformInt64Range
#### Properties
* **count**: int (Required)
* **highKey**: string (Required)
* **lowKey**: string (Required)
* **partitionScheme**: 'UniformInt64Range' (Required)


## Named
### Properties
* **count**: int (Required)
* **names**: string[] (Required)
* **partitionScheme**: 'Named' (Required)

## Singleton
### Properties
* **partitionScheme**: 'Singleton' (Required)

## UniformInt64Range
### Properties
* **count**: int (Required)
* **highKey**: string (Required)
* **lowKey**: string (Required)
* **partitionScheme**: 'UniformInt64Range' (Required)

## ServiceLoadMetricDescription
### Properties
* **defaultLoad**: int
* **name**: string (Required)
* **primaryDefaultLoad**: int
* **secondaryDefaultLoad**: int
* **weight**: 'High' | 'Low' | 'Medium' | 'Zero'

## ServicePlacementPolicyDescription
* **Discriminator**: type
### Base Properties

## Stateful
### Properties
* **hasPersistedState**: bool
* **minReplicaSetSize**: int
* **quorumLossWaitDuration**: string
* **replicaRestartWaitDuration**: string
* **serviceKind**: 'Stateful' (Required)
* **standByReplicaKeepDuration**: string
* **targetReplicaSetSize**: int

## Stateless
### Properties
* **instanceCloseDelayDuration**: string
* **instanceCount**: int
* **serviceKind**: 'Stateless' (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.ServiceFabric/clusters/applications
### Properties
* **apiVersion**: '2019-11-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string (ReadOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **identity**: ManagedIdentity
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ApplicationResourceProperties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.ServiceFabric/clusters/applications' (ReadOnly, DeployTimeConstant)

## ManagedIdentity
### Properties
* **principalId**: string (ReadOnly)
* **tenantId**: string (ReadOnly)
* **type**: 'None' | 'SystemAssigned' | 'SystemAssigned, UserAssigned' | 'UserAssigned'
* **userAssignedIdentities**: Dictionary<string,UserAssignedIdentity>

## Dictionary<string,UserAssignedIdentity>
### Additional Properties
* **Additional Properties Type**: UserAssignedIdentity

## UserAssignedIdentity
### Properties
* **clientId**: string (ReadOnly)
* **principalId**: string (ReadOnly)

## ApplicationResourceProperties
### Properties
* **managedIdentities**: ApplicationUserAssignedIdentity[]
* **maximumNodes**: int
* **metrics**: ApplicationMetricDescription[]
* **minimumNodes**: int
* **parameters**: Dictionary<string,String>
* **provisioningState**: string (ReadOnly)
* **removeApplicationCapacity**: bool
* **typeName**: string
* **typeVersion**: string
* **upgradePolicy**: ApplicationUpgradePolicy

## ApplicationUserAssignedIdentity
### Properties
* **name**: string (Required)
* **principalId**: string (Required)

## ApplicationMetricDescription
### Properties
* **maximumCapacity**: int
* **name**: string
* **reservationCapacity**: int
* **totalApplicationCapacity**: int

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## ApplicationUpgradePolicy
### Properties
* **applicationHealthPolicy**: ArmApplicationHealthPolicy
* **forceRestart**: bool
* **rollingUpgradeMonitoringPolicy**: ArmRollingUpgradeMonitoringPolicy
* **upgradeMode**: 'Invalid' | 'Monitored' | 'UnmonitoredAuto' | 'UnmonitoredManual'
* **upgradeReplicaSetCheckTimeout**: string

## ArmApplicationHealthPolicy
### Properties
* **considerWarningAsError**: bool
* **defaultServiceTypeHealthPolicy**: ArmServiceTypeHealthPolicy
* **maxPercentUnhealthyDeployedApplications**: int
* **serviceTypeHealthPolicyMap**: Dictionary<string,ArmServiceTypeHealthPolicy>

## ArmServiceTypeHealthPolicy
### Properties
* **maxPercentUnhealthyPartitionsPerService**: int
* **maxPercentUnhealthyReplicasPerPartition**: int
* **maxPercentUnhealthyServices**: int

## Dictionary<string,ArmServiceTypeHealthPolicy>
### Additional Properties
* **Additional Properties Type**: ArmServiceTypeHealthPolicy

## ArmRollingUpgradeMonitoringPolicy
### Properties
* **failureAction**: 'Manual' | 'Rollback'
* **healthCheckRetryTimeout**: string
* **healthCheckStableDuration**: string
* **healthCheckWaitDuration**: string
* **upgradeDomainTimeout**: string
* **upgradeTimeout**: string

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.ServiceFabric/clusters
### Properties
* **apiVersion**: '2019-11-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string (ReadOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: ClusterProperties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.ServiceFabric/clusters' (ReadOnly, DeployTimeConstant)

## ClusterProperties
### Properties
* **addOnFeatures**: 'BackupRestoreService' | 'DnsService' | 'RepairManager' | 'ResourceMonitorService'[]
* **applicationTypeVersionsCleanupPolicy**: ApplicationTypeVersionsCleanupPolicy
* **availableClusterVersions**: ClusterVersionDetails[] (ReadOnly)
* **azureActiveDirectory**: AzureActiveDirectory
* **certificate**: CertificateDescription
* **certificateCommonNames**: ServerCertificateCommonNames
* **clientCertificateCommonNames**: ClientCertificateCommonName[]
* **clientCertificateThumbprints**: ClientCertificateThumbprint[]
* **clusterCodeVersion**: string
* **clusterEndpoint**: string (ReadOnly)
* **clusterId**: string (ReadOnly)
* **clusterState**: 'AutoScale' | 'BaselineUpgrade' | 'Deploying' | 'EnforcingClusterVersion' | 'Ready' | 'UpdatingInfrastructure' | 'UpdatingUserCertificate' | 'UpdatingUserConfiguration' | 'UpgradeServiceUnreachable' | 'WaitingForNodes' (ReadOnly)
* **diagnosticsStorageAccountConfig**: DiagnosticsStorageAccountConfig
* **eventStoreServiceEnabled**: bool
* **fabricSettings**: SettingsSectionDescription[]
* **managementEndpoint**: string (Required)
* **nodeTypes**: NodeTypeDescription[] (Required)
* **provisioningState**: 'Canceled' | 'Failed' | 'Succeeded' | 'Updating' (ReadOnly)
* **reliabilityLevel**: 'Bronze' | 'Gold' | 'None' | 'Platinum' | 'Silver'
* **reverseProxyCertificate**: CertificateDescription
* **reverseProxyCertificateCommonNames**: ServerCertificateCommonNames
* **upgradeDescription**: ClusterUpgradePolicy
* **upgradeMode**: 'Automatic' | 'Manual'
* **vmImage**: string

## ApplicationTypeVersionsCleanupPolicy
### Properties
* **maxUnusedVersionsToKeep**: int (Required)

## ClusterVersionDetails
### Properties
* **codeVersion**: string
* **environment**: 'Linux' | 'Windows'
* **supportExpiryUtc**: string

## AzureActiveDirectory
### Properties
* **clientApplication**: string
* **clusterApplication**: string
* **tenantId**: string

## CertificateDescription
### Properties
* **thumbprint**: string (Required)
* **thumbprintSecondary**: string
* **x509StoreName**: 'AddressBook' | 'AuthRoot' | 'CertificateAuthority' | 'Disallowed' | 'My' | 'Root' | 'TrustedPeople' | 'TrustedPublisher'

## ServerCertificateCommonNames
### Properties
* **commonNames**: ServerCertificateCommonName[]
* **x509StoreName**: 'AddressBook' | 'AuthRoot' | 'CertificateAuthority' | 'Disallowed' | 'My' | 'Root' | 'TrustedPeople' | 'TrustedPublisher'

## ServerCertificateCommonName
### Properties
* **certificateCommonName**: string (Required)
* **certificateIssuerThumbprint**: string (Required)

## ClientCertificateCommonName
### Properties
* **certificateCommonName**: string (Required)
* **certificateIssuerThumbprint**: string (Required)
* **isAdmin**: bool (Required)

## ClientCertificateThumbprint
### Properties
* **certificateThumbprint**: string (Required)
* **isAdmin**: bool (Required)

## DiagnosticsStorageAccountConfig
### Properties
* **blobEndpoint**: string (Required)
* **protectedAccountKeyName**: string (Required)
* **protectedAccountKeyName2**: string
* **queueEndpoint**: string (Required)
* **storageAccountName**: string (Required)
* **tableEndpoint**: string (Required)

## SettingsSectionDescription
### Properties
* **name**: string (Required)
* **parameters**: SettingsParameterDescription[] (Required)

## SettingsParameterDescription
### Properties
* **name**: string (Required)
* **value**: string (Required)

## NodeTypeDescription
### Properties
* **applicationPorts**: EndpointRangeDescription
* **capacities**: Dictionary<string,String>
* **clientConnectionEndpointPort**: int (Required)
* **durabilityLevel**: 'Bronze' | 'Gold' | 'Silver'
* **ephemeralPorts**: EndpointRangeDescription
* **httpGatewayEndpointPort**: int (Required)
* **isPrimary**: bool (Required)
* **name**: string (Required)
* **placementProperties**: Dictionary<string,String>
* **reverseProxyEndpointPort**: int
* **vmInstanceCount**: int (Required)

## EndpointRangeDescription
### Properties
* **endPort**: int (Required)
* **startPort**: int (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## ClusterUpgradePolicy
### Properties
* **deltaHealthPolicy**: ClusterUpgradeDeltaHealthPolicy
* **forceRestart**: bool
* **healthCheckRetryTimeout**: string (Required)
* **healthCheckStableDuration**: string (Required)
* **healthCheckWaitDuration**: string (Required)
* **healthPolicy**: ClusterHealthPolicy (Required)
* **upgradeDomainTimeout**: string (Required)
* **upgradeReplicaSetCheckTimeout**: string (Required)
* **upgradeTimeout**: string (Required)

## ClusterUpgradeDeltaHealthPolicy
### Properties
* **applicationDeltaHealthPolicies**: Dictionary<string,ApplicationDeltaHealthPolicy>
* **maxPercentDeltaUnhealthyApplications**: int (Required)
* **maxPercentDeltaUnhealthyNodes**: int (Required)
* **maxPercentUpgradeDomainDeltaUnhealthyNodes**: int (Required)

## Dictionary<string,ApplicationDeltaHealthPolicy>
### Additional Properties
* **Additional Properties Type**: ApplicationDeltaHealthPolicy

## ApplicationDeltaHealthPolicy
### Properties
* **defaultServiceTypeDeltaHealthPolicy**: ServiceTypeDeltaHealthPolicy
* **serviceTypeDeltaHealthPolicies**: Dictionary<string,ServiceTypeDeltaHealthPolicy>

## ServiceTypeDeltaHealthPolicy
### Properties
* **maxPercentDeltaUnhealthyServices**: int

## Dictionary<string,ServiceTypeDeltaHealthPolicy>
### Additional Properties
* **Additional Properties Type**: ServiceTypeDeltaHealthPolicy

## ClusterHealthPolicy
### Properties
* **applicationHealthPolicies**: Dictionary<string,ApplicationHealthPolicy>
* **maxPercentUnhealthyApplications**: int
* **maxPercentUnhealthyNodes**: int

## Dictionary<string,ApplicationHealthPolicy>
### Additional Properties
* **Additional Properties Type**: ApplicationHealthPolicy

## ApplicationHealthPolicy
### Properties
* **defaultServiceTypeHealthPolicy**: ServiceTypeHealthPolicy
* **serviceTypeHealthPolicies**: Dictionary<string,ServiceTypeHealthPolicy>

## ServiceTypeHealthPolicy
### Properties
* **maxPercentUnhealthyServices**: int

## Dictionary<string,ServiceTypeHealthPolicy>
### Additional Properties
* **Additional Properties Type**: ServiceTypeHealthPolicy

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

