using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contex contex = new Contex();  
            
            AddState addState = new AddState();
            addState.DoAction(contex);

            ModifiedState modified = new ModifiedState();
            modified.DoAction(contex);

            DeleteState deleteStatedelete = new DeleteState();
            deleteStatedelete.DoAction(contex);

            Console.WriteLine(contex.GetState().ToString());
            Console.ReadLine();
        }
    }
    interface IState
    {
        void DoAction(Contex contex);
    }

    class AddState : IState
    {
        public void DoAction(Contex contex)
        {
            Console.WriteLine("State : Eklendi");
            contex.SetState(this);
        }
        public override string ToString()
        {
            return "Eklendi!";
        }
    }
    class ModifiedState : IState
    {
        public void DoAction(Contex contex)
        {
            Console.WriteLine("State : Güncellendi");
            contex.SetState(this);
        }
        public override string ToString()
        {
            return "Güncellendi!";
        }
    }
    class DeleteState : IState
    {
        public void DoAction(Contex contex)
        {
            Console.WriteLine("State : Silindi");
            contex.SetState(this);
        }

        public override string ToString()
        {
            return "Silindi!";
        }
    }
    class Contex
    {
        private IState _state;
        public void SetState(IState state) 
        {
            _state = state;
        }
        public IState GetState()
        {
            return _state;
        }
    }
}
