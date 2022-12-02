using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            EmployeeObserver employeeObserver = new EmployeeObserver();
            productManager.Attach(new CustomerObserver());
            productManager.Attach(employeeObserver);
            productManager.Detach(employeeObserver);
            productManager.UpdatePrice();

            Console.ReadLine();
        }
    }
    class ProductManager 
    {
        List<Observer> _observers= new List<Observer>();

        public void UpdatePrice() 
        {
            Console.WriteLine("Fiyat Güncellendi");
            Notify();
        }

        public void Attach(Observer observer) 
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var item in _observers)
            {
                item.Update();
            }
        }
    }

    abstract class Observer 
    {
        public abstract void Update();
    }

    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Mesaj Müşteriye : Ürün fiyatı güncellendi");
        }
    }

    class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Mesaj Çalışana : Ürün fiyatı güncellendi");
        }
    }
}
