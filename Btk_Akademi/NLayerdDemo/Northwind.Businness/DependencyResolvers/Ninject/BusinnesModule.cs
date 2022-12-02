using Ninject.Modules;
using Northwind.Businness.Abstracts.Type;
using Northwind.Businness.Concretes.Type;
using Northwind.DataAccess.Abstracts.Type;
using Northwind.DataAccess.Concretes.EntityFramework.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businness.DependencyResolvers.Ninject
{
    public class BusinnesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope(); //sonuncusu katmanlar arası geçişler için tekrar kullanılmaması için
            Bind<IProductRepository>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryRepository>().To<EfCategoryDal>().InSingletonScope();
        }
    }
}
