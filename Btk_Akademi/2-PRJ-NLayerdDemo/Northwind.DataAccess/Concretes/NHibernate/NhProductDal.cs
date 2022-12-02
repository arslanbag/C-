using Northwind.DataAccess.Abstracts.Type;
using Northwind.Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concretes.NHibernate
{
    public class NhProductDal : IProductRepository
    {
        public void Add(Product Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product Entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
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

        public void Update(Product Entity)
        {
            throw new NotImplementedException();
        }
    }
}
