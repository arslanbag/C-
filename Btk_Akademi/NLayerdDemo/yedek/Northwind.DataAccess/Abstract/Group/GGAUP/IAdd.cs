using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract.Group.GGAUP
{
    public interface IAdd<T>
    {
        void Add(T entity);
    }
}
