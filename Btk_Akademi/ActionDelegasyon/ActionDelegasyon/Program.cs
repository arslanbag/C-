using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HandledException(() =>
            {
                Find();
            });

            Console.ReadLine(); 
        }

        private static void HandledException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        public static void Find() 
        {
            int[] list = { 1, 2, 3 };
            if (!list.Contains(4)) 
            {
                throw new Exception();
            }
            else
            {
                Console.WriteLine("Bulundu");
            }
        
        }
    }
}
