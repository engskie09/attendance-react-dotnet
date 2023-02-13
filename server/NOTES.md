"""Dependencies"""
- .NET Core 7.0.0

""Commands to RUN""

Dependencies Installation
- dotnet tool install --global dotnet-ef
- dotnet tool update --global dotnet-ef

to run the APP
- dotnet build
- dotnet run

""Database related Commands""
- dotnet ef migrations add "Initial Migrations"
- dotnet ef database update