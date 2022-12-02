using Northwind.Businness.Abstracts.Type;
using Northwind.Businness.Concretes.Base;
using Northwind.Businness.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstracts.Type;
using Northwind.DataAccess.Concretes.EntityFramework.Type;
using Northwind.Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businness.Concretes.Type
{
    public class ProductManager : BaseManagerMethods<Product> , IProductService
    {
        public ProductManager(IProductRepository productRepository)
        {
            _repository = productRepository;
            _validator = new ProductValidator();
        }
    }
}
