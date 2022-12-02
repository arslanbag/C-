using Northwind.DataAccess.Abstract.Group.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract.Group.GGAUP
{
    public interface IGGAUP<T> : IGet<T>, IGetAll<T>, IAdd<T>, IUpdate<T>, IDelete<T>
    {
    }
}
