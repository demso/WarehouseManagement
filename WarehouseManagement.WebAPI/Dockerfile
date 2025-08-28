FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app

ENV ASPNETCORE_HTTP_PORTS=80
ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["WarehouseManagement.WebAPI/WarehouseManagement.WebAPI.csproj", "WarehouseManagement.WebAPI/"]
COPY ["WarehouseManagement.Application/WarehouseManagement.Application.csproj", "WarehouseManagement.Application/"]
COPY ["WarehouseManagement.Domain/WarehouseManagement.Domain.csproj", "WarehouseManagement.Domain/"]
COPY ["WarehouseManagement.Persistence/WarehouseManagement.Persistence.csproj", "WarehouseManagement.Persistence/"]
RUN dotnet restore "WarehouseManagement.WebAPI/WarehouseManagement.WebAPI.csproj"
COPY . .
WORKDIR "/src/WarehouseManagement.WebAPI"
RUN dotnet build "./WarehouseManagement.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./WarehouseManagement.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WarehouseManagement.WebAPI.dll"]
