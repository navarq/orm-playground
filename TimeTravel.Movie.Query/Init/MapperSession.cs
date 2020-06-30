using NHibernate;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTravel.Movie.Query.Init
{
    public class MapperSession : IMapperSession
    {
        private readonly ISession _session;
        private ITransaction _transaction;

        public MapperSession(ISession session)
        {
            _session = session;
        }

        public void BeginTransaction()
        {
            _transaction = _session.BeginTransaction();
        }

        public async Task Commit()
        {
            await _transaction.CommitAsync();
        }

        public async Task Rollback()
        {
            await _transaction.RollbackAsync();
        }

        public void CloseTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public async Task Save(Core.Models.Movie entity)
        {
            await _session.SaveOrUpdateAsync(entity);
        }

        public async Task Delete(Core.Models.Movie entity)
        {
            await _session.DeleteAsync(entity);
        }

        public IQueryable<Core.Models.Movie> Movies => _session.Query<Core.Models.Movie>();
    }
}
