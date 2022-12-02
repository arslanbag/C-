using Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entites.Abstract;
using Northwind.DataAccess.Abstract.Group.GGAUP;

namespace Northwind.DataAccess.Abstract
{
    public interface IRepositorySignutere<T> :IGGAUP<T> where T: class, IEntity,  new()
    {

    }
}
