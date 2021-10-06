ARG VARIANT=5.0
FROM mcr.microsoft.com/vscode/devcontainers/dotnet:0-${VARIANT}

RUN dotnet nuget add source https://silvester.jfrog.io/artifactory/api/nuget/silvester-nuget  -n Artifactory && dotnet dev-certs https