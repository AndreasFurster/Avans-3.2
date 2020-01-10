dotnet clean UnitTesting.sln
nuget restore UnitTesting.sln -force -OutputDirectory packages
dotnet build UnitTesting.sln /p:Configuration=Release /p:Platform="Any CPU"
pause