using Northwind.DataAccess.Abstracts.Type;
using Northwind.DataAccess.Concretes.EntityFramework.Base;
using Northwind.DataAccess.Concretes.EntityFramework.Config;
using Northwind.Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concretes.EntityFramework.Type
{
    public class EfCategoryDal : BaseDaoMethods<Category, NorthwindContext> , ICategoryRepository
    {

    }
}
