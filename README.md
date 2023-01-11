# Charter Communication WebAPI OA
  This API is separated into four layers, including Entity/Model, Repository, Service, and Endpoint layers. 
  
## Application Core Project
  This folder contains all the entities, models, as well as the interfaces for repos and services used in this API. The core prepares the basic building blocks of the API.
### Contracts
   This folder contains interfaces of their respective repository or service class file, setting a clear guideline of what functionalities need to be implemented.
### Entities
   This folder contains significant entities that present in the relational data.
### Models
   This folder contains data models that is used to extract specific one transaction.
    
   
## Infrastructure Project
   This project includes all the repository, service, and wrapper class files. 
### Repos
    This folder contains a file that emulate the scenario of gettting data from a database and feed them into the API.
### Services
    This folder contains a file that handles the business logic of calculating reward points.
### Wrapper
    This folder contains a file that creates an extension method for the Transaction object, transforming the Transaction object into TransactionExportModel and therefore hiding the original data structure of the repository layer, providing extra security if needed. 

## CharterCommApp_API Project
   This project is the main and startup project of the entire solution. It handles functionality access and UI through Swagger. 
### Controller
   This folder contains a file that handles the route of incoming http request and select the appropriate action for the requests. If the route only has one integer value after the domain, then Quarterly points of the given user is returned. In addition to the customer Id, if another integer follows the customer Id, then alternative action would be triggered to return monthly reward points of the given user. 
### appsettings.json
   This file has multiple uses, including but not limited to set third-party logger such as Serilog, set up connection string to database. 
### Program.cs
   This file handles middlewares and sets the service lifetime. It calls on the Swagger middleware to display the API Documentation.
