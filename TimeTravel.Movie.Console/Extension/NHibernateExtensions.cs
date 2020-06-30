using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.DependencyInjection;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using TimeTravel.Movie.Query.Init;

namespace TimeTravel.Movie.Console.Extension
{
    public static class NHibernateExtensions
    {
        public static IServiceCollection AddHibernate(this IServiceCollection services)
        {
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(NHibernateExtensions).Assembly.ExportedTypes);
            HbmMapping domainMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

            var configuration = Fluently.Configure()
                .Database(PostgreSQLConfiguration.Standard
                    .ConnectionString(cs =>
                        cs.Host("localhost")
                            .Database("timetravelmovies")
                            .Username("timetraveller")
                            .Password("")
                            .Port(5432)))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<TimeTravel.Movie.Query.Maps.MovieMap>())
                .BuildConfiguration();

            configuration.AddMapping(domainMapping);

            var sessionFactory = configuration.BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());
            services.AddScoped<IMapperSession, MapperSession>();

            return services;
        }
    }
}
