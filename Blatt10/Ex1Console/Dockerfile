FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Ex1Console/Ex1Console.csproj", "Ex1Console/"]
RUN dotnet restore "Ex1Console/Ex1Console.csproj"
COPY . .
WORKDIR "/src/Ex1Console"
RUN dotnet build "Ex1Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ex1Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ex1Console.dll"]
