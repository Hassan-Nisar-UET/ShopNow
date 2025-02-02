FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/ShopNow.Web.Host/ShopNow.Web.Host.csproj", "src/ShopNow.Web.Host/"]
COPY ["src/ShopNow.Web.Core/ShopNow.Web.Core.csproj", "src/ShopNow.Web.Core/"]
COPY ["src/ShopNow.Application/ShopNow.Application.csproj", "src/ShopNow.Application/"]
COPY ["src/ShopNow.Core/ShopNow.Core.csproj", "src/ShopNow.Core/"]
COPY ["src/ShopNow.EntityFrameworkCore/ShopNow.EntityFrameworkCore.csproj", "src/ShopNow.EntityFrameworkCore/"]
WORKDIR "/src/src/ShopNow.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ShopNow.Web.Host", "src/ShopNow.Web.Host"]
COPY ["src/ShopNow.Web.Core", "src/ShopNow.Web.Core"]
COPY ["src/ShopNow.Application", "src/ShopNow.Application"]
COPY ["src/ShopNow.Core", "src/ShopNow.Core"]
COPY ["src/ShopNow.EntityFrameworkCore", "src/ShopNow.EntityFrameworkCore"]
WORKDIR "/src/src/ShopNow.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ShopNow.Web.Host.dll"]
