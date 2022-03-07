using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BitaFacts.Core.Interface
{
    public interface IRepository<TModel> where TModel : class
    {
        TModel Get(int id);
        IEnumerable<TModel> GetAll();
        IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate);
        bool Add(TModel model);
        bool AddRange(IEnumerable<TModel> models);
        bool Remove(TModel model);
        bool RemoveRange(IEnumerable<TModel> models);
        bool Update(TModel model);
        bool UpdateRange(IEnumerable<TModel> models);
    }
}
