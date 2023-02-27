# Lord of the Rings API SDK
### This SDK provides access to the Lord of the Rings API movie endpoints.
#
## Installation

To use this SDK in your project, you can install it via NuGet Package Manager:

```sh
PM> Install-Package LotRSDK
```
Alternatively, you can add the following line to your project's **.csproj** file:
```sh
<ItemGroup>
  <PackageReference Include="LotRSDK" Version="1.0.1" />
</ItemGroup>
```
#
## Usage
To use the SDK, you need to first create an instance of the `MovieService`  class:

```
var movieService = new MovieService(ClientType.HttpClient, URL)
```
Where `ClientType` is the client type.

Then, you can call the available ***endpoints***:
```
// Get a list of all movies
var movies = await service.GetMoviesAsync();
```
```
// Get a specific movie by ID
var movie = await service.GetMovieByIdAsync(1);
```
```
// Get quotes for a specific movie by ID
var quotes = await service.GetMovieQuotesByIdAsync(1);
```
#
## Error Handling
If an error occurs while making a request to the API, a `MovieNotFoundException` will be thrown. This exception contains a `StatusCode` property that indicates the HTTP status code of the response, as well as a Message property that contains a human-readable error message.
```
try
{
    var movies = await client.GetMoviesAsync();
}
catch (MovieNotFoundException ex)
{
    Console.WriteLine($"Error {ex.StatusCode}: {ex.Message}");
}
```
