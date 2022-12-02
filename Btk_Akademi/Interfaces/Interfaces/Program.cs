using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager person = new PersonManager();
            Customer customer = new Customer { Id=1 , FirstName = "Ayk", LastName = "Ars"  };
            Sutudent sutudent = new Sutudent { Id=1 , FirstName = "Ayk2", LastName = "Ars2"  };
            person.add(sutudent);

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServer());

            ICustomerDal[] customerDals = new ICustomerDal[2] 
            {
                new SqlServer(),
                new OracleServer(),
            };

            foreach (var item in customerDals)
            {
                customerManager.Add(item);
            }
            Console.ReadLine();

        }
    }
    interface IPerson
    {
        int Id { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

    }
    class Sutudent : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Depertmant { get; set; }
    }

    class PersonManager 
    {
        public void add(IPerson person) 
        {
            Console.WriteLine(person.FirstName);

        }
    }
}
