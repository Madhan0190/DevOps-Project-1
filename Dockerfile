FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["src/HelloDevOps.Api/HelloDevOps.Api.csproj", "src/HelloDevOps.Api/"]
RUN dotnet restore "src/HelloDevOps.Api/HelloDevOps.Api.csproj"

COPY . .
WORKDIR /src/src/HelloDevOps.Api
RUN dotnet publish "HelloDevOps.Api.csproj" --configuration Release --output /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "HelloDevOps.Api.dll"]