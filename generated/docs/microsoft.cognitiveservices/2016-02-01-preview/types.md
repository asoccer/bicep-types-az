# Microsoft.CognitiveServices @ 2016-02-01-preview

## Microsoft.CognitiveServices/accounts
### Properties
* **apiVersion**: '2016-02-01-preview' (ReadOnly, DeployTimeConstant)
* **dependsOn**: resourceref[] (WriteOnly)
* **etag**: string (ReadOnly)
* **id**: string (ReadOnly, DeployTimeConstant)
* **kind**: 'Academic' | 'Bing.Autosuggest' | 'Bing.Search' | 'Bing.Speech' | 'Bing.SpellCheck' | 'ComputerVision' | 'ContentModerator' | 'Emotion' | 'Face' | 'LUIS' | 'Recommendations' | 'SpeakerRecognition' | 'Speech' | 'SpeechTranslation' | 'TextAnalytics' | 'TextTranslation' | 'WebLM' (Required)
* **location**: string (Required)
* **name**: string (Required, DeployTimeConstant)
* **properties**: any (Required)
* **sku**: Sku (Required)
* **tags**: Dictionary<string,String>
* **type**: 'Microsoft.CognitiveServices/accounts' (ReadOnly, DeployTimeConstant)

## Sku
### Properties
* **name**: 'F0' | 'P0' | 'P1' | 'P2' | 'S0' | 'S1' | 'S2' | 'S3' | 'S4' | 'S5' | 'S6' (Required)
* **tier**: 'Free' | 'Premium' | 'Standard' (ReadOnly)

## Dictionary<string,String>
### Additional Properties
* **Additional Properties Type**: string

