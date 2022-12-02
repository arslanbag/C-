using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegeler
{
    public delegate void Mydelegate();
    public delegate void Mydelegate2(String message);
    public delegate int Mydelegate3(int a, int b);

    internal class Program
    {
        static void Main(string[] args)
        {
            //Action Delegesi hazır delegedir dönüş olmayan fonksiyonlar için uygundur 
            //Funk Delegesi hazır delegedir dönüşü olan fonksiyonlar için uygundur 

            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();

            Mydelegate mydelegate = customerManager.SendMessage;
            mydelegate += customerManager.ShowAlert;
            mydelegate -= customerManager.SendMessage;
            mydelegate();

            Mydelegate2 mydelegate2 = customerManager.SendMessage2;
            mydelegate2 += customerManager.ShowAlert2;
            mydelegate2("Hello");

            Math math = new Math();
            Mydelegate3 mydelege3 = math.Topla;
            mydelege3 += math.Carp;
            Console.WriteLine(mydelege3(2,3)); //Delegedeki en son methodun degeri döner


            //Funk Örneği - parametreli
            Func<int, int, int> add = math.Topla; //ilk iki tip(int) parametre,  3. tip değer dönüştüdür.
            Console.WriteLine("AA"+add(2, 3));

            //parametresiz
            Func<int> getRandomNumber = delegate ()
            {
                Random random= new Random();
                return random.Next(1,100);
            };
            Console.WriteLine("AAQ" + getRandomNumber());

            //parametresiz başka yazım
            Func<int> getRandomNumber2 = () => new Random().Next(1,100);
            Thread.Sleep(1000);//durdur
            Console.WriteLine("AAQ" + getRandomNumber2());

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("SendMessage");
        }
        public void ShowAlert()
        {
            Console.WriteLine("showAlert");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine("SendMessage2 " + message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine("showAlert2 " + alert);
        }
    }

    class Math 
    {
        public int Topla(int a , int b) 
        {
            return a + b;
        }

        public int Carp(int a, int b)
        {
            return a *b;
        }

    }
}
