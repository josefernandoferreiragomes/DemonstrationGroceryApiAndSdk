## Demonstration of a Web Api, Sdk and its consumer
This project aims to demonstrate the creation of a web api (OpenApi compliant) and generate its client sdk, using swagger and nswag

## Steps

### 1. Build a minimal API with .NET

### 2. Use OpenAPI and Swagger to generate the API specification

### 3. Protect sensitive endpoints

#### 3.1 Create bearer token valid for the machine and user where it is run

dotnet user-jwts create

Example
Local token example:

eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6Impvc2VmIiwic3ViIjoiam9zZWYiLCJqdGkiOiJmMWFiY2FiZCIsImF1ZCI6WyJodHRwOi8vbG9jYWxob3N0OjIzNjE5IiwiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzNTAiLCJodHRwOi8vbG9jYWxob3N0OjUwNTgiLCJodHRwczovL2xvY2FsaG9zdDo3MjU4Il0sIm5iZiI6MTcyNDQyODMzMCwiZXhwIjoxNzMyMzc3MTMwLCJpYXQiOjE3MjQ0MjgzMzIsImlzcyI6ImRvdG5ldC11c2VyLWp3dHMifQ.BWGCAaBLLARa0fWzU1bNvMTIf-KqdOMr_Y3gxTay3H4

#### 3.2 Test in swagger

Test it in swagger, clicking authorize button before creating a new grocery item
Then create the grocery item, and receive the code 201, created
(otherwise, you would recieve the code 401 unauthorized)

### Update the OpenAPI specification

### Create SDK project for the API client

Create a project to contain the api client sdk, called NSwagGrocerySdk

Install packages newtonsoft.json

### Generate client code from NSwag cli

Make sure nswag is installed

In Packet manager console, move to the sdk project folder
Paste command:

	nswag openapi2csclient /input:https://localhost:7258/swagger/v1/swagger.json /classname:NSwagGrocerySdk /namespace:NSwagGrocerySdk.Client /output:NSwagGrocerySdk.cs 

Can also be generated from nswag studio application

It is also possible to generate controllers

### Test the SDK with a console application

## Sources
Learning course

https://learn.microsoft.com/en-us/shows/dotnetconf-2022/build-a-dotnet-sdk-with-openapi-and-nswag?source=recommendations

Learning docs

https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-8.0&tabs=visual-studio

Bearer Tokens
https://devblogs.microsoft.com/dotnet/bearer-token-authentication-in-asp-net-core/
https://dev.to/techiesdiary/net-60-jwt-token-authentication-using-the-example-api-91l

