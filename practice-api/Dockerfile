FROM microsoft/aspnetcore-build:2.0

WORKDIR /app

# Copy the whole project into the container
COPY ./ .

RUN dotnet restore
RUN dotnet build
RUN dotnet publish -o ./out

WORKDIR /app/out

ENTRYPOINT [ "dotnet", "practice-api.dll" ]