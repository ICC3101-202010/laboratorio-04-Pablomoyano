using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    abstract class Machine
    {
        public abstract string Name { get; set; }
        public abstract int Memory { get; set; }

        public int UseofMemory(int i)
        { int rest = Memory - i;
            return rest;
        }
        public string FullM()
        { return "La maquina " + Name + " ha colapsado"; }

    }
}
