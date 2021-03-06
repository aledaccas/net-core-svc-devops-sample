FROM microsoft/dotnet:sdk AS build-env
WORKDIR /

# Copy csproj and restore as distinct layers
COPY *.sln ./
COPY net-core-svc-devops-sample/net-core-svc-devops-sample.csproj net-core-svc-devops-sample/
COPY net-core-svc-devops-sample-tests/net-core-svc-devops-sample-tests.csproj net-core-svc-devops-sample-tests/
RUN dotnet restore

# Copy everything else and build
COPY . ./
WORKDIR /net-core-svc-devops-sample
RUN dotnet publish -c Release -o /app

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app .
ENTRYPOINT ["dotnet", "net-core-svc-devops-sample.dll"]

EXPOSE 80
