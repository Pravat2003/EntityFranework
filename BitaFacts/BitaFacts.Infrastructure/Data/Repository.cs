using BitaFacts.Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BitaFacts.Infrastructure.Data
{
    public class Repository<TModel> : IRepository<TModel> where TModel : class
    {
        // It is protected, because other child classes have access.
        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }
        public TModel Get(int id)
        {
            return _context.Set<TModel>().Find(id);
        }

        public IEnumerable<TModel> GetAll()
        {
            return _context.Set<TModel>().ToList();
        }

        public IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate)
        {
            return _context.Set<TModel>().Where(predicate);
        }

        public bool Add(TModel model)
        {
            _context.Set<TModel>().Add(model);
            SaveChanges();
            return true;
        }

        public bool AddRange(IEnumerable<TModel> models)
        {
            _context.Set<TModel>().AddRange(models);
            SaveChanges();
            return true;
        }

        public bool Remove(TModel model)
        {
            _context.Set<TModel>().Remove(model);
            SaveChanges();
            return true;
        }

        public bool Update(TModel model)
        {
            _context.Set<TModel>().Update(model);
            SaveChanges();
            return true;
        }

        public bool RemoveRange(IEnumerable<TModel> models)
        {
            _context.Set<TModel>().RemoveRange(models);
            SaveChanges();
            return true;
        }

        public bool UpdateRange(IEnumerable<TModel> models)
        {
            _context.Set<TModel>().UpdateRange(models);
            SaveChanges();
            return true;
        }

        private void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
