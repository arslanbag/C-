using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mediator meditor = new Mediator();
            Teacher teacher = new Teacher(meditor) { Name = "Aykut" };

            meditor.Teacher = teacher;

            Student student1 = new Student(meditor) { Name ="Öğrenci1"};
            Student student2 = new Student(meditor) { Name ="Öğrenci2"};
            meditor.Students = new List<Student> { student1, student2 };

            teacher.SendNewImageUrl("slide1.jpg");
            teacher.RecieveQuestion("Hocam mola verecekmiyiz ? ", student1);

           Console.ReadLine();
        }
    }

    abstract class CourseMember
    {
        protected Mediator Mediator;

        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }

    class Mediator 
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public void UpdateImage(string url)
        {
            foreach (var item in Students)
            {
                item.RecieveImage(url);
            }
        }
        public void SendQustion(string question, Student student)
        {
            Teacher.RecieveQuestion(question, student);
        }

        public void SendAnswer(string answer, Student student)
        {
            student.ReceiveAnswer(answer);
        }
    }

    class Teacher : CourseMember
    {
        public string Name { get; internal set; }

        public Teacher(Mediator mediator) : base(mediator){}
        internal void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine("Öğretmene gelen soru :{0} , Öğreci : {1}", question, student.Name);
        }
        public void SendNewImageUrl(string url) 
        {
            Console.WriteLine("Öğretmen slaytı değiştirdi :{0}", url);
            Mediator.UpdateImage(url);  
        }
        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine("Öğretmeninin , {0} cevabı :{1}", student.Name, answer);
        }
    }

    class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator){ }

        public string Name { get; internal set; }

        public void RecieveImage(string url)
        {
            Console.WriteLine("{0} , adlı öğrenciye gelen resim :{1}",this.Name, url);
        }

        public void ReceiveAnswer(string answer)
        {
            Console.WriteLine("Öğrenciden gelen soru : ", answer);
        }
    }

  
}
