using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2TP1
{
    abstract class Pieza
    {
        public int posicion = 1;

        public abstract void Mover();

        public int Posicion
        {
            get { return posicion; }
            set { posicion = value; } //
        }
    }
}
