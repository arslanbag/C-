using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add();
        }
    }
    [ToTable("Customers")] //Veritabanındaki adı
    class Customer 
    {
        public int Id { get; set; }
        [RequiredProperty] //zorunlu gir
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }
    class CustomerDal 
    {
        [Obsolete("Add kullanma yerine ,AddNew Kullan")]
        public void Add() 
        {
            Console.WriteLine("Eski Method");
        }

        public void AddNew()
        {
            Console.WriteLine("Eski Methodu kullananı Obsolete ile uyar");
        }
    }
    [AttributeUsage(AttributeTargets.All)]//Bu attrbute herkes kullanabilir
    //[AttributeUsage(AttributeTargets.Property)]//class içindekiler için
    //[AttributeUsage(AttributeTargets.Property  | AttrbuteTargets.Field )]//çoklu kullanım "|" işareti ile
    //[AttributeUsage(AttributeTargets.All, AllowMultiple  =true)]//AllowMultiple arka arkaya kullanım aç/kapat
    //[AttributeUsage(AttributeTargets.Class)]//sadece classlar için
    class RequiredPropertyAttribute : Attribute 
    {
    
    }
    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string v)
        {
            this._tableName = v;
        }
    }
}
