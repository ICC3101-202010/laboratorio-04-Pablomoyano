using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Maquina_Verificacion : Machine, IEncender, IApagar, IReiniciar

    {

        public Maquina_Verificacion()
        {
            Name = "Maquina Verificadora";
            Memory = 2750;
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
