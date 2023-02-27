### The design of the SDK application for the Lord of the Rings API consists of the following main components:

## Models: 
Classes that represent data obtained from the API, such as `Movie` and `Quote` classes, which contain information about movies and quotes from movies, respectively.

## Services: 
A class that contains methods for interacting with the API that users can use. For example, `MovieService`, which contains methods for getting a list of movies and information about a specific movie.

## Exceptions: 
Classes that represent user exceptions that may occur in the SDK when working with the API. For example, `NotFoundException`, which is generated if the requested resource is not found.

## Clients: 
Classes that represent different clients that make requests to the API. The choice of client is implemented through a factory class and adapter classes. (`ClientFactory`, `HttpClientAdapter`, `HttpWebRequestAdapter`, `WebClientAdapter`)

## Deserializer: 
A class that provides deserialization of the response string into an object. (`JsonDeserializer`)

## Config: 
A class that contains SDK settings, such as API URL.

## Tests: 
A set of unit tests to verify the functionality of the SDK.

## Solution
*LordOfTheRingsSDK.Tests* - Unit Testing Project
*LotRSDK* - main SDK package
*LotRSDKSampleConsole* - Sample console project (using NuGet package)
*LotRWebAPI* - WebAPI project

#### Conclusion
Overall, the SDK application design for the Lord of the Rings API follows the principles of modular, scalable and testable code. All components should be independent of each other, allowing for easy addition of new features and improvement of existing ones. The code should be written in a readable and understandable manner so that other developers can easily understand its structure and logic.
