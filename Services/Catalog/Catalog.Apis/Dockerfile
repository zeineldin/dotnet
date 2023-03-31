#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

###############################   Build   ###############################
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base      
WORKDIR /app									      
EXPOSE 80										      

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build  
WORKDIR /src
COPY ["Services/Catalog/Catalog.Apis/Catalog.Apis.csproj", "Services/Catalog/Catalog.Apis/"]
RUN dotnet restore "Services/Catalog/Catalog.Apis/Catalog.Apis.csproj"
COPY . .
WORKDIR "/src/Services/Catalog/Catalog.Apis"
RUN dotnet build "Catalog.Apis.csproj" -c Release -o /app/build

# Depend on SDK DotNetCore6
# sets the working directory
# default port for an HTTP server
#-------
## copies the source code into the container, restores dependencies, and builds the application
## indicates that the application is being built in Release mode
## the output directory for the build artifacts.



###############################   Publish   ###############################
FROM build AS publish
RUN dotnet publish "Catalog.Apis.csproj" -c Release -o /app/publish /p:UseAppHost=false

## publishes the application
## indicates that the application is being published in Release mode
## output directory for the published artifacts.
## application should be published without an application host, which reduces the size of the final image


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Catalog.Apis.dll"]

#  stage sets up the final image, copies the published artifacts from the "app/publish" stage, sets the working directory to "/app", 

#  ENTRYPOINT : when the container starts, it will run the Catalog.Apis.dll