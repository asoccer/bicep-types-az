# Microsoft.Media @ 2020-02-01-preview

## Microsoft.Media/mediaServices/mediaGraphs
### Properties
* **apiVersion**: '2020-02-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **name**: string (Required, DeployTimeConstant)
* **properties**: MediaGraphProperties
* **type**: 'Microsoft.Media/mediaServices/mediaGraphs' (ReadOnly, DeployTimeConstant)

## MediaGraphProperties
### Properties
* **created**: string (ReadOnly)
* **description**: string
* **lastModified**: string (ReadOnly)
* **sinks**: MediaGraphSink[] (Required)
* **sources**: MediaGraphSource[] (Required)
* **state**: 'Running' | 'Starting' | 'Stopped' | 'Stopping' (ReadOnly)

## MediaGraphSink
* **Discriminator**: @odata.type
### Base Properties
* **inputs**: string[] (Required)
* **name**: string (Required)
### #Microsoft.Media.MediaGraphAssetSink
#### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphAssetSink' (Required)
* **assetName**: string (Required)


## #Microsoft.Media.MediaGraphAssetSink
### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphAssetSink' (Required)
* **assetName**: string (Required)

## MediaGraphSource
* **Discriminator**: @odata.type
### Base Properties
* **name**: string (Required)
### #Microsoft.Media.MediaGraphRtspSource
#### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphRtspSource' (Required)
* **endpoint**: MediaGraphEndpoint (Required)
* **transport**: 'Http' | 'Tcp' (Required)


## #Microsoft.Media.MediaGraphRtspSource
### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphRtspSource' (Required)
* **endpoint**: MediaGraphEndpoint (Required)
* **transport**: 'Http' | 'Tcp' (Required)

## MediaGraphEndpoint
* **Discriminator**: @odata.type
### Base Properties
* **credentials**: MediaGraphCredentials
* **url**: string (Required)
### #Microsoft.Media.MediaGraphClearEndpoint
#### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphClearEndpoint' (Required)

### #Microsoft.Media.MediaGraphTlsEndpoint
#### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphTlsEndpoint' (Required)
* **trustedCertificates**: MediaGraphCertificateSource
* **validationOptions**: MediaGraphTlsValidationOptions


## MediaGraphCredentials
* **Discriminator**: @odata.type
### Base Properties
### #Microsoft.Media.MediaGraphUsernamePasswordCredentials
#### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphUsernamePasswordCredentials' (Required)
* **password**: string (Required)
* **username**: string (Required)


## #Microsoft.Media.MediaGraphUsernamePasswordCredentials
### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphUsernamePasswordCredentials' (Required)
* **password**: string (Required)
* **username**: string (Required)

## #Microsoft.Media.MediaGraphClearEndpoint
### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphClearEndpoint' (Required)

## #Microsoft.Media.MediaGraphTlsEndpoint
### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphTlsEndpoint' (Required)
* **trustedCertificates**: MediaGraphCertificateSource
* **validationOptions**: MediaGraphTlsValidationOptions

## MediaGraphCertificateSource
* **Discriminator**: @odata.type
### Base Properties
### #Microsoft.Media.MediaGraphPemCertificateList
#### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphPemCertificateList' (Required)
* **certificates**: string[] (Required)


## #Microsoft.Media.MediaGraphPemCertificateList
### Properties
* **@odata.type**: '#Microsoft.Media.MediaGraphPemCertificateList' (Required)
* **certificates**: string[] (Required)

## MediaGraphTlsValidationOptions
### Properties
* **ignoreHostname**: bool (Required)
* **ignoreSignature**: bool (Required)

