FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Ug.BalanzaDigital.Gestor/Ug.BalanzaDigital.Gestor.csproj", "Ug.BalanzaDigital.Gestor/"]
RUN dotnet restore "Ug.BalanzaDigital.Gestor/Ug.BalanzaDigital.Gestor.csproj"
COPY . .
WORKDIR "/src/Ug.BalanzaDigital.Gestor"
RUN dotnet build "Ug.BalanzaDigital.Gestor.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Ug.BalanzaDigital.Gestor.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ug.BalanzaDigital.Gestor.dll"]
