using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract.Group.GGAUP
{
    public interface IGetAll<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
