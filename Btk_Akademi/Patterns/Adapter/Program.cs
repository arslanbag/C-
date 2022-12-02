using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new NuLoggerAdapter());
            productManager.Save();

            Console.ReadLine();
        }
    }

    class ProductManager 
    {
        private Ilogger _logger;

        public ProductManager(Ilogger logger)
        {
            _logger = logger;
        }
        public void Save() 
        {
            _logger.log();
            Console.WriteLine("KayıtEdildi");
        }
    }
    internal interface Ilogger
    {
        void log();
    }

    internal class AAlogger : Ilogger
    {
          public void log() 
        {
            Console.WriteLine("AALogger ile loglandı");
        }
    }

    internal class NuLoggerAdapter : Ilogger
    {
        public void log()
        {
            Nulogger nulogger = new Nulogger();
            nulogger.logMessage();
        }
    }


    //NuGet
    internal class Nulogger 
    {
        public void logMessage()
        {
            Console.WriteLine("NuLogger ile loglandı");
        }
    }
}
