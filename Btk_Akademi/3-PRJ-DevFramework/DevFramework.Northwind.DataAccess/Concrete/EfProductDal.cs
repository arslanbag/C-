using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.Northwind.DataAccess.Abstracts;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext> ,IProductDal
    {
        public List<Product> GetList(Expression<Func<Product, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
 
        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }
        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Product entity)
        {
            throw new NotImplementedException();
        }
     
    }
}
