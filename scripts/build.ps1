$ErrorActionPreference = "Stop"

$rootDir = "."
$project = "$rootDir/Plugin/Plugin.csproj"

$buildDir = "$rootDir/Plugin/bin/Release/net472"
$outDir = "$rootDir/out"
$thunderstoreFiles = @("$rootDir/manifest.json", "$rootDir/icon.png", "$rootDir/README.md")


if (Test-Path $outDir) {
    Remove-Item $outDir -Recurse -Force
}

New-Item $outDir -ItemType Directory -Force

# Build the project
dotnet clean "$project" --configuration Release
dotnet build "$project" --configuration Release

# Prepare paths for compression
$allFiles = @("$buildDir/*") + $thunderstoreFiles

# Compress everything into a ZIP file
Compress-Archive -Path $allFiles -DestinationPath "$outDir/plugin.zip" -Force
