using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager { Name = "Aykut", Salary = 25000} ;
            Manager manager2 = new Manager { Name = "Yönetici2", Salary = 15000} ;

            Worker worker1 = new Worker { Name = "Çalışan1", Salary = 17000} ;
            Worker worker2 = new Worker { Name = "Çalışan2", Salary = 18000} ;

            manager1.Subordinates.Add(manager2);
            manager2.Subordinates.Add(worker1);
            manager2.Subordinates.Add(worker2);

            OrganisationalStructure organisationalStructure = new OrganisationalStructure(manager2); // verilan çalışandan sonrası için hesaplama yapılır
           
            PayrollVisitor payrollVisitor = new PayrollVisitor();
            Payrise payrise = new Payrise();

            organisationalStructure.Accept(payrollVisitor);
            organisationalStructure.Accept(payrise);

            Console.ReadLine(); 
        }
    }
    class OrganisationalStructure
    {
        public EmployeeBase Employee;

        public OrganisationalStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }
        public void Accept(VisitoreBase visitor) 
        {
            Employee.Accept(visitor);
        }
    }
    abstract class EmployeeBase
    {
        public abstract void Accept(VisitoreBase visitor);
        public string Name { get; set; }
        public decimal Salary { get; set; }

    }
    class Manager : EmployeeBase
    {
        public Manager() 
        {
            Subordinates = new List<EmployeeBase>();
        }
        public List<EmployeeBase> Subordinates { get; set; }
        public override void Accept(VisitoreBase visitor)
        {
            visitor.Visit(this);
            foreach (var item in Subordinates)
            {
                item.Accept(visitor);
            }
        }
    }

    class Worker : EmployeeBase
    {
        public override void Accept(VisitoreBase visitor)
        {
            visitor.Visit(this);
        }
    }

    abstract class VisitoreBase
    {
           public abstract void Visit(Worker worker);
           public abstract void Visit(Manager manager);
    }

    class PayrollVisitor : VisitoreBase //Ödeme
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} adlı çalışanaaa {1} miktar ödeme yapıldı",worker.Name, worker.Salary);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} adlı çalışanaaaa {1} miktar ödeme yapıldı", manager.Name, manager.Salary);
        }
    }

    class Payrise : VisitoreBase //Artış
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} adlı çalışanın {1} zamlı maaşı", worker.Name, worker.Salary*(decimal)1.1);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} adlı çalışanın {1} zamlı maaşı", manager.Name, manager.Salary * (decimal)1.9);
        }
    }
}
