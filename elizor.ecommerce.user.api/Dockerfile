#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["elizor.ecommerce.user.api/elizor.ecommerce.user.api.csproj", "elizor.ecommerce.user.api/"]
COPY ["elizor.ecommerce.user.dbcontext.tables/elizor.ecommerce.user.dbcontext.tables.csproj", "elizor.ecommerce.user.dbcontext.tables/"]
COPY ["elizor.ecommerce.user.entities/elizor.ecommerce.user.entities.csproj", "elizor.ecommerce.user.entities/"]
COPY ["elizor.ecommerce.user.shared/elizor.ecommerce.user.shared.csproj", "elizor.ecommerce.user.shared/"]
COPY ["elizor.ecommerce.user.data/elizor.ecommerce.user.data.csproj", "elizor.ecommerce.user.data/"]
COPY ["elizor.ecommerce.user.contracts/elizor.ecommerce.user.contracts.csproj", "elizor.ecommerce.user.contracts/"]
COPY ["elizor.ecommerce.user.business/elizor.ecommerce.user.business.csproj", "elizor.ecommerce.user.business/"]
RUN dotnet restore "elizor.ecommerce.user.api/elizor.ecommerce.user.api.csproj"
COPY . .
WORKDIR "/src/elizor.ecommerce.user.api"
RUN dotnet build "elizor.ecommerce.user.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "elizor.ecommerce.user.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "elizor.ecommerce.user.api.dll"]