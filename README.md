

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

```
mkdir TimeTravel.Movie.Api
```


Create the webapi application
```
cd TimeTravel.Movie.Api
dotnet new webapi
```

Add a reference to the Fluent NHibernate package
``` 
dotnet add package Npgsql -Version 4.1.3.1
dotnet add package FluentNHibernate -v 2.1.2
```

Go up one and add reference to solution project
```
cd ..
dotnet sln orm-playground.sln add TimeTravel.Movie.Console/TimeTravel.Movie.Console.csproj
```


don't forget to go into properties and change the launch settings json  to add the new api/movie route instead of WeatherForecast


To add trust to the app do
```
dotnet dev-certs https --trust
```

Select yes in the dialog to trust http://localhost:5001

Then simple do the following to run the app
```
dotnet run
```

within then same folder ()

