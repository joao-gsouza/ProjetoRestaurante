# ---------- Estágio 1: build ----------
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# 1º só os .csproj → restore fica em cache enquanto as dependências não mudarem
COPY ProjetoRestaurante.API/ProjetoRestaurante.API.csproj ProjetoRestaurante.API/
COPY ProjetoRestaurante.Application/ProjetoRestaurante.Application.csproj ProjetoRestaurante.Application/
COPY ProjetoRestaurante.Domain/ProjetoRestaurante.Domain.csproj ProjetoRestaurante.Domain/
COPY ProjetoRestaurante.Infrastructure/ProjetoRestaurante.Infrastructure.csproj ProjetoRestaurante.Infrastructure/
RUN dotnet restore ProjetoRestaurante.API/ProjetoRestaurante.API.csproj

# 2º o resto do código
COPY . .
RUN dotnet publish ProjetoRestaurante.API/ProjetoRestaurante.API.csproj -c Release -o /app/publish --no-restore

# ---------- Estágio 2: runtime ----------
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

USER $APP_UID
EXPOSE 8080
ENTRYPOINT ["dotnet", "ProjetoRestaurante.API.dll"]
