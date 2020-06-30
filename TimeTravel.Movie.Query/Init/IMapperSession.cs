using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTravel.Movie.Query.Init
{
    public interface IMapperSession
    {
        void BeginTransaction();
        Task Commit();
        Task Rollback();
        void CloseTransaction();
        Task Save(Core.Models.Movie entity);
        Task Delete(Core.Models.Movie entity);

        IQueryable<Core.Models.Movie> Movies { get; }
    }
}
