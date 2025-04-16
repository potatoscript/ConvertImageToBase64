# ==============================
# 🛠️  Stage 1: Build
# ==============================
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set working directory inside the container
WORKDIR /src

# Copy csproj files and restore
COPY ConvertImageToBase64.Lib/ConvertImageToBase64.Lib.csproj ConvertImageToBase64.Lib/
COPY ConvertImageToBase64.Console/ConvertImageToBase64.Console.csproj ConvertImageToBase64.Console/
RUN dotnet restore ConvertImageToBase64.Console/ConvertImageToBase64.Console.csproj

# Copy the rest of the source code
COPY . .

# Build the console app
RUN dotnet publish ConvertImageToBase64.Console/ConvertImageToBase64.Console.csproj -c Release -o /app/publish

# ==============================
# 🚀 Stage 2: Run
# ==============================
FROM mcr.microsoft.com/dotnet/runtime:6.0

WORKDIR /app

COPY --from=build /app/publish .

# Set the entry point of the console app
ENTRYPOINT ["dotnet", "ConvertImageToBase64.Console.dll"]
