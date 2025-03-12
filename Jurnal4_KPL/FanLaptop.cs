using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modul4_103022300078
{
    public class FanLaptop
    {
        private enum State { Quiet, Balanced, Performance, Turbo }
        private State currentState;

        public FanLaptop()
        {
            currentState = State.Quiet;
            Console.WriteLine(" Fan is quiet");
        }

        public void Quiet()
        {
            currentState = State.Quiet;
            Console.WriteLine(" Fan is quiet");
        }

        public void Performance()
        {
            currentState = State.Performance;
            Console.WriteLine(" Fan is Performanced");
        }

        public void Turbo()
        {
            currentState = State.Turbo;
            Console.WriteLine(" Fan is Turbo");
        }

        public void Balanced()
        {
            currentState = State.Balanced;
            Console.WriteLine(" Fan is Balanced");
        }

        public void modeUp()
        {
            if (currentState == State.Quiet) {
                Console.WriteLine("Fan Quiet Balanced");
            }
            else if (currentState == State.Balanced) {
                Console.WriteLine("Fan Quiet berubah menjadi Balanced");
            }
            else if (currentState == State.Performance) {
                Console.WriteLine("Fan Performance berubah menjadi Turbo");
            }
            else if (currentState == State.Turbo) {
                Console.WriteLine("Fan menjadi Turbo");
            }
        }

        public void modeDown()
        {
            if ((currentState == State.Quiet) || (currentState == State.Balanced))
            {
                Console.WriteLine("Fan mode down");
            }
        }

        public void TurboShortcut()
        {
            if (currentState == State.Quiet)
        }

      
    }
}
