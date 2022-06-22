FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:5000
COPY . .
EXPOSE 5000

ENTRYPOINT ["dotnet", "DotNetCoreRESTAPI.dll"]