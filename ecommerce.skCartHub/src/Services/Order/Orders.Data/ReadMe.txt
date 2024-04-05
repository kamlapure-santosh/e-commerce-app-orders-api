To check the installed Entity Framework (EF) versions on your machine, you can use the following steps:

Open a command prompt (cmd) or PowerShell window.
Use the following command to list all installed EF packages for all .NET Core/.NET projects on your machine:

dotnet tool list --global | findstr "dotnet-ef"

if you already have some version and wanted to upgrade use this cmd
dotnet tool update --global dotnet-ef --version 7.0.9 
or
dotnet tool update --global dotnet-ef (this installs latest version)

To install latest EF use 
dotnet tool install --global dotnet-ef

*********************************

To Scaffold databse as model to local project use below cmd.

dotnet ef dbcontext scaffold "Server=Karthik;Initial Catalog=skCartDb;Integrated Security=SSPI; MultipleActiveResultSets=true;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Entities -d


