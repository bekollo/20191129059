#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["satis-backend/satis-backend.csproj", "satis-backend/"]
RUN dotnet restore "satis-backend/satis-backend.csproj"
COPY . .
WORKDIR "/src/satis-backend"
RUN dotnet build "satis-backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "satis-backend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "satis-backend.dll"]
