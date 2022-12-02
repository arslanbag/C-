using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflaction
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*DortIslem dort = new DortIslem(4,3);
            Console.WriteLine(dort.Topla(4, 3));
            Console.WriteLine(dort.Topla2());*/

            //çalışma anında instance üretir
            var tip = typeof(DortIslem);//tipini al
            DortIslem dortislem = (DortIslem) Activator.CreateInstance(tip, 6,7);//constructor degerleri böyle giriliyor
            Console.WriteLine(dortislem.Topla(4, 3));

            var instance = Activator.CreateInstance(tip,6,5);
            //çalışma anına oluşan insatance ın methodunu çalıştır
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");//methodu çağır

            //*****Bir methodu çalıştır
            Console.WriteLine(methodInfo.Invoke(instance, null)); //invoke ile method çalıştırabilir , parametre doldurabilirirz null kısmı parametre 

            //****tüm methodların adını al
            var metodlar = tip.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine(info.Name);
                //method parametreleri
                foreach (var item in info.GetParameters())
                {
                    Console.WriteLine(item.Name);
                }

                //Attirubute //[Obess] gibi özellikler okunur
                foreach (var item2 in info.GetCustomAttributes())
                {
                    Console.WriteLine(item2.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }
    public class DortIslem 
    {
        private int _a;
        private int _b;

        public DortIslem(int a, int b)
        {
            _a = a;
            _b = b;
        }
        public DortIslem()
        {
   
        }


        public int Topla(int a, int b) 
        {
            return a + b;
        }
        public int Carp(int a, int b)
        {
            return a * b;
        }
        public int Topla2()
        {
            return _a + _b;
        }
        [MethodName("Çarpma")]
        public int Carp2()
        {
            return _a * _b;
        }
    }

    public class MethodNameAttribute : Attribute 
    {
        public MethodNameAttribute(String A)
        {

        }
    }
}
