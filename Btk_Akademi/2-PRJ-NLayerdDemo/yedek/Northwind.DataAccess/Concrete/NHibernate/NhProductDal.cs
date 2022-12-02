using Northwind.DataAccess.Abstract;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            Product product = new Product
            {
                ProductId = 1,
                CategoryId = 1,
                ProductName = "HiberNate",
                QuantityPerUnit = "1 kutu",
                UnitPrice = 10000,
                UnitsInStock = 11
            };
            return new List<Product> { product };
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
