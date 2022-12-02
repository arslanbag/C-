using Composite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee aykut = new Employee { Name = "Aykut" };
            Employee Test1 = new Employee { Name = "Test1" };
            Employee Test1_1 = new Employee { Name = "Test1.1" };
            Employee Test2 = new Employee { Name = "Test2" };
            Employee Test2_1 = new Employee { Name = "Test2.1" };

            aykut.AddSubordinate(Test1);
                Test1.AddSubordinate(Test1_1);
            aykut.AddSubordinate(Test2);
                Test2.AddSubordinate(Test2_1);

            Console.WriteLine(aykut.Name);
            foreach (Employee sub_0 in aykut)
            {
                Console.WriteLine("--"+sub_0.Name);
                foreach (IPerson sub_1 in sub_0)
                {
                    Console.WriteLine("  ╚" + sub_1.Name);
                }
            }

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        string Name { get; set; }

    }
    class Employee : IPerson , IEnumerable<IPerson>
    {
        public string Name { get; set; }
        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate(IPerson person) 
        {
            _subordinates.Add(person);
        }
        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }
        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
