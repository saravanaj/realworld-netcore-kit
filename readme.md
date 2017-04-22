# ![RealWorld Example App](logo.png)

> ### ASP.Net Core codebase containing real world examples (CRUD, auth, advanced patterns, etc) that adheres to the [RealWorld](https://github.com/gothinkster/realworld-example-apps) spec and API.


### [Demo]()&nbsp;&nbsp;&nbsp;&nbsp;[RealWorld](https://github.com/gothinkster/realworld)


This codebase was created to demonstrate a fully fledged fullstack application built with **ASP.Net Core** including CRUD operations, authentication, routing, pagination, and more.

We've gone to great lengths to adhere to the **ASP.Net Core** community styleguides & best practices.

For more information on how to this works with other frontends/backends, head over to the [RealWorld](https://github.com/gothinkster/realworld) repo.


** Work in progress **

# How it works

> Describe the general architecture of your app here

# Getting started

This project is using  .NET Core SDK 1.0.3 (which includes .NET Core 1.0.4 and .NET Core 1.1.1. Runtime)

* __dotnet restore__
* __dotnet build__
* __dotnet run__


## How to use it on your development machine:

Clone the project and open it in VS code. The prerequisite to run are:
* A running MongoDB server on localhost with default config
* .NET Core Command Line Tools

You should then be able to start the WebAPI from the debugger in VS code.

Alternatively, type __dotnet run__ from a command line in the _src/Sandbox.Server.Http_ sub-folder.

A sample __docker-compose.yml__ script is provided. After running an initial __docker-compose up__ from the command line on a Docker-enabled machine, the WebAPI will respond at http://localhost:5000 (same as running in the debugger) and mongodb will respond at its default location mongodb://localhost:27017.

The MongoDB container port mapping is for convenience only. So you can safely remove it to avoid conflict with any other running MongoDB daemon.



## Credits:
This repo was originaly cloned from [Renaud Calmont](https://github.com/renaudcalmont/aspnetcore-mongodb-sandbox) repository


Trying here to keep track of and thank all the building blocks composing this project
* Microsoft [ASP.NET Core](http://www.asp.net/core) of course and for [VS code](https://code.visualstudio.com) editor
* [MongoDB](https://www.mongodb.com/) and their [C# Driver](https://docs.mongodb.com/ecosystem/drivers/csharp/)
* [Yeoman](http://yeoman.io/) - every project.json here started with a "[yo aspnet](https://www.npmjs.com/package/generator-aspnet)"
* [Docker](https://www.docker.com/), including the hub and compose
* [Travis CI](https://travis-ci.org/)
* [Swagger UI](http://swagger.io/swagger-ui/) thanks to [abauzac](https://github.com/abauzac) contribution

