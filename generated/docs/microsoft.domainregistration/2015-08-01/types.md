# Microsoft.DomainRegistration @ 2015-08-01

## Microsoft.DomainRegistration/domains
### Properties
* **apiVersion**: '2015-08-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **kind**: string
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: schemas:1_properties
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.DomainRegistration/domains' (ReadOnly, DeployTimeConstant)

## schemas:1_properties
### Properties
* **keyVaultId**: string
* **keyVaultSecretName**: string
* **provisioningState**: 'AzureServiceUnauthorizedToAccessKeyVault' | 'CertificateOrderFailed' | 'Initialized' | 'KeyVaultDoesNotExist' | 'KeyVaultSecretDoesNotExist' | 'OperationNotPermittedOnKeyVault' | 'Succeeded' | 'Unknown' | 'UnknownError' | 'WaitingOnCertificateOrder'

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

