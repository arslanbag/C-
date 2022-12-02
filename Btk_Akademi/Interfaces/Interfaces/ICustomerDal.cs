using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServer : ICustomerDal
    {
        String head = "Sql";
        public void Add()
        {
            Console.WriteLine(head + "Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine(head + "Silindi");
        }

        public void Update()
        {
            Console.WriteLine(head + "Güncellendi");
        }
    }
    class OracleServer : ICustomerDal
    {
        String head = "Oracle";
        public void Add()
        {
            Console.WriteLine(head + "Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine(head + "Silindi");
        }

        public void Update()
        {
            Console.WriteLine(head + "Güncellendi");
        }
    }

    class CustomerManager 
    {
 
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
