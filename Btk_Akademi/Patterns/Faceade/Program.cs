using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faceade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.save();

            Console.ReadLine();
        }
    }
    class Logging : ILogging
    {
        public void Log() 
        {
            Console.WriteLine("Loglandı");
        }
    }

    internal interface ILogging
    {
        void Log();
    }

    class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Önbelleğe Alındı ");
        }
    }

    internal interface ICaching
    {
        void Cache();
    }

    class Authorize : IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("Kullanıcı Kontrol Edildi");
        }
    }

    internal interface IAuthorize
    {
        void CheckUser();
    }

    class CustomerManager 
    {
        /* private ILogging _logging;
         private ICaching _caching;
         private IAuthorize _authorize;*/
        //yorum satıları yerine
        private CrossCuttongConcernsFacede _concerns;

       // public CustomerManager(ILogging logging, ICaching caching, IAuthorize authorize)
        public CustomerManager()
        {
            /* _logging = logging;
             _caching = caching;
             _authorize = authorize;*/

            _concerns = new CrossCuttongConcernsFacede();
        }
        public void save() 
        {
           /* _logging.Log();
            _caching.Cache();
            _authorize.CheckUser();*/
            _concerns.logging.Log(); 
            _concerns.caching.Cache();
            _concerns.authorize.CheckUser();

            Console.WriteLine("Kayıt Edildi ");
        }
     }
    class CrossCuttongConcernsFacede 
    {
        public ILogging logging;
        public ICaching caching;
        public IAuthorize authorize;

        public CrossCuttongConcernsFacede()
        {
            logging = new Logging();
            caching = new Caching();
            authorize = new Authorize();
        }
    }
}
