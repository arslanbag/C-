using Northwind.Businness.Abstracts.Type;
using Northwind.Businness.Concretes.Base;
using Northwind.DataAccess.Abstracts.Type;
using Northwind.Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businness.Concretes.Type
{
    public class CategoryManager : BaseManagerMethods<Category>, ICategoryService
    {
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _repository= categoryRepository;

        }
    }
}
