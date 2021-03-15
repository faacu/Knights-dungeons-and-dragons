using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2TP1
{
    class TableroExperto: TableroIntermedio
    {
        public Calabozo[] Calabozos = new Calabozo[3];

        public TableroExperto(int jugadores) : base(jugadores)
        {
            for(int i = 0;i<3;i++)
            {
                Calabozo unCalabozo = new Calabozo();
                Calabozos[i] = unCalabozo;
            }
        }

        public override void Jugar(int z)
        {
            base.Jugar(z);

            for (int l = 0; l < nroJugadores; l++) //jugadores
            {
                for (int ñ = 0; ñ < 3; ñ++)//calabozos
                {
                    for (int j = 0; j < nroDragones; j++)
                    {
                        if (dragones[j].Posicion == Calabozos[ñ].Posicion && Jugadores[l].Posicion == dragones[j].Posicion)
                        { // dragon + calabozo + jugador
                            if (Jugadores[l].Nombre != dragones[j].Dueño) //distinto dueño
                            {//morir
                                Jugadores[l].estado = false;
                                Jugadores[l].Derrota++;
                                evento = Jugadores[l].Nombre + "ha muerto";
                            }
                        }
                        else if (Jugadores[l].Posicion == Calabozos[ñ].Posicion && dragones[j].Posicion != Calabozos[ñ].Posicion)
                        {//personaje + calabozo sin dragon
                            Jugadores[l].penalizacion = true;
                            evento = Jugadores[l].Nombre + "pierde un turno";
                        }
                    }
                }
            }
        }
    }
}
