FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MT200412272.csproj", ""]
RUN dotnet restore "./MT200412272.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "MT200412272.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MT200412272.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MT200412272.dll"]