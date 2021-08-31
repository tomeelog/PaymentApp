#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["Web/Api/CentralApi/CentralApi.csproj", "Web/Api/CentralApi/"]
COPY ["Services/CentralApi/CentralApi.Services/CentralApi.Services.csproj", "Services/CentralApi/CentralApi.Services/"]
COPY ["Services/CentralApi/CentralApi.Services.Models/CentralApi.Services.Models.csproj", "Services/CentralApi/CentralApi.Services.Models/"]
COPY ["Data/CentralApi/CentralApi.Models/CentralApi.Models.csproj", "Data/CentralApi/CentralApi.Models/"]
COPY ["Common/BankSystem.Common/BankSystem.Common.csproj", "Common/BankSystem.Common/"]
COPY ["Data/CentralApi/CentralApi.Data/CentralApi.Data.csproj", "Data/CentralApi/CentralApi.Data/"]
RUN dotnet restore "Web/Api/CentralApi/CentralApi.csproj"
COPY . .
WORKDIR "/src/Web/Api/CentralApi"
RUN dotnet build "CentralApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CentralApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CentralApi.dll"]