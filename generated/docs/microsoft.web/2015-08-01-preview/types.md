# Microsoft.Web @ 2015-08-01-preview

## Microsoft.Web/connections
### Properties
* **apiVersion**: '2015-08-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **kind**: string
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: schemas:1_properties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.Web/connections' (ReadOnly, DeployTimeConstant)

## schemas:1_properties
### Properties
* **apiDefinitionUrl**: string
* **backendService**: BackendServiceDefinition
* **capabilities**: string[]
* **changedTime**: string
* **connectionParameters**: Dictionary<string,ConnectionParameter>
* **createdTime**: string
* **generalInformation**: GeneralApiInformation
* **metadata**: any
* **name**: string
* **path**: string
* **policies**: ApiPolicies
* **protocols**: string[]
* **runtimeUrls**: string[]

## BackendServiceDefinition
### Properties
* **id**: string
* **kind**: string
* **location**: string (Required)
* **name**: string
* **properties**: schemas:1_properties
* **tags**: Dictionary<string,String>
* **type**: string

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Dictionary<string,ConnectionParameter>
### Additional Properties
* **Additional Properties Type**: ConnectionParameter

## ConnectionParameter
### Properties
* **defaultValue**: any
* **oAuthSettings**: ApiOAuthSettings
* **type**: 'array' | 'bool' | 'connection' | 'int' | 'oauthSetting' | 'object' | 'secureobject' | 'securestring' | 'string'
* **uiDefinition**: any

## ApiOAuthSettings
### Properties
* **clientId**: string
* **clientSecret**: string
* **customParameters**: Dictionary<string,ApiOAuthSettingsParameter>
* **identityProvider**: string
* **properties**: any
* **redirectUrl**: string
* **scopes**: string[]

## Dictionary<string,ApiOAuthSettingsParameter>
### Additional Properties
* **Additional Properties Type**: ApiOAuthSettingsParameter

## ApiOAuthSettingsParameter
### Properties
* **options**: any
* **uiDefinition**: any
* **value**: string

## GeneralApiInformation
### Properties
* **id**: string
* **kind**: string
* **location**: string (Required)
* **name**: string
* **properties**: schemas:1_properties
* **tags**: Dictionary<string,String>
* **type**: string

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## ApiPolicies
### Properties
* **id**: string
* **kind**: string
* **location**: string (Required)
* **name**: string
* **properties**: schemas:1_properties
* **tags**: Dictionary<string,String>
* **type**: string

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

