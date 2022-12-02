using Northwind.DataAccess.Abstract;
using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    internal class EfCategoryDal : EfEntityDaoBase<Category ,NorthwindContext>, ICategoryDal
    {
    }
}
