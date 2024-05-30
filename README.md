# AuthCoreApi
 AuthCoreApi is a robust .NET Core API designed with a Code-First DB approach, integrating comprehensive role-based authorization and access controls to ensure secure data management

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














 


















