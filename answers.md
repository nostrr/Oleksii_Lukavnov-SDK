#### 1- Have you manually tested the SDK?
##### I created console project and tested it there.
#
#### 2- Did you add a test suite? If so how will we use it? If not, why?
##### Yes, I added a test suite. Firstly, you need to launch WebAPI application (In solution it is `LotRWebAPI` ) and then run tests (`LordOfTheRingsSDK.Tests`).
#
####  3 - Did you use any 3rd party library? Why did you use it? What are the tradeoffs?
##### I used only `Newtonsoft.Json`. In my opinion, this library is better than `System.Text.Json`. Adding an extra library adds more functionality, but it also adds additional dependencies. Error handling can slow down the SDK and make it more complex, but it is also necessary for reliable and safe application operation. Storing implementation classes with an interface in the same solution speeds up development, but reduces flexibility and adds unnecessary dependencies.
#
#### 4 - Do you feel this SDK makes it easier to interact with the API?
##### Yes, it's more convenient. You are not tied to the transport layer.
#
####  5 - If you had more time, what else would you add?
##### I would add more tests, exception system, implement functionality for user authentication and authorization that can allow users to access secure API resources.
#
#### 6 - What would you change in your current SDK solution?
##### Fix _deserializer = new JsonDeserializer() in the constructor `MovieService`, and add abstractions, add IoC container.
#
#### 7 - On a scale of 1 to 10, how would you rate this SDK? (higher is better).
##### Rate is 6.5.  If I fixed everything mentioned above, the rating would be higher.
#
#### 8 - Anything else we should keep in mind when we evaluate the project?
#####  [Design.md](https://github.com/nostrr/Oleksii_Lukavnov-SDK/blob/master/design.md).
