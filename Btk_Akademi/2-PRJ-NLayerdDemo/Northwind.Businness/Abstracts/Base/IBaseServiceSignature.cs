using Northwind.DataAccess.Abstracts.Base;
using Northwind.Entites.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businness.Abstracts.Base
{
    public interface IBaseServiceSignature<T> : IBaseRepositorySignature<T> where T : class, IGroupEntity, new()
    {

    }
}
