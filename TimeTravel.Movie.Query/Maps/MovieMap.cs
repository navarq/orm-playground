using FluentNHibernate.Mapping;

namespace TimeTravel.Movie.Query.Maps
{
    public class MovieMap : ClassMap<Core.Models.Movie>
    {
        public MovieMap()
        {
            Table("Movies");
            Id(x => x.Id, "MovieId").GeneratedBy.Assigned();
            Map(x=>x.Name).Not.Nullable();
            Map(x => x.ReleaseDate).Not.Nullable();
            Map(x => x.MainActor).Not.Nullable();
        }
    }
}
