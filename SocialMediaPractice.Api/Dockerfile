FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SocialMediaPractice.Api/SocialMediaPractice.Api.csproj", "SocialMediaPractice.Api/"]
RUN dotnet restore "SocialMediaPractice.Api/SocialMediaPractice.Api.csproj"
COPY . .
WORKDIR "/src/SocialMediaPractice.Api"
RUN dotnet build "SocialMediaPractice.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SocialMediaPractice.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SocialMediaPractice.Api.dll"]
