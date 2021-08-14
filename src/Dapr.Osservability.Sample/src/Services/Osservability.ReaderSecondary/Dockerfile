#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Services/Osservability.ReaderSecondary/Osservability.ReaderSecondary.csproj", "src/Services/Osservability.ReaderSecondary/"]
RUN dotnet restore "src/Services/Osservability.ReaderSecondary/Osservability.ReaderSecondary.csproj"
COPY . .
WORKDIR "/src/src/Services/Osservability.ReaderSecondary"
RUN dotnet build "Osservability.ReaderSecondary.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Osservability.ReaderSecondary.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Osservability.ReaderSecondary.dll"]