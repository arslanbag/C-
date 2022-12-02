using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Abstract;
using Northwind.Businness.Abstract;

namespace Northwind.Businness.Concrete
{
    public class ProductManager : IProductService, IGroupManager
    {

        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
  


 
    }
}
