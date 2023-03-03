FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["LegoBackend/LegoBackend.csproj", "LegoBackend/"]
RUN dotnet restore "LegoBackend/LegoBackend.csproj"
COPY . .
WORKDIR "/src/LegoBackend"
RUN dotnet build "LegoBackend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LegoBackend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LegoBackend.dll"]
