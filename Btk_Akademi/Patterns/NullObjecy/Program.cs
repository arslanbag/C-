using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjecy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(StubLogger.GetLogger());
            customerManager.Save();

            CustomerManagerTests customerManagerTests = new CustomerManagerTests();
            customerManagerTests.Save();

            Console.ReadLine();

        }
    }

    interface ILogger
    {
        void Log();
    }

    class CustomerManager
    {
      private ILogger _logger;

        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save() 
        {
            Console.WriteLine("Kayıt edildi");
            _logger.Log();
        }
    }

    class Log4NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("lOG4 logger");
        }
    }
    class NLogLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("NLOG logger");
        }
    }
    class StubLogger : ILogger
    {
        private static StubLogger _stubLogger;
        private static object _lock = new object();

        private StubLogger()
        {

        }
        public static StubLogger GetLogger()
        {
            lock (_lock) 
            {
                if(_stubLogger==null)
                    _stubLogger= new StubLogger();  
            }
            return _stubLogger;
        }
        public void Log()
        {
           
        }
    }

    class CustomerManagerTests 
    {
        public void Save() 
        {
            CustomerManager customerManager = new CustomerManager(StubLogger.GetLogger());
            customerManager.Save();
        }
    }
}
