using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Laboratorio2TP1
{
    class Dragon : Pieza
    {
        public string dueño;//

        public string Dueño //
        {
            get { return dueño; }
            set { dueño = value; }
        }

        public Dragon(string nombre)
        {
            dueño = nombre;
            Random rdn = new Random();
            posicion = rdn.Next(2, 50);
        }
        public override void Mover()
        {
            Thread.Sleep(1000);
            Random tiro = new Random();
            posicion = tiro.Next(1, 50);
        }
    }
}
