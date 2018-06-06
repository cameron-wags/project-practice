FROM microsoft/aspnetcore-build:2.0 AS build

WORKDIR /app

# only copy the project file before restoring so that we only restore when packages are added
COPY ./practice-api.csproj .
RUN dotnet restore

# Copy the whole project into the container
COPY ./ .

RUN dotnet build --no-restore

FROM build AS package
RUN dotnet publish -o ./out/

FROM microsoft/aspnetcore:2.0 AS runtime
WORKDIR /app
COPY --from=package /app/out/ .

ENTRYPOINT [ "dotnet", "practice-api.dll" ]