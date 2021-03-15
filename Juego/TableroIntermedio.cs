using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2TP1
{
    class TableroIntermedio: TableroSimple
    {
        public int nroDragones;
        public Dragon[] dragones;
        int contDrag = 0;
        public string evento;
        public string Evento
        {
            get { return evento; }
            set { evento = value; }
        }

        public TableroIntermedio(int cantJugadores) : base(cantJugadores)
        {
            nroDragones = 2 * cantJugadores;
            dragones = new Dragon[nroDragones];
        }

        public void AgregarDragon(Dragon dragon1, Dragon dragon2)
        {
            dragones[contDrag] = dragon1 ;
            contDrag++;
            dragones[contDrag] = dragon2;
            contDrag++;
        }
        public override void Jugar(int z)
        {
            for (int x = 0; x < nroDragones; x++)
            {
                dragones[x].Mover();
            }
            base.Jugar(z);
            for (int l = 0; l < nroJugadores; l++)
            {
                for (int ñ = 0; ñ < nroDragones; ñ++)
                {
                    if (Jugadores[l].Posicion == dragones[ñ].Posicion && Jugadores[l].Nombre != dragones[ñ].Dueño)
                    {
                        Jugadores[l].Posicion -= 5;
                        evento = "¡Dragón enemigo! Posición -5";
                    }
                    else if (Jugadores[l].Posicion == dragones[ñ].Posicion && Jugadores[l].Nombre == dragones[ñ].Dueño)
                    {
                        Jugadores[l].Posicion += 5;
                        evento = "¡Dragón aliado! Posición +5";
                    }
                }
            }
        }
    }
}
