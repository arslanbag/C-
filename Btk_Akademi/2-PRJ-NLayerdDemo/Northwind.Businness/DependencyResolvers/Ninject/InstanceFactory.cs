using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businness.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetIstance<T>() 
        {
            var kernel = new StandardKernel(new BusinnesModule());
            return kernel.Get<T>();
        }
            
    }
}
