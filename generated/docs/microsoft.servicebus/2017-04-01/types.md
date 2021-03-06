# Microsoft.ServiceBus @ 2017-04-01

## Microsoft.ServiceBus/namespaces/AuthorizationRules
### Properties
* **apiVersion**: '2017-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: schemas:1_properties
* **type**: 'Microsoft.ServiceBus/namespaces/AuthorizationRules' (ReadOnly, DeployTimeConstant)

## schemas:1_properties
### Properties
* **rights**: 'Listen' | 'Manage' | 'Send'[] (Required)

## Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs
### Properties
* **apiVersion**: '2017-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: schemas:14_properties
* **type**: 'Microsoft.ServiceBus/namespaces/disasterRecoveryConfigs' (ReadOnly, DeployTimeConstant)

## schemas:14_properties
### Properties
* **alternateName**: string
* **partnerNamespace**: string
* **pendingReplicationOperationsCount**: int (ReadOnly)
* **provisioningState**: 'Accepted' | 'Failed' | 'Succeeded' (ReadOnly)
* **role**: 'Primary' | 'PrimaryNotReplicating' | 'Secondary' (ReadOnly)

## Microsoft.ServiceBus/namespaces/migrationConfigurations
### Properties
* **apiVersion**: '2017-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: schemas:21_properties
* **type**: 'Microsoft.ServiceBus/namespaces/migrationConfigurations' (ReadOnly, DeployTimeConstant)

## schemas:21_properties
### Properties
* **migrationState**: string (ReadOnly)
* **pendingReplicationOperationsCount**: int (ReadOnly)
* **postMigrationName**: string (Required)
* **provisioningState**: string (ReadOnly)
* **targetNamespace**: string (Required)

## Microsoft.ServiceBus/namespaces/networkRuleSets
### Properties
* **apiVersion**: '2017-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: schemas:55_properties
* **type**: 'Microsoft.ServiceBus/namespaces/networkRuleSets' (ReadOnly, DeployTimeConstant)

## schemas:55_properties
### Properties
* **defaultAction**: 'Allow' | 'Deny'
* **ipRules**: NWRuleSetIpRules[]
* **virtualNetworkRules**: NWRuleSetVirtualNetworkRules[]

## NWRuleSetIpRules
### Properties
* **action**: 'Allow'
* **ipMask**: string

## NWRuleSetVirtualNetworkRules
### Properties
* **ignoreMissingVnetServiceEndpoint**: bool
* **subnet**: Subnet

## Subnet
### Properties
* **id**: string (Required)

## Microsoft.ServiceBus/namespaces/queues/authorizationRules
### Properties
* **apiVersion**: '2017-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: schemas:1_properties
* **type**: 'Microsoft.ServiceBus/namespaces/queues/authorizationRules' (ReadOnly, DeployTimeConstant)

## Microsoft.ServiceBus/namespaces/queues
### Properties
* **apiVersion**: '2017-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: SBQueueProperties
* **type**: 'Microsoft.ServiceBus/namespaces/queues' (ReadOnly, DeployTimeConstant)

## SBQueueProperties
### Properties
* **accessedAt**: string (ReadOnly)
* **autoDeleteOnIdle**: string
* **countDetails**: MessageCountDetails (ReadOnly)
* **createdAt**: string (ReadOnly)
* **deadLetteringOnMessageExpiration**: bool
* **defaultMessageTimeToLive**: string
* **duplicateDetectionHistoryTimeWindow**: string
* **enableBatchedOperations**: bool
* **enableExpress**: bool
* **enablePartitioning**: bool
* **forwardDeadLetteredMessagesTo**: string
* **forwardTo**: string
* **lockDuration**: string
* **maxDeliveryCount**: int
* **maxSizeInMegabytes**: int
* **messageCount**: int (ReadOnly)
* **requiresDuplicateDetection**: bool
* **requiresSession**: bool
* **sizeInBytes**: int (ReadOnly)
* **status**: 'Active' | 'Creating' | 'Deleting' | 'Disabled' | 'ReceiveDisabled' | 'Renaming' | 'Restoring' | 'SendDisabled' | 'Unknown'
* **updatedAt**: string (ReadOnly)

## MessageCountDetails
### Properties
* **activeMessageCount**: int (ReadOnly)
* **deadLetterMessageCount**: int (ReadOnly)
* **scheduledMessageCount**: int (ReadOnly)
* **transferDeadLetterMessageCount**: int (ReadOnly)
* **transferMessageCount**: int (ReadOnly)

## Microsoft.ServiceBus/namespaces/topics/authorizationRules
### Properties
* **apiVersion**: '2017-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: schemas:1_properties
* **type**: 'Microsoft.ServiceBus/namespaces/topics/authorizationRules' (ReadOnly, DeployTimeConstant)

## Microsoft.ServiceBus/namespaces/topics/subscriptions/rules
### Properties
* **apiVersion**: '2017-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: Ruleproperties
* **type**: 'Microsoft.ServiceBus/namespaces/topics/subscriptions/rules' (ReadOnly, DeployTimeConstant)

## Ruleproperties
### Properties
* **action**: Action
* **correlationFilter**: CorrelationFilter
* **filterType**: 'CorrelationFilter' | 'SqlFilter'
* **sqlFilter**: SqlFilter

## Action
### Properties
* **compatibilityLevel**: int
* **requiresPreprocessing**: bool
* **sqlExpression**: string

## CorrelationFilter
### Properties
* **contentType**: string
* **correlationId**: string
* **label**: string
* **messageId**: string
* **properties**: Dictionary<string,String>
* **replyTo**: string
* **replyToSessionId**: string
* **requiresPreprocessing**: bool
* **sessionId**: string
* **to**: string

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## SqlFilter
### Properties
* **compatibilityLevel**: int
* **requiresPreprocessing**: bool
* **sqlExpression**: string

## Microsoft.ServiceBus/namespaces/topics/subscriptions
### Properties
* **apiVersion**: '2017-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: SBSubscriptionProperties
* **type**: 'Microsoft.ServiceBus/namespaces/topics/subscriptions' (ReadOnly, DeployTimeConstant)

## SBSubscriptionProperties
### Properties
* **accessedAt**: string (ReadOnly)
* **autoDeleteOnIdle**: string
* **countDetails**: MessageCountDetails (ReadOnly)
* **createdAt**: string (ReadOnly)
* **deadLetteringOnFilterEvaluationExceptions**: bool
* **deadLetteringOnMessageExpiration**: bool
* **defaultMessageTimeToLive**: string
* **duplicateDetectionHistoryTimeWindow**: string
* **enableBatchedOperations**: bool
* **forwardDeadLetteredMessagesTo**: string
* **forwardTo**: string
* **lockDuration**: string
* **maxDeliveryCount**: int
* **messageCount**: int (ReadOnly)
* **requiresSession**: bool
* **status**: 'Active' | 'Creating' | 'Deleting' | 'Disabled' | 'ReceiveDisabled' | 'Renaming' | 'Restoring' | 'SendDisabled' | 'Unknown'
* **updatedAt**: string (ReadOnly)

## Microsoft.ServiceBus/namespaces/topics
### Properties
* **apiVersion**: '2017-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: SBTopicProperties
* **type**: 'Microsoft.ServiceBus/namespaces/topics' (ReadOnly, DeployTimeConstant)

## SBTopicProperties
### Properties
* **accessedAt**: string (ReadOnly)
* **autoDeleteOnIdle**: string
* **countDetails**: MessageCountDetails (ReadOnly)
* **createdAt**: string (ReadOnly)
* **defaultMessageTimeToLive**: string
* **duplicateDetectionHistoryTimeWindow**: string
* **enableBatchedOperations**: bool
* **enableExpress**: bool
* **enablePartitioning**: bool
* **maxSizeInMegabytes**: int
* **requiresDuplicateDetection**: bool
* **sizeInBytes**: int (ReadOnly)
* **status**: 'Active' | 'Creating' | 'Deleting' | 'Disabled' | 'ReceiveDisabled' | 'Renaming' | 'Restoring' | 'SendDisabled' | 'Unknown'
* **subscriptionCount**: int (ReadOnly)
* **supportOrdering**: bool
* **updatedAt**: string (ReadOnly)

## Microsoft.ServiceBus/namespaces
### Properties
* **apiVersion**: '2017-04-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: SBNamespaceProperties
* **sku**: SBSku
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.ServiceBus/namespaces' (ReadOnly, DeployTimeConstant)

## SBNamespaceProperties
### Properties
* **createdAt**: string (ReadOnly)
* **metricId**: string (ReadOnly)
* **provisioningState**: string (ReadOnly)
* **serviceBusEndpoint**: string (ReadOnly)
* **updatedAt**: string (ReadOnly)

## SBSku
### Properties
* **capacity**: int
* **name**: 'Basic' | 'Premium' | 'Standard' (Required)
* **tier**: 'Basic' | 'Premium' | 'Standard'

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

