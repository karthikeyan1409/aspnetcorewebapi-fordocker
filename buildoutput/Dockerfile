FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY ./buildoutput .

ENTRYPOINT ["dotnet", "DotNetCoreRESTAPI.dll"]