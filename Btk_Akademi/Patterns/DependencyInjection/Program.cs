using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EfProductDal productDal = new EfProductDal();
            productDal.Save();

            Console.ReadLine();
        }
    }
    interface IProductDal
    {
        void Save();
    }
    class EfProductDal : IProductDal
    {
        public void Save() 
        {
            Console.Write("Ürün Ef ile Kayıt Edildi");
        }   
    }
    class NhProductDal : IProductDal
    {
        public void Save()
        {
            Console.Write("Ürün Nh ile Kayıt Edildi");
        }
    }

    class ProductManager
    {
        IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public void Save()
        {
            productDal.Save();
        }
    }
}
