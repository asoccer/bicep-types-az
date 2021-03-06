# Microsoft.DocumentDB @ 2020-04-01

## Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/tables/throughputSettings
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ThroughputSettingsUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/tables/throughputSettings' (ReadOnly, DeployTimeConstant)

## ThroughputSettingsUpdateProperties
### Properties
* **resource**: ThroughputSettingsResource (Required)

## ThroughputSettingsResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **autoscaleSettings**: AutoscaleSettingsResource (WriteOnly)
* **id**: string (ReadOnly)
* **minimumThroughput**: string (ReadOnly, WriteOnly)
* **offerReplacePending**: string (ReadOnly, WriteOnly)
* **throughput**: int (WriteOnly)

## AutoscaleSettingsResource
### Properties
* **autoUpgradePolicy**: AutoUpgradePolicyResource (WriteOnly)
* **maxThroughput**: int (Required, WriteOnly)
* **targetMaxThroughput**: int (ReadOnly, WriteOnly)

## AutoUpgradePolicyResource
### Properties
* **throughputPolicy**: ThroughputPolicyResource (WriteOnly)

## ThroughputPolicyResource
### Properties
* **incrementPercent**: int (WriteOnly)
* **isEnabled**: bool (WriteOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/tables
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: CassandraTableCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/tables' (ReadOnly, DeployTimeConstant)

## CassandraTableCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required)
* **resource**: CassandraTableResource (Required)

## CreateUpdateOptions
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **autoscaleSettings**: AutoscaleSettings (WriteOnly)
* **id**: string (ReadOnly)
* **throughput**: int (WriteOnly)

## AutoscaleSettings
### Properties
* **maxThroughput**: int (WriteOnly)

## CassandraTableResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **analyticalStorageTtl**: int (WriteOnly)
* **defaultTtl**: int (WriteOnly)
* **id**: string (Required)
* **schema**: CassandraSchema (WriteOnly)

## CassandraSchema
### Properties
* **clusterKeys**: ClusterKey[] (WriteOnly)
* **columns**: Column[] (WriteOnly)
* **partitionKeys**: CassandraPartitionKey[] (WriteOnly)

## ClusterKey
### Properties
* **name**: string (WriteOnly)
* **orderBy**: string (WriteOnly)

## Column
### Properties
* **name**: string (WriteOnly)
* **type**: string (WriteOnly)

## CassandraPartitionKey
### Properties
* **name**: string (WriteOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/throughputSettings
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ThroughputSettingsUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces/throughputSettings' (ReadOnly, DeployTimeConstant)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: CassandraKeyspaceCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/cassandraKeyspaces' (ReadOnly, DeployTimeConstant)

## CassandraKeyspaceCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required)
* **resource**: CassandraKeyspaceResource (Required)

## CassandraKeyspaceResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **id**: string (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/gremlinDatabases/graphs/throughputSettings
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ThroughputSettingsUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/gremlinDatabases/graphs/throughputSettings' (ReadOnly, DeployTimeConstant)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/gremlinDatabases/graphs
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: GremlinGraphCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/gremlinDatabases/graphs' (ReadOnly, DeployTimeConstant)

## GremlinGraphCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required)
* **resource**: GremlinGraphResource (Required)

## GremlinGraphResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **conflictResolutionPolicy**: ConflictResolutionPolicy (WriteOnly)
* **defaultTtl**: int (WriteOnly)
* **id**: string (Required)
* **indexingPolicy**: IndexingPolicy (WriteOnly)
* **partitionKey**: ContainerPartitionKey (WriteOnly)
* **uniqueKeyPolicy**: UniqueKeyPolicy (WriteOnly)

## ConflictResolutionPolicy
### Properties
* **conflictResolutionPath**: string (WriteOnly)
* **conflictResolutionProcedure**: string (WriteOnly)
* **mode**: 'Custom' | 'LastWriterWins' (WriteOnly)

## IndexingPolicy
### Properties
* **automatic**: bool (WriteOnly)
* **compositeIndexes**: CompositePath[][] (WriteOnly)
* **excludedPaths**: ExcludedPath[] (WriteOnly)
* **includedPaths**: IncludedPath[] (WriteOnly)
* **indexingMode**: 'Consistent' | 'Lazy' | 'None' (WriteOnly)
* **spatialIndexes**: SpatialSpec[] (WriteOnly)

## CompositePath
### Properties
* **order**: 'Ascending' | 'Descending' (WriteOnly)
* **path**: string (WriteOnly)

## ExcludedPath
### Properties
* **path**: string (WriteOnly)

## IncludedPath
### Properties
* **indexes**: Indexes[] (WriteOnly)
* **path**: string (WriteOnly)

## Indexes
### Properties
* **dataType**: 'LineString' | 'MultiPolygon' | 'Number' | 'Point' | 'Polygon' | 'String' (WriteOnly)
* **kind**: 'Hash' | 'Range' | 'Spatial' (WriteOnly)
* **precision**: int (WriteOnly)

## SpatialSpec
### Properties
* **path**: string (WriteOnly)
* **types**: 'LineString' | 'MultiPolygon' | 'Point' | 'Polygon'[] (WriteOnly)

## ContainerPartitionKey
### Properties
* **kind**: 'Hash' | 'Range' (WriteOnly)
* **paths**: string[] (WriteOnly)
* **version**: int (WriteOnly)

## UniqueKeyPolicy
### Properties
* **uniqueKeys**: UniqueKey[] (WriteOnly)

## UniqueKey
### Properties
* **paths**: string[] (WriteOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/gremlinDatabases/throughputSettings
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ThroughputSettingsUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/gremlinDatabases/throughputSettings' (ReadOnly, DeployTimeConstant)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/gremlinDatabases
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: GremlinDatabaseCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/gremlinDatabases' (ReadOnly, DeployTimeConstant)

## GremlinDatabaseCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required)
* **resource**: GremlinDatabaseResource (Required)

## GremlinDatabaseResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **id**: string (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/mongodbDatabases/collections/throughputSettings
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ThroughputSettingsUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/mongodbDatabases/collections/throughputSettings' (ReadOnly, DeployTimeConstant)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/mongodbDatabases/collections
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: MongoDBCollectionCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/mongodbDatabases/collections' (ReadOnly, DeployTimeConstant)

## MongoDBCollectionCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required)
* **resource**: MongoDBCollectionResource (Required)

## MongoDBCollectionResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **analyticalStorageTtl**: int (WriteOnly)
* **id**: string (Required)
* **indexes**: MongoIndex[] (WriteOnly)
* **shardKey**: Dictionary<string,String> (WriteOnly)

## MongoIndex
### Properties
* **key**: MongoIndexKeys (WriteOnly)
* **options**: MongoIndexOptions (WriteOnly)

## MongoIndexKeys
### Properties
* **keys**: string[] (WriteOnly)

## MongoIndexOptions
### Properties
* **expireAfterSeconds**: int (WriteOnly)
* **unique**: bool (WriteOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/mongodbDatabases/throughputSettings
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ThroughputSettingsUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/mongodbDatabases/throughputSettings' (ReadOnly, DeployTimeConstant)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/mongodbDatabases
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: MongoDBDatabaseCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/mongodbDatabases' (ReadOnly, DeployTimeConstant)

## MongoDBDatabaseCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required)
* **resource**: MongoDBDatabaseResource (Required)

## MongoDBDatabaseResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **id**: string (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/notebookWorkspaces
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: NotebookWorkspaceProperties (ReadOnly)
* **type**: 'Microsoft.DocumentDB/databaseAccounts/notebookWorkspaces' (ReadOnly, DeployTimeConstant)

## NotebookWorkspaceProperties
### Properties
* **notebookServerEndpoint**: string (ReadOnly)
* **status**: string (ReadOnly)

## Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/storedProcedures
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: SqlStoredProcedureCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/storedProcedures' (ReadOnly, DeployTimeConstant)

## SqlStoredProcedureCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required, WriteOnly)
* **resource**: SqlStoredProcedureResource (Required)

## SqlStoredProcedureResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **body**: string (WriteOnly)
* **id**: string (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/throughputSettings
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ThroughputSettingsUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/throughputSettings' (ReadOnly, DeployTimeConstant)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/triggers
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: SqlTriggerCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/triggers' (ReadOnly, DeployTimeConstant)

## SqlTriggerCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required, WriteOnly)
* **resource**: SqlTriggerResource (Required)

## SqlTriggerResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **body**: string (WriteOnly)
* **id**: string (Required)
* **triggerOperation**: 'All' | 'Create' | 'Delete' | 'Replace' | 'Update' (WriteOnly)
* **triggerType**: 'Post' | 'Pre' (WriteOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/userDefinedFunctions
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: SqlUserDefinedFunctionCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers/userDefinedFunctions' (ReadOnly, DeployTimeConstant)

## SqlUserDefinedFunctionCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required, WriteOnly)
* **resource**: SqlUserDefinedFunctionResource (Required)

## SqlUserDefinedFunctionResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **body**: string (WriteOnly)
* **id**: string (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: SqlContainerCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers' (ReadOnly, DeployTimeConstant)

## SqlContainerCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required)
* **resource**: SqlContainerResource (Required)

## SqlContainerResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **analyticalStorageTtl**: int (WriteOnly)
* **conflictResolutionPolicy**: ConflictResolutionPolicy (WriteOnly)
* **defaultTtl**: int (WriteOnly)
* **id**: string (Required)
* **indexingPolicy**: IndexingPolicy (WriteOnly)
* **partitionKey**: ContainerPartitionKey (WriteOnly)
* **uniqueKeyPolicy**: UniqueKeyPolicy (WriteOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/sqlDatabases/throughputSettings
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ThroughputSettingsUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/sqlDatabases/throughputSettings' (ReadOnly, DeployTimeConstant)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/sqlDatabases
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: SqlDatabaseCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/sqlDatabases' (ReadOnly, DeployTimeConstant)

## SqlDatabaseCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required)
* **resource**: SqlDatabaseResource (Required)

## SqlDatabaseResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **id**: string (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/tables/throughputSettings
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ThroughputSettingsUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/tables/throughputSettings' (ReadOnly, DeployTimeConstant)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts/tables
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: TableCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts/tables' (ReadOnly, DeployTimeConstant)

## TableCreateUpdateProperties
### Properties
* **options**: CreateUpdateOptions (Required)
* **resource**: TableResource (Required)

## TableResource
### Properties
* **_colls**: string (ReadOnly)
* **_etag**: string (ReadOnly)
* **_rid**: string (ReadOnly)
* **_ts**: any (ReadOnly)
* **_users**: string (ReadOnly)
* **id**: string (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.DocumentDB/databaseAccounts
### Properties
* **apiVersion**: '2020-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **kind**: 'GlobalDocumentDB' | 'MongoDB' | 'Parse'
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: DatabaseAccountCreateUpdateProperties (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DocumentDB/databaseAccounts' (ReadOnly, DeployTimeConstant)

## DatabaseAccountCreateUpdateProperties
### Properties
* **apiProperties**: ApiProperties
* **capabilities**: Capability[]
* **connectorOffer**: 'Small'
* **consistencyPolicy**: ConsistencyPolicy
* **cors**: CorsPolicy[]
* **databaseAccountOfferType**: string (Required)
* **disableKeyBasedMetadataWriteAccess**: bool
* **documentEndpoint**: string (ReadOnly)
* **enableAnalyticalStorage**: bool
* **enableAutomaticFailover**: bool
* **enableCassandraConnector**: bool
* **enableFreeTier**: bool
* **enableMultipleWriteLocations**: bool
* **failoverPolicies**: FailoverPolicy[] (ReadOnly)
* **ipRules**: IpAddressOrRange[]
* **isVirtualNetworkFilterEnabled**: bool
* **keyVaultKeyUri**: string
* **locations**: Location[] (Required)
* **privateEndpointConnections**: PrivateEndpointConnection[] (ReadOnly)
* **provisioningState**: string (ReadOnly)
* **publicNetworkAccess**: 'Disabled' | 'Enabled'
* **readLocations**: Location[] (ReadOnly)
* **virtualNetworkRules**: VirtualNetworkRule[]
* **writeLocations**: Location[] (ReadOnly)

## ApiProperties
### Properties
* **serverVersion**: '3.2' | '3.6'

## Capability
### Properties
* **name**: string

## ConsistencyPolicy
### Properties
* **defaultConsistencyLevel**: 'BoundedStaleness' | 'ConsistentPrefix' | 'Eventual' | 'Session' | 'Strong' (Required)
* **maxIntervalInSeconds**: int
* **maxStalenessPrefix**: int

## CorsPolicy
### Properties
* **allowedHeaders**: string
* **allowedMethods**: string
* **allowedOrigins**: string (Required)
* **exposedHeaders**: string
* **maxAgeInSeconds**: int

## FailoverPolicy
### Properties
* **failoverPriority**: int (ReadOnly)
* **id**: string (ReadOnly)
* **locationName**: string (ReadOnly)

## IpAddressOrRange
### Properties
* **ipAddressOrRange**: string

## Location
### Properties
* **documentEndpoint**: string (ReadOnly)
* **failoverPriority**: int
* **id**: string (ReadOnly)
* **isZoneRedundant**: bool
* **locationName**: string
* **provisioningState**: string

## PrivateEndpointConnection
### Properties
* **id**: string (ReadOnly)
* **name**: string (ReadOnly)
* **properties**: PrivateEndpointConnectionProperties (ReadOnly)
* **type**: string (ReadOnly)

## PrivateEndpointConnectionProperties
### Properties
* **privateEndpoint**: PrivateEndpointProperty (ReadOnly)
* **privateLinkServiceConnectionState**: PrivateLinkServiceConnectionStateProperty (ReadOnly)

## PrivateEndpointProperty
### Properties
* **id**: string (ReadOnly)

## PrivateLinkServiceConnectionStateProperty
### Properties
* **actionsRequired**: string (ReadOnly)
* **status**: string (ReadOnly)

## VirtualNetworkRule
### Properties
* **id**: string
* **ignoreMissingVNetServiceEndpoint**: bool

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

