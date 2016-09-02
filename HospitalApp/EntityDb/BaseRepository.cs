using System;
using System.Linq;
using System.Linq.Expressions;
using EntityDb.Context;
using EntityDb.DAL;

namespace EntityDb
{
    public class BaseRepository<T> where T : HeaderID 
    {
        private HospitalDbContext _context = new HospitalDbContext();

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }
    }
}