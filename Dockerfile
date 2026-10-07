FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY ["NutriEscolarPlus.Web.csproj", "./"]

RUN dotnet restore "NutriEscolarPlus.Web.csproj"

COPY . .

RUN dotnet publish "NutriEscolarPlus.Web.csproj" \
    -c Release \
    -o /app/publish \
    --no-restore


FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:10000
ENV ASPNETCORE_ENVIRONMENT=Production

EXPOSE 10000

ENTRYPOINT ["dotnet", "NutriEscolarPlus.Web.dll"]