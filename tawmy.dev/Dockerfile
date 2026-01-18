FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG TARGETARCH

RUN case "${TARGETARCH}" in \
        "arm64")  TW_ARCH="arm64" ;; \
        *)        TW_ARCH="x64" ;; \
    esac && \
    curl -sLO https://github.com/tailwindlabs/tailwindcss/releases/download/v4.1.18/tailwindcss-linux-${TW_ARCH} && \
    chmod +x tailwindcss-linux-${TW_ARCH} && \
    mv tailwindcss-linux-${TW_ARCH} /usr/local/bin/tailwindcss

ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["tawmy.dev/tawmy.dev.csproj", "tawmy.dev/"]
RUN dotnet restore "tawmy.dev/tawmy.dev.csproj"
COPY . .
WORKDIR "/src/tawmy.dev"
RUN dotnet build "tawmy.dev.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "tawmy.dev.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "tawmy.dev.dll"]
