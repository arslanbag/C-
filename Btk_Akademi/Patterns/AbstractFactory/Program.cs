using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new Factory1());
            productManager.GetAll();
            Console.ReadLine();
        }
    }
    public abstract class Logging 
    {
        public abstract void Log(string message);
    }
    public abstract class Caching
    {
        public abstract void Cache(string data);
    }


    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("LOG4NET : "+message);
        }
    }

    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("NLogger : " + message);
        }
    }
    public class MenCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("MenCache : " + data);
        }
    }
    public class Redis : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Redis : " + data);
        }
    }

    public abstract class CrossCuttingConcernsFactory 
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaching();
    }

    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new Redis();
        }

        public override Logging CreateLogger()
        {
            return new Log4NetLogger();
            
        }
    }

    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new MenCache();
        }

        public override Logging CreateLogger()
        {
            return new NLogger();

        }
    }


     class ProductManager 
    {
        private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;
        private Logging _logging;
        private Caching _caching;

        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _caching = _crossCuttingConcernsFactory.CreateCaching();
            _logging = _crossCuttingConcernsFactory.CreateLogger();
        }

        public void GetAll() 
        {
            _logging.Log("Logglandı");
            _caching.Cache("Cachlendi");
            Console.WriteLine("Ürünler listelendi");
        }
    }
}
