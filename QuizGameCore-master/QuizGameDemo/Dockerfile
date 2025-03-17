FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["QuizGameDemo/QuizGameDemo.csproj", "QuizGameDemo/"]
RUN dotnet restore "QuizGameDemo/QuizGameDemo.csproj"
COPY . .
WORKDIR "/src/QuizGameDemo"
RUN dotnet build "QuizGameDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QuizGameDemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QuizGameDemo.dll"]
