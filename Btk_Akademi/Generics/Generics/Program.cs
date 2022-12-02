using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    //generics 2
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer(), new Customer(), new Customer());
        }

    }
    class Utilities 
    {
        public List<T> BuildList<T>(params T[] items) 
        {
            return new List<T>(items);      
        }
    } 




    //Generic -1 

    class Product:IEntity { }

    class Customer:IEntity{}
    //--------------------

    //customer
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer product)
        {throw new NotImplementedException(); }
    }

    interface ICustomerDal: IRepository<Customer> 
    { }

    //product
 
    class ProductDal : IProductDal
    {
        public void Add(Customer product)
        {
            throw new NotImplementedException();
        }
    }

    interface IProductDal : IRepository<Customer> 
    { }

    ///repository------------

    interface 
        IRepository<T> /*Generic -3 kısıtları */ 
        where T : class /*class demek referans tip olması zorunlu demek*/
        ,IEntity /*Sadece bu Soydan gelebilir*/
        , new() /* newlenebilir bir nesne olması gerekir */
        //,struct  /* sadece değer tipler(int,float..) olabilir*/
    {
        void Add(T product);
    }

    /*Generic -3 kısıtları */
    class Student : IEntity 
    {
    
    }
    interface IEntity 
    {
        
    }



}
