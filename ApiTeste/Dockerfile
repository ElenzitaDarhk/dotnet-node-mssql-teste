FROM mcr.microsoft.com/dotnet/aspnet:8.0-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 5220

ENV ASPNETCORE_URLS=http://+:5220

FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
ARG configuration=Release
WORKDIR /src
COPY ["ApiTeste/ApiTeste.csproj", "ApiTeste/"]
RUN dotnet restore "ApiTeste\ApiTeste.csproj"
COPY . .
WORKDIR "/src/ApiTeste"
RUN dotnet build "ApiTeste.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "ApiTeste.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiTeste.dll"]
