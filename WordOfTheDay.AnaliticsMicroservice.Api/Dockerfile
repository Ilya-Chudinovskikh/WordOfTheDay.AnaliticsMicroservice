FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY WordOfTheDay.AnaliticsMicroservice.Api/*.csproj ./WordOfTheDay.AnaliticsMicroservice.Api/
COPY WordOfTheDay.AnaliticsMicroservice.Domain/*.csproj ./WordOfTheDay.AnaliticsMicroservice.Domain/
COPY WordOfTheDay.AnaliticsMicroservice.Repository/*.csproj ./WordOfTheDay.AnaliticsMicroservice.Repository/
COPY .././SharedModelsLibrary/*.csproj ./SharedModelsLibrary/
RUN dotnet restore "WordOfTheDay.AnaliticsMicroservice.Api/WordOfTheDay.AnaliticsMicroservice.Api.csproj"
COPY . .
WORKDIR "/src/WordOfTheDay.AnaliticsMicroservice.Api"
RUN dotnet build "WordOfTheDay.AnaliticsMicroservice.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WordOfTheDay.AnaliticsMicroservice.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WordOfTheDay.AnaliticsMicroservice.Api.dll"]