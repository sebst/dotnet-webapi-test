```bash
dotnet new webapi --use-controllers
dotnet dev-certs https --trust
```

```bash
mkdir Models
touch Models/SessionItem.cs
```


```bash
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet tool uninstall -g dotnet-aspnet-codegenerator
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool update -g dotnet-aspnet-codegenerator
```

```bash
dotnet aspnet-codegenerator controller -name SessionController -async -api -m SessionItem -dc SessionContext -outDir Controllers
```