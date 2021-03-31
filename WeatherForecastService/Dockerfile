FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WeatherForecastService/WeatherForecastService.csproj", "WeatherForecastService/"]

RUN dotnet restore "WeatherForecastService/WeatherForecastService.csproj"
COPY . .
WORKDIR "/src/WeatherForecastService"
RUN dotnet build "WeatherForecastService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WeatherForecastService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WeatherForecastService.dll"]