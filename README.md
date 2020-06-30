

Create a directory to hold a new project
```
mkdir ormplayground
```

Create a solution file
```
dotnet new sln
```

Create a class library project dll to hold the ORM project
```
dotnet new classlib -n TimeTravel.Movie.Orm
```

```
cd TimeTravel.Movie.Orm
```

Make a directory called models
```
mkdir Models
```

Add a reference to the Fluent NHibernate package
``` 
dotnet add package FluentNHibernate -v 2.1.2
```

```
mkdir TimeTravel.Movie.Console
```


Create the console application
```
dotnet new console
```

Go up one and add reference to solution project
```
dotnet sln orm-playground.sln add TimeTravel.Movie.Core/TimeTravel.Movie.Core.csproj
```
