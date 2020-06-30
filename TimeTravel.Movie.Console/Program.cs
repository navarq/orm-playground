using System;
using System.Configuration;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using Microsoft.Extensions.DependencyInjection;
using TimeTravel.Movie.Console.Extension;
using TimeTravel.Movie.Query.Init;

namespace TimeTravel.Movie.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = Fluently.Configure()
                .Database(PostgreSQLConfiguration.Standard
                    .ConnectionString(cs =>
                        cs.Host("localhost")
                            .Database("timetravelmovies")
                            .Username("timetraveller")
                            .Password("")
                            .Port(5432)))
                .Mappings(m=>m.FluentMappings.AddFromAssemblyOf<TimeTravel.Movie.Query.Maps.MovieMap>())
                .BuildConfiguration();
                
            var sessionFactory = config.BuildSessionFactory();

            IServiceCollection services = new ServiceCollection();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());
            services.AddScoped<IMapperSession, MapperSession>();

            System.Console.WriteLine("Press the any key to exit!");
            System.Console.ReadKey();
        }
    }
}