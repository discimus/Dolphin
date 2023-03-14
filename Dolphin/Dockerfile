#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Dolphin/Dolphin.csproj", "Dolphin/"]
RUN dotnet restore "Dolphin/Dolphin.csproj"
COPY . .
WORKDIR "/src/Dolphin"
RUN dotnet build "Dolphin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dolphin.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dolphin.dll"]