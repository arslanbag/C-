using Northwind.DataAccess.Abstract.Group.GGAUP;
using Northwind.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businness.Abstract.Base
{
    public interface IEntityRepositorySignutre<T> : IGGAUP<T> where T: IEntity
    {
    }
}
