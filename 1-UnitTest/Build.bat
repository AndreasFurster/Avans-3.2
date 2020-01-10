dotnet clean UnitTesting.sln
dotnet restore UnitTesting.sln --force
dotnet build UnitTesting.sln /p:Configuration=Release /p:Platform="Any CPU"
pause