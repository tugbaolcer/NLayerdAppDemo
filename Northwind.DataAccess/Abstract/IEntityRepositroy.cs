using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    //Burda böyle yapmamızın sebebi tipleri değişse bile generic tip ona göre şekil alacak.
    public interface IEntityRepositroy<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression <Func<T, bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
