using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager.getCustomerManager();
        }

        class CustomerManager 
        {

            private static CustomerManager _customerManager;
            static object _lookObject = new object();

            private CustomerManager() { }
            public static CustomerManager getCustomerManager() 
            {
               // return _customerManager ?? (_customerManager = new CustomerManager()); 
                //_customerManager boş ise diğerini göndeer
                lock(_lookObject) 
                {
                    if (_customerManager == null)
                    {
                        _customerManager = new CustomerManager();
                    }
                    return _customerManager;
                }
            }

        }
    }
}
