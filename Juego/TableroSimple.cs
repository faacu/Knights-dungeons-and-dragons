using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Laboratorio2TP1
{
    class TableroSimple
    {
        public static int partida = 0; // Lleva conteo del número de partidas
        public Jugador[] Jugadores;
        public int nroJugadores;
        public int turno=1;
        int cantJugador = 0;

        public TableroSimple(int nroJugadores)
        {
            this.nroJugadores = nroJugadores;
            Jugadores = new Jugador[nroJugadores];
        }

        public virtual void AgregarJugador(Jugador unJugador)
        {
            if (cantJugador < nroJugadores)
            {
                Jugadores[cantJugador] = unJugador;
                cantJugador++;
            }

        }
        public virtual void Jugar(int z)
        {
            if (Jugadores[z].Estado == true) //vivo o muerto
            {
                if (Jugadores[z].Numero == turno && turno <= nroJugadores)
                {
                    if (Jugadores[z].penalizacion != true) //calabozo
                    {
                        Jugadores[z].Mover();
                    }
                    if (turno == nroJugadores) 
                    {
                        turno = 1;
                    }
                    else turno++;
                }
                if (Jugadores[z].Posicion >= 50) // Gana
                {
                    Jugadores[z].Triunfo++;
                    for (int f = 0; f <= Jugadores.Length - 1; f++)
                    {
                        if (Jugadores[f].Posicion < 50)
                        {
                            Jugadores[f].Derrota++;
                        }
                    }
                    turno = 1;
                    partida++;
                }
            }
        }
    }
}
