# Microsoft.Management @ 2017-11-01-preview

## Microsoft.Management/managementGroups
### Properties
* **apiVersion**: '2017-11-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **displayName**: string (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **parentId**: string (WriteOnly)
* **properties**: ManagementGroupProperties (ReadOnly)
* **type**: 'Microsoft.Management/managementGroups' (ReadOnly, DeployTimeConstant)

## ManagementGroupProperties
### Properties
* **children**: ManagementGroupChildInfo[] (ReadOnly)
* **details**: ManagementGroupDetails (ReadOnly)
* **displayName**: string (ReadOnly)
* **tenantId**: string (ReadOnly)

## ManagementGroupChildInfo
### Properties
* **childId**: string (ReadOnly)
* **childType**: 'ManagementGroup' | 'Subscription' (ReadOnly)
* **children**: ManagementGroupChildInfo[] (ReadOnly)
* **displayName**: string (ReadOnly)

## ManagementGroupDetails
### Properties
* **parent**: ParentGroupInfo (ReadOnly)
* **updatedBy**: string (ReadOnly)
* **updatedTime**: string (ReadOnly)
* **version**: int (ReadOnly)

## ParentGroupInfo
### Properties
* **displayName**: string (ReadOnly)
* **parentId**: string (ReadOnly)

