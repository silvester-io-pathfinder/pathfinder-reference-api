FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build

WORKDIR /build
COPY Sources Sources/

ARG artifactoryUsername
ARG artifactoryPassword

RUN dotnet nuget add source https://silvester.jfrog.io/artifactory/api/nuget/silvester-nuget  -n Artifactory --username $artifactoryUsername --password $artifactoryPassword --store-password-in-clear-text 

RUN dotnet restore ./Sources/Api/Silvester.Pathfinder.Reference.Api.sln 
RUN dotnet test ./Sources/Api/Silvester.Pathfinder.Reference.Api.sln 
RUN dotnet publish ./Sources/Api/Silvester.Pathfinder.Reference.Api.sln -c Release -o /build/publish


FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine AS release

EXPOSE 80
WORKDIR /app
COPY --from=build /build/publish ./

CMD ["dotnet", "Silvester.Pathfinder.Reference.Api.dll"]