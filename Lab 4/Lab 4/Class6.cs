using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Maquina_Empaquetadora : Machine, IEncender, IApagar, IReiniciar

    {

        public Maquina_Empaquetadora()
        {
            Name = "Maquina Empaquetadora";
            Memory = 3000;
        }
        public int TurnOn(int p)
        {
            int newm = Memory - p;
            return newm;
        }
        public int TurnOff()
        { return Memory; }

        public int Restart()
        { return Memory; }
    }
}
