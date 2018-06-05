FROM microsoft/aspnetcore-build:2.0

WORKDIR /app

# only copy the project file before restoring so that we only restore when packages are added
COPY ./practice-api.csproj .
RUN dotnet restore

# Copy the whole project into the container
COPY ./ .

RUN dotnet build
RUN dotnet publish -o ./out/

WORKDIR /app/out
ENTRYPOINT [ "dotnet", "practice-api.dll" ]