# Microsoft.Web @ 2016-03-01

## Microsoft.Web/certificates
### Properties
* **apiVersion**: '2016-03-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **kind**: string
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: schemas:0_properties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.Web/certificates' (ReadOnly, DeployTimeConstant)

## schemas:0_properties
### Properties
* **cerBlob**: array (ReadOnly)
* **expirationDate**: string (ReadOnly)
* **friendlyName**: string (ReadOnly)
* **geoRegion**: string (ReadOnly)
* **hostNames**: string[]
* **hostingEnvironmentProfile**: HostingEnvironmentProfile (ReadOnly)
* **issueDate**: string (ReadOnly)
* **issuer**: string (ReadOnly)
* **keyVaultId**: string
* **keyVaultSecretName**: string
* **keyVaultSecretStatus**: 'AzureServiceUnauthorizedToAccessKeyVault' | 'CertificateOrderFailed' | 'ExternalPrivateKey' | 'Initialized' | 'KeyVaultDoesNotExist' | 'KeyVaultSecretDoesNotExist' | 'OperationNotPermittedOnKeyVault' | 'Succeeded' | 'Unknown' | 'UnknownError' | 'WaitingOnCertificateOrder' (ReadOnly)
* **password**: string (Required)
* **pfxBlob**: array
* **publicKeyHash**: string (ReadOnly)
* **selfLink**: string (ReadOnly)
* **serverFarmId**: string
* **siteName**: string (ReadOnly)
* **subjectName**: string (ReadOnly)
* **thumbprint**: string (ReadOnly)
* **valid**: bool (ReadOnly)

## HostingEnvironmentProfile
### Properties
* **id**: string
* **name**: string (ReadOnly)
* **type**: string (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.Web/publishingUsers
### Properties
* **apiVersion**: '2016-03-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **kind**: string
* **name**: 'web' (Required, DeployTimeConstant)
* **properties**: schemas:67_properties
* **type**: 'Microsoft.Web/publishingUsers' (ReadOnly, DeployTimeConstant)

## schemas:67_properties
### Properties
* **name**: string
* **publishingPassword**: string
* **publishingPasswordHash**: string
* **publishingPasswordHashSalt**: string
* **publishingUserName**: string (Required)

## Microsoft.Web/sourcecontrols
### Properties
* **apiVersion**: '2016-03-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **kind**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: schemas:124_properties
* **type**: 'Microsoft.Web/sourcecontrols' (ReadOnly, DeployTimeConstant)

## schemas:124_properties
### Properties
* **expirationTime**: string
* **name**: string
* **refreshToken**: string
* **token**: string
* **tokenSecret**: string

