using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager= new CustomerManager();
            customerManager.messagesenderBase = new SmsSender();
            customerManager.UpdateCustomer();

            Console.ReadLine();
        }
    }

    public class Body
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }


    abstract class MessageSenderBase
    {
        public void Save() 
        {
            Console.WriteLine("Mesaj Kayıt Edildi");
        }
        public abstract void Send(Body body);
    }

    class SmsSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} , Sms Gönderici",body.Title);
        }
    }
    class EmailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} , Email Gönderici", body.Title);
        }
    }
    //...
    class CustomerManager 
    {
        public MessageSenderBase messagesenderBase { get; set; }
        public void UpdateCustomer() 
        {
            messagesenderBase.Send(new Body {Title ="Bilgilendirme Başlığı :" });
            Console.WriteLine("Müşteri Güncellendi");    
        }
    }
}
