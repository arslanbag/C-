using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            VicePresident vicePresident = new VicePresident();  
            President president = new President();

            manager.setSuccessor(vicePresident);
            vicePresident.setSuccessor(president);

            Expense expense= new Expense { Detail= "Eğitim" , Amount  = 101};
            manager.HandleExpense(expense);

            Console.ReadLine();
        }
    }

    class Expense
    {
        public string Detail { get; set; }
        public decimal Amount { get; set; }
    }

    abstract class ExpenseHandlerBase 
    {
        protected ExpenseHandlerBase Successor;
        public abstract void HandleExpense(Expense expense);

        public void setSuccessor(ExpenseHandlerBase successor) 
        {
            Successor = successor;
        }
    }
    class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount < 100)
            {
                Console.WriteLine("Harcamayı Yönetici Kontrol altına aldı");
            }
            else if(Successor!=null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }
    class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount <= 10*100)
            {
                Console.WriteLine("Harcamayı Başkan Yardımcısı Kontrol altına aldı");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }
    class President : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 10 * 100)
            {
                Console.WriteLine("Harcamayı Başkan  Kontrol altına aldı");
            }
        }
    }
}
