FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Write.API/Write.API.csproj", "Write.API/"]
RUN dotnet restore "Write.API/Write.API.csproj"
COPY . .
WORKDIR "src/Write.API"
RUN dotnet build "Write.API.csproj" -c Release -o /app/build 

FROM build AS publish
RUN dotnet publish "Write.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Write.API.dll"]