using System;

namespace TimeTravel.Movie.Core.Models
{
	public class Movie
	{
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int ReleaseDate { get; set; }
        public virtual string MainActor { get; set; }
	}
}