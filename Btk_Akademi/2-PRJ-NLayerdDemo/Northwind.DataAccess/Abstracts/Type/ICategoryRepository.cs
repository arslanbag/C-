using Northwind.DataAccess.Abstracts.Base;
using Northwind.Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstracts.Type
{
    public interface ICategoryRepository : IBaseRepositorySignature<Category>
    {
    }
}
