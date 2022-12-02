using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new LoggerFactoryA());
            customerManager.Save();
            Console.ReadLine();
        }



    }
    class CustomerManager 
    {
        private ILoggerFactory _loggerFactory;
        public CustomerManager(ILoggerFactory loggerFactory) 
        {
            _loggerFactory = loggerFactory;
        }    

        public void Save() 
        {
            Console.WriteLine("Kayıt Edildi");
            ILogger logger = _loggerFactory.createLogger();
            logger.log();
        }
    
    }

    class LoggerFactoryA : ILoggerFactory
    {
        public ILogger createLogger() 
        {
            return new LogA();
        } 
    }

    class LoggerFactoryB : ILoggerFactory
    {
        public ILogger createLogger()
        {
            return new LogB();
        }
    }


    class LogA : ILogger
     { 
        public void log() 
        {
            Console.WriteLine("A Loglandı");
        }
     }

    class LogB : ILogger
    {
        public void log()
        {
            Console.WriteLine("B Loglandı");
        }
    }


    interface ILogger
    {
        void log();
    }

    interface ILoggerFactory
    {
        ILogger createLogger();
    }

}
