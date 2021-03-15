using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Laboratorio2TP1
{
    class Calabozo
    {
        public int posicion;

        public int Posicion
        {
            get { return posicion; }
        }

        public Calabozo()
        {
            Thread.Sleep(1000);
            Random rdn = new Random();
            posicion = rdn.Next(2, 50);
        }
    }
}
