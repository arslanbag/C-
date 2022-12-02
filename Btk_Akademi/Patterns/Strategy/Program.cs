using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.CreditCalculatorBase = new Before2010CreditCalculator();  
            customerManager.SaveCredit();

            Console.ReadLine(); 
        }
    }

    abstract class CreditCalculatorBase 
    {
        public abstract void Calculate();

    }
    class Before2010CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Kredi 2010 öncesi tarifeye göre hesaplandı ");
        }
    }

    class After2010CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Kredi 2010 sonrası tarifeye göre hesaplandı ");
        }
    }

    class CustomerManager 
    {
        public CreditCalculatorBase CreditCalculatorBase { get; set; }
        public void SaveCredit() 
        {
            Console.WriteLine("Kredi Verildi ");
            CreditCalculatorBase.Calculate();

        }
    }
}
