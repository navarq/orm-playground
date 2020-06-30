using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TimeTravel.Movie.Query.Init;

namespace TimeTravel.Movie.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMapperSession _session;

        public MovieController(IMapperSession session)
        {
            _session = session;
        }

        [Route("")]
        public IEnumerable<Movie> Index()
        {
            return _session.Movies.Select(x => new Movie
            {
                Name = x.Name,
                ReleaseYear = x.ReleaseDate,
                MainActor = x.MainActor
            }).ToArray();
        }
    }
}
