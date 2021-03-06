# Microsoft.Devices @ 2020-01-01

## Microsoft.Devices/provisioningServices/certificates
### Properties
* **apiVersion**: '2020-01-01' (ReadOnly, DeployTimeConstant)
* **certificate**: string (WriteOnly)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string (ReadOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: CertificateProperties (ReadOnly)
* **type**: 'Microsoft.Devices/provisioningServices/certificates' (ReadOnly, DeployTimeConstant)

## CertificateProperties
### Properties
* **created**: string (ReadOnly)
* **expiry**: string (ReadOnly)
* **isVerified**: bool (ReadOnly)
* **subject**: string (ReadOnly)
* **thumbprint**: string (ReadOnly)
* **updated**: string (ReadOnly)

## Microsoft.Devices/provisioningServices
### Properties
* **apiVersion**: '2020-01-01' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string
* **id**: string (ReadOnly, DeployTimeConstant)
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: IotDpsPropertiesDescription (Required)
* **sku**: IotDpsSkuInfo (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.Devices/provisioningServices' (ReadOnly, DeployTimeConstant)

## IotDpsPropertiesDescription
### Properties
* **allocationPolicy**: 'GeoLatency' | 'Hashed' | 'Static'
* **authorizationPolicies**: SharedAccessSignatureAuthorizationRule_AccessRightsDescription_[]
* **deviceProvisioningHostName**: string (ReadOnly)
* **idScope**: string (ReadOnly)
* **iotHubs**: IotHubDefinitionDescription[]
* **ipFilterRules**: IpFilterRule[]
* **provisioningState**: string
* **serviceOperationsHostName**: string (ReadOnly)
* **state**: 'Activating' | 'ActivationFailed' | 'Active' | 'Deleted' | 'Deleting' | 'DeletionFailed' | 'FailingOver' | 'FailoverFailed' | 'Resuming' | 'Suspended' | 'Suspending' | 'Transitioning'

## SharedAccessSignatureAuthorizationRule_AccessRightsDescription_
### Properties
* **keyName**: string (Required)
* **primaryKey**: string
* **rights**: 'DeviceConnect' | 'EnrollmentRead' | 'EnrollmentWrite' | 'RegistrationStatusRead' | 'RegistrationStatusWrite' | 'ServiceConfig' (Required)
* **secondaryKey**: string

## IotHubDefinitionDescription
### Properties
* **allocationWeight**: int
* **applyAllocationPolicy**: bool
* **connectionString**: string (Required)
* **location**: string (Required)
* **name**: string (ReadOnly)

## IpFilterRule
### Properties
* **action**: 'Accept' | 'Reject' (Required)
* **filterName**: string (Required)
* **ipMask**: string (Required)
* **target**: 'all' | 'deviceApi' | 'serviceApi'

## IotDpsSkuInfo
### Properties
* **capacity**: int
* **name**: 'S1'
* **tier**: string (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

