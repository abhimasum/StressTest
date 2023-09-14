FROM mcr.microsoft.com/dotnet/sdk:6.0 AS BUILD
WORKDIR /source
COPY /HelloWorld/ .

RUN dotnet restore 
RUN dotnet publish -c release -o /app
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS RUN
WORKDIR /app
COPY --from=build /app .
EXPOSE 80
ENTRYPOINT ["dotnet", "HelloWorld.dll"]