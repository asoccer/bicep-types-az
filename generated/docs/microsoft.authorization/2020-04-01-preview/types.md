# Microsoft.Authorization @ 2020-04-01-preview

## Microsoft.Authorization/roleAssignments
### Properties
* **apiVersion**: '2020-04-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: RoleAssignmentProperties (Required)
* **type**: 'Microsoft.Authorization/roleAssignments' (ReadOnly, DeployTimeConstant)

## RoleAssignmentProperties
### Properties
* **canDelegate**: bool
* **condition**: string
* **conditionVersion**: string
* **description**: string
* **principalId**: string (Required)
* **principalType**: 'Application' | 'DirectoryObjectOrGroup' | 'DirectoryRoleTemplate' | 'Everyone' | 'ForeignGroup' | 'Group' | 'MSI' | 'ServicePrincipal' | 'Unknown' | 'User'
* **roleDefinitionId**: string (Required)
* **scope**: string (ReadOnly)

