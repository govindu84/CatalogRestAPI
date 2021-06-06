//Ref: https://www.youtube.com/watch?v=wQSuZFd01tY&list=PLeD0-5Hw0ZJ_GlY21kfzfQD-N17i8pdTS&index=10
//https://code.visualstudio.com/docs/containers/quickstart-aspnet-core

## Prerequisites
Docker and the VS Code Docker extension must be installed as described on the overview.

## Add Docker files to the project
- Open the project folder in VS Code.

- open the Command Palette (Ctrl+Shift+P) and use the .NET: Generate Assets for Build and Debug command.

- Open Command Palette (Ctrl+Shift+P) and use Docker: Add Docker Files to Workspace... command:

## Add Dockerfile to a project

1. Use .NET: ASP.NET Core when prompted for application platform.

2. Choose Windows or Linux when prompted to choose the operating system.

3. Windows is only applicable if your Docker installation is configured to use Windows containers.

4. You will be asked if you want to add Docker Compose files. We will not use Docker Compose in this tutorial, so both "Yes" and "No" answers are fine.

Dockerfile and .dockerignore files are added to the workspace.

The extension will also create a set of VS Code tasks for building and running the container (in both debug- and release configuration, four tasks in total), and a debugging configuration for launching the container in debug mode.

Build the application#
Open terminal prompt (Ctrl+`).

## Issue **dotnet build** command to build the application:

- Create a Image:
run docker build -t catalog:v1

- Place Mongo db and cataglog image into single network for api access to mongodb.
docker network create CatalogAPINetwork

 docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db -e MONGO_INITDB_ROOT_USERNAME=mongoadmin -e MONGO_INITDB_ROOT_PASSWORD=password --network=CatalogAPINetwork mongo

 docker run -it --rm -p 8080:80 -e MongoDbSettings:Host=mongo -e MongoDbSettings:Password={password} --network=CatalogAPINetwork catalog:v1

## Push catalog image to docker hub.

Login to docker : docker login

Push tthe image to docker
docker push govindu1/catalog:v1 
Note:created another copy with name govindu1/catalog:v1:docker tag catalog:v1 govindu1/catalog:v1


## Pull image from docker hub

you can use docker pull or > docker run -it --rm -p 8080:80 -e MongoDbSettings:Host=mongo -e MongoDbSettings:Password={password} --network=Net5Tutorial govindu1/catalog:v1





