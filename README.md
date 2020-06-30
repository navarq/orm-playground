

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

make a directory called models
```
mkdir Models
``

Add a reference to the Fluent NHibernate package
``` 
dotnet add package FluentNHibernate -v 2.1.2
```
