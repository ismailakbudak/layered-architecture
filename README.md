## Developer İsmail AKBUDAK 

Layered Architecture Project

## License

Copyright (c) 2013-2014 Ismail AKBUDAK
Licensed under the [MIT license](https://github.com/ismailakbudak/layered-architecture/blob/master/MIT-LICENSE.txt).

## Development 
 Layered Architecture with Entity Framework. Programming language is C#. ASP.NET web application..

## Requirements
-Our database scripts is webhouse.sql
-Database name WEBHOUSE
-Environment: Visual Studio 2012

## Settings

You have to change DataAccessLibrary Database property
Delete these files on DataAccessLibrary : 
-WEBHOUSEModel.edmx
-packages.config
-App.Config

-After delete right click on DataAccessLibrary project
-Add -> New Item -> Data -> ADO.NET Entity Data Model
-change model name following
-Our Model name is : WEBHOUSEModel
-Generate From Database 
-Find your database in your local server with New Connection
-change entity name as following
-Our Entity name is : WEBHOUSEEntities
-and Next use default settings 
-your entities is ready :)

-After all of those you have to change App.Config file in WEBHOUSE web application project
-You can copy and paste from DataAccessLibrary project
-We will use Bese.cs class for database process it inherited from Window and it is abstract class

-Also be carefull about the this line in Container/ModelEnd.tt 
-const string inputFile = @"..\DataAccessLibrary\ModelEnd.edmx";
