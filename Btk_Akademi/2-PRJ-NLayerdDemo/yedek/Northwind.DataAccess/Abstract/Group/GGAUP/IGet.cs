using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract.Group.Method
{
    public interface IGet<T>
    {
        T Get(Expression<Func<T, bool>> filter);
    }
}
