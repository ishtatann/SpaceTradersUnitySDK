
openapi-generator-cli generate -g csharp-netcore --additional-properties=targetFramework=netstandard2.1 --additional-properties=packageName=SpaceTradersUnitySDK --additional-properties=apiName=Client --library=unityWebRequest --additional-properties=validatable=false --additional-properties=netCoreProjectFile=true -o . -i ../api-docs/reference/SpaceTraders.json
