# Microsoft.BotService @ 2018-07-12

## Microsoft.BotService/botServices/Connections
### Properties
* **apiVersion**: '2018-07-12' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string
* **id**: string (ReadOnly, DeployTimeConstant)
* **kind**: 'bot' | 'designer' | 'function' | 'sdk'
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: ConnectionSettingProperties
* **sku**: Sku
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.BotService/botServices/Connections' (ReadOnly, DeployTimeConstant)

## ConnectionSettingProperties
### Properties
* **clientId**: string
* **clientSecret**: string
* **parameters**: ConnectionSettingParameter[]
* **scopes**: string
* **serviceProviderDisplayName**: string
* **serviceProviderId**: string
* **settingId**: string (ReadOnly)

## ConnectionSettingParameter
### Properties
* **key**: string
* **value**: string

## Sku
### Properties
* **name**: 'F0' | 'S1' (Required)
* **tier**: 'Free' | 'Standard' (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.BotService/botServices/channels
### Properties
* **apiVersion**: '2018-07-12' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string
* **id**: string (ReadOnly, DeployTimeConstant)
* **kind**: 'bot' | 'designer' | 'function' | 'sdk'
* **location**: string
* **name**: 'DirectLineChannel' | 'EmailChannel' | 'FacebookChannel' | 'KikChannel' | 'MsTeamsChannel' | 'SkypeChannel' | 'SlackChannel' | 'SmsChannel' | 'TelegramChannel' | 'WebChatChannel' (Required, DeployTimeConstant)
* **properties**: Channel
* **sku**: Sku
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.BotService/botServices/channels' (ReadOnly, DeployTimeConstant)

## Channel
* **Discriminator**: channelName
### Base Properties
### DirectLineChannel
#### Properties
* **channelName**: 'DirectLineChannel' (Required)
* **properties**: DirectLineChannelProperties

### EmailChannel
#### Properties
* **channelName**: 'EmailChannel' (Required)
* **properties**: EmailChannelProperties

### FacebookChannel
#### Properties
* **channelName**: 'FacebookChannel' (Required)
* **properties**: FacebookChannelProperties

### KikChannel
#### Properties
* **channelName**: 'KikChannel' (Required)
* **properties**: KikChannelProperties

### MsTeamsChannel
#### Properties
* **channelName**: 'MsTeamsChannel' (Required)
* **properties**: MsTeamsChannelProperties

### SkypeChannel
#### Properties
* **channelName**: 'SkypeChannel' (Required)
* **properties**: SkypeChannelProperties

### SlackChannel
#### Properties
* **channelName**: 'SlackChannel' (Required)
* **properties**: SlackChannelProperties

### SmsChannel
#### Properties
* **channelName**: 'SmsChannel' (Required)
* **properties**: SmsChannelProperties

### TelegramChannel
#### Properties
* **channelName**: 'TelegramChannel' (Required)
* **properties**: TelegramChannelProperties

### WebChatChannel
#### Properties
* **channelName**: 'WebChatChannel' (Required)
* **properties**: WebChatChannelProperties


## DirectLineChannel
### Properties
* **channelName**: 'DirectLineChannel' (Required)
* **properties**: DirectLineChannelProperties

## DirectLineChannelProperties
### Properties
* **sites**: DirectLineSite[]

## DirectLineSite
### Properties
* **isEnabled**: bool (Required)
* **isSecureSiteEnabled**: bool
* **isV1Enabled**: bool (Required)
* **isV3Enabled**: bool (Required)
* **key**: string (ReadOnly)
* **key2**: string (ReadOnly)
* **siteId**: string (ReadOnly)
* **siteName**: string (Required)
* **trustedOrigins**: string[]

## EmailChannel
### Properties
* **channelName**: 'EmailChannel' (Required)
* **properties**: EmailChannelProperties

## EmailChannelProperties
### Properties
* **emailAddress**: string (Required)
* **isEnabled**: bool (Required)
* **password**: string (Required)

## FacebookChannel
### Properties
* **channelName**: 'FacebookChannel' (Required)
* **properties**: FacebookChannelProperties

## FacebookChannelProperties
### Properties
* **appId**: string (Required)
* **appSecret**: string (Required)
* **callbackUrl**: string (ReadOnly)
* **isEnabled**: bool (Required)
* **pages**: FacebookPage[]
* **verifyToken**: string (ReadOnly)

## FacebookPage
### Properties
* **accessToken**: string (Required)
* **id**: string (Required)

## KikChannel
### Properties
* **channelName**: 'KikChannel' (Required)
* **properties**: KikChannelProperties

## KikChannelProperties
### Properties
* **apiKey**: string (Required)
* **isEnabled**: bool (Required)
* **isValidated**: bool
* **userName**: string (Required)

## MsTeamsChannel
### Properties
* **channelName**: 'MsTeamsChannel' (Required)
* **properties**: MsTeamsChannelProperties

## MsTeamsChannelProperties
### Properties
* **callingWebHook**: string
* **enableCalling**: bool
* **isEnabled**: bool (Required)

## SkypeChannel
### Properties
* **channelName**: 'SkypeChannel' (Required)
* **properties**: SkypeChannelProperties

## SkypeChannelProperties
### Properties
* **callingWebHook**: string
* **enableCalling**: bool
* **enableGroups**: bool
* **enableMediaCards**: bool
* **enableMessaging**: bool
* **enableScreenSharing**: bool
* **enableVideo**: bool
* **groupsMode**: string
* **isEnabled**: bool (Required)

## SlackChannel
### Properties
* **channelName**: 'SlackChannel' (Required)
* **properties**: SlackChannelProperties

## SlackChannelProperties
### Properties
* **clientId**: string (Required)
* **clientSecret**: string (Required)
* **isEnabled**: bool (Required)
* **isValidated**: bool (ReadOnly)
* **landingPageUrl**: string
* **lastSubmissionId**: string (ReadOnly)
* **redirectAction**: string (ReadOnly)
* **registerBeforeOAuthFlow**: bool (ReadOnly)
* **verificationToken**: string (Required)

## SmsChannel
### Properties
* **channelName**: 'SmsChannel' (Required)
* **properties**: SmsChannelProperties

## SmsChannelProperties
### Properties
* **accountSID**: string (Required)
* **authToken**: string (Required)
* **isEnabled**: bool (Required)
* **isValidated**: bool
* **phone**: string (Required)

## TelegramChannel
### Properties
* **channelName**: 'TelegramChannel' (Required)
* **properties**: TelegramChannelProperties

## TelegramChannelProperties
### Properties
* **accessToken**: string (Required)
* **isEnabled**: bool (Required)
* **isValidated**: bool

## WebChatChannel
### Properties
* **channelName**: 'WebChatChannel' (Required)
* **properties**: WebChatChannelProperties

## WebChatChannelProperties
### Properties
* **sites**: WebChatSite[]
* **webChatEmbedCode**: string (ReadOnly)

## WebChatSite
### Properties
* **enablePreview**: bool (Required)
* **isEnabled**: bool (Required)
* **key**: string (ReadOnly)
* **key2**: string (ReadOnly)
* **siteId**: string (ReadOnly)
* **siteName**: string (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.BotService/botServices
### Properties
* **apiVersion**: '2018-07-12' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string
* **id**: string (ReadOnly, DeployTimeConstant)
* **kind**: 'bot' | 'designer' | 'function' | 'sdk'
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: BotProperties
* **sku**: Sku
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.BotService/botServices' (ReadOnly, DeployTimeConstant)

## BotProperties
### Properties
* **configuredChannels**: string[] (ReadOnly)
* **description**: string
* **developerAppInsightKey**: string
* **developerAppInsightsApiKey**: string
* **developerAppInsightsApplicationId**: string
* **displayName**: string (Required)
* **enabledChannels**: string[] (ReadOnly)
* **endpoint**: string (Required)
* **endpointVersion**: string (ReadOnly)
* **iconUrl**: string
* **luisAppIds**: string[]
* **luisKey**: string
* **msaAppId**: string (Required)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

## Microsoft.BotService/enterpriseChannels
### Properties
* **apiVersion**: '2018-07-12' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string
* **id**: string (ReadOnly, DeployTimeConstant)
* **kind**: 'bot' | 'designer' | 'function' | 'sdk'
* **location**: string
* **name**: string (Required, DeployTimeConstant)
* **properties**: EnterpriseChannelProperties
* **sku**: Sku
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.BotService/enterpriseChannels' (ReadOnly, DeployTimeConstant)

## EnterpriseChannelProperties
### Properties
* **nodes**: EnterpriseChannelNode[] (Required)
* **state**: 'CreateFailed' | 'Creating' | 'DeleteFailed' | 'Deleting' | 'StartFailed' | 'Started' | 'Starting' | 'StopFailed' | 'Stopped' | 'Stopping'

## EnterpriseChannelNode
### Properties
* **azureLocation**: string (Required)
* **azureSku**: string (Required)
* **id**: string (ReadOnly)
* **name**: string (Required)
* **state**: 'CreateFailed' | 'Creating' | 'DeleteFailed' | 'Deleting' | 'StartFailed' | 'Started' | 'Starting' | 'StopFailed' | 'Stopped' | 'Stopping'

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

