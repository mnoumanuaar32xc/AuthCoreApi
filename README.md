![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/bbc2ee26-3688-44db-830a-82129a040694)# AuthCoreApi
 AuthCoreApi is a robust .NET Core API designed with a Code-First DB approach, integrating comprehensive authentication, role-based authorization and access controls to ensure secure data management

 # .Net Core Web API 
1. Code First Approach
2. Dependency Injection
3. Authentication
4. Role Based Authorization
5. Role Based Access  

# Create a Asp .NET Core Web API
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/2b1f1dc8-d5c6-4e5b-94d6-2d8c88627a3e)

 # Create Models
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/38b769ef-6bd4-4423-a14d-586e8bc007da)
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/ca775463-e102-4da0-a3c4-c7bbdcb6f706)


# Nugget Packages
We are following code first approach that need entity framework core  that is needed for our application. And we have domain model that is basically derive the structure of database . We will tells Entity framework that is our database models and entity framework will create database for us. For that purpose we need to ist install entity framework packages

![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/7adf5db2-37d7-434e-a060-4c653b058fa5)

# DbContext Class
Maintaining connection to Db
Track Changes
Perform CRUD Operation
Bridge between domain models and the database.
Define the way of database schema using entity classes or domain classes Which maps directly to table in Database.
 ![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/555eb443-b8b0-4a96-95b9-1085181852cc)

# Add a Connection String 
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/83539129-4c23-4966-ba60-4b2224e91bb0)

# Dependency Injection 
Design pattern to increase maintainability , testability.
DI built into Asp.net core
DI is responsible for creating and managing instances.
DI works on this fundamental that instead of instantiating object within a class those objects are passed in as parameters to the class , like passing it to constructer or method.
.NET core provides built in container that can be used to manage the dependencies of an application.
The container is responsible for creating and managing of services which are registered with the container when the application start

1. Add services to the container. 
2. Pass the connection string  to ApplicationDbContext
 
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/d42d95f0-2680-4273-9319-c8df0965a771)


# Running EF Core Migrations
In visual Studio Open the NuGet Package Manager Console
For creating DB and schema type  PM> Add-Migration "Initial Migration“ 
It is creating a script that EF core can use to create a latter on a SQL script and then create a DB.

# PM> Add-Migration InitialCreate -Context ApplicationDbContext
# PM> update-database -context ApplicationDbContext
 
----------------------------------------

# Create Controller and Action 
Get/Post/Put/Delete

# Understanding DTOs and Domain Models
DTO data transfer objects , use to transfer data between different layers
Typically contain a subset of the properties in the domain model.

![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/73297014-9881-4e59-bc06-5fe39ca89a93)

# Advantages of DTOs 
1. Separation of Concerns 
2. Performance 
3. Security  

 # Create a First Action Method , create new Training. 

 # Repository Pattern
 ![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/bcb59a19-401d-4cc7-9f72-ae1093503291)
1. Repository pattern to separate the data access layer from application
2. Provides interface without exposing Implementations
3. Helps create abstractions layer between application and data store which is implemented by concreate repository class.
4. Decoupling
5. Consistency
6. Performance
7. Multiple data sources (switching)

# Implement Repository Pattern inside Application

 ![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/7b51910a-fdac-4aed-94c7-15034a74e0b4)


# Enable the CORS
In Progam.css allow the CROS then restart the application.
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/43246c26-186a-47c7-9f61-968f36574e9d)

# Authorization
1. User permission
2. Roles, polices ,Claims
3. Check if user has read only or read write role

 ![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/cba00210-a819-4aa0-9835-a77b4d09add7)

# Authentication Flow JWT
We are using an authentication method in which the server creates a JWT token and pass it to the client.
JWT or Json web tokens is an open standard that defines a compact and self-contained way for securely transmitting information between parties as a Json object.
In our authentication flow, users will come to a website that wants to talk to our API.
The users will type in their username and password using a login form and the website will send this information to the API.
The API will check the username and password and if this information is correct it will generate a JWT token for the website user.
The website will then use this JWT token as a way to make Http calls to the API to access the resource of the API and get data from the API.
The API will check if the token is correct and if it is, the API will return the data that the website asked for.
If the website doesn't send a JWT or it is invalid, then no data is returned from the API.

    ![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/3e83d0e7-2e03-40d1-97ef-9b8d8dcba7f7)

# Install Nuget Package API
Microsoft.AspNetCore.Authentication.JwtBearer
Microsoft.AspNetCore.Identity.EntityFrameworkCore
microsoft.identitymodel.token
microsoft.identitymodel.tokens.jwt

# Create AuthDbContext , Roles , User API
Create a AuthDbContext to communicate with authentication and users roles based 
Create a AuthDBContext as like ApplicationDbContext
This class will inherate from IdentityDbContext which is comes from using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
Create constractor with DbContextOptions

# Roles and Users create by EF
  we have to cede some roles that will be used to seed 
later on when we create our users.
So let's say we create a user and we want to give it a role.

# Inject Authentication and DbContext API
In Program. Cs inject DbContext as similer to ApplicationDbContext
 ![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/16b7ee9b-800f-462c-98ff-4d67a7940f09)

If you want to a separate DB for Users Authentication so you can change the DB connection string for AuthDbContext.
 
# Inject the Identity core in Program.cs 

 ![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/8a76a6be-9b2e-4680-afe1-34517f171952)

# Configure the Identity Options 
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/87892e87-de42-4f29-a74c-3ef6eed209f4)

# Define the Token Authentication for Jwt Token  
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/70cf0dbe-7260-4eb1-9252-e8591bc2c3c0)

# Add jwt configurations in appsetting.js 
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/88e3d232-cd91-4fc1-b17c-b77460266df4)

# Add Authentication in the http pipeline
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/83454f82-3862-492d-8e3d-568365ba3f7a)

# Test Authorized Attributes
Try to run the Api and see how we achieve the authentication 
And try to pass the token and without passing token what's output you will receive.
Let try to run the Get Category API Execute 
You will get all Api working fine and responses . Nothing being api call like authentication and authorizations.

 # How to Authorize the Method 
 Need to use [Authorized] attribute on function or on controller . 
With authorized method without tokens it return Error: response status is 401
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/f4035168-5528-4b75-a3b8-062ec88b1f0d)

# Auth Controller – Registered User-API
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/0fad3f36-72b1-428a-bc09-a127ea64b788)

# Auth Register Api  
When we run the Auth Register Api method it return 500 error because we did not create any table for authenticate user and not run the migration.

# Create Authentication Tables – Run EF Core Migration. 
go to tools => NuGet Package Manager => Package Manager Console 
PM> Add-Migration "Initial Migration For Auth“
PM> Add-Migration "Initial Migration For Auth" -context "AuthDbContext“
PM> Update-Database -context "AuthDbContext"

# After Migration Auth  
You can see after Migration Asp.net Tables are created
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/5e9ac808-af72-42e5-ba84-5078959e0877)

# Login Controller – Login User-API 
We are going to create a new action method called login user, and with the help of
which we are able to authenticate our users.
So we will ask them a user name or an email and a password and we will first check the database.
If these two combination were successful, if they were, we will ultimately give them the JWT token.

 # Login Controller – Login User-API

 We are going to create a new action method called login user, and with the help of
which we are able to authenticate our users.
So we will ask them a user name or an email and a password and we will first check the database.
If these two combination were successful, if they were, we will ultimately give them the JWT token.

# Login Action  
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/daac2601-a15e-49f5-9d7d-d2260db54428)

# Try Login Action
 ![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/2df2284d-2d2f-45b8-9477-5f39196d711c)

# Create and Generate Token 
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/0a9b3d45-a3bc-498b-a486-264f60972663)

# Assign Token to Login  
![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/aa338c85-0169-4925-ad6d-b48cc6bc5bd5)

# Add DI (TokenRepository into Program.cs)
builder.Services.AddScoped<ITokenRepository, TokenRepository>();
 # Try Login 
 bellow request try in Post man 
 
  curl -X 'POST' \ 'https://localhost:7115/api/Auth/Login' \ -H 'accept: */*' \ -H 'Content-Type: application/json' \ -d '{ "email": "admin.test.com", "password": "Admin@123" }‘

![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/cc77e379-8ff3-4a29-a5b3-ace7d4c13019)

# Try other methods with [Athuorize] 
With out token assign 401 error will receive .
Now when you will assign token with your 
Request then it will return 200. 
Now for each request which have [Authorized ]
Action Method , token will be necessary

![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/8b2f7a31-268c-42ea-b6cc-6631218d4631)

# Role Based Authorization-API
Now we also want to perform role based authorization.
So now that we know this user was correct, like they have the correct information of email and password,
but if they don't have the correct role to perform a certain type of action, we are going to block them in the API.
So let's say if a reader user uses the JWT token to do something to delete a resource, we should block them and that is how role based authorization works.
[Authorize (Roles ="Writer")] public async Task<IActionResult> GetAllTranings()
We are trying to call this method but we get 403 Forbiden error with 401 Unauthorized response.
If we set the right role which are available to login person so it will be 200 in response.

![image](https://github.com/mnoumanuaar32xc/AuthCoreApi/assets/8413883/23d4ad40-ef7b-4d4b-9d46-26e1ff1d9685)




 








 













 















 
 















 


















