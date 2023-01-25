FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["SocialMediaPractice/SocialMediaPractice.csproj", "SocialMediaPractice/"]
RUN dotnet restore "SocialMediaPractice/SocialMediaPractice.csproj"
COPY . .
WORKDIR "/src/SocialMediaPractice"
RUN dotnet build "SocialMediaPractice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SocialMediaPractice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SocialMediaPractice.dll"]
