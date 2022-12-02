using Northwind.Businness.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entites.Abstract;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businness.Concrete
{
    public class IBaseManagerMethods <TDal , TEntity>
       where TDal : class, IGroupManager, new()
      where TEntity : class, IEntity , new()

    {
        public List<TEntity> GetAll()
        {
            return Set<TDal>.GetAll();
        }

        public Product Get(Product Entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Product Entity)
        {
            throw new NotImplementedException();
        }
        public void Update(Product Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product Entity)
        {
            throw new NotImplementedException();
        }


    }
}
