using Northwind.Businness.Abstracts.Base;
using Northwind.DataAccess.Abstracts.Base;
using Northwind.Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businness.Abstracts.Type
{   
    public interface ICategoryService : IBaseServiceSignature<Category>
    {
    }
}
