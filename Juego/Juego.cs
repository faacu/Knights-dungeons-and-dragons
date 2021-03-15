using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratorio2TP1
{
    class Juego
    {
        public TableroSimple Simple;
        public TableroIntermedio Intermedio;
        public TableroExperto Experto;

        int nroJugadores, sj = 1, contDragones = 0, contador = 0;
        public int tipoTablero, nroTablero; //se usa en los tableros para demo        

        public void NuevoJuego(int nroJugadores, int tipo)
        {

            this.nroJugadores = nroJugadores;
            tipoTablero = tipo;


            switch (tipo)
            {
                case 1:
                    Simple = new TableroSimple(nroJugadores);
                    break;
                case 2:
                    Intermedio = new TableroIntermedio(nroJugadores);
                    break;
                case 3:
                    Experto = new TableroExperto(nroJugadores);
                    break;
            }
        }

        public void NuevoJuegoDemo(int nroJugadores)
        {
            this.nroJugadores = nroJugadores;

            Simple = new TableroSimple(nroJugadores);
            nroTablero++;
            Intermedio = new TableroIntermedio(nroJugadores);
            nroTablero++;
            Experto = new TableroExperto(nroJugadores);
            nroTablero++;
        }

        public void CrearJugador(string nombre, bool automatico,bool bandera)
        {
            Jugador player = new Jugador(nombre,nroJugadores);
            player.Automatico = automatico; //asigna a los jugadores el valor de automatico

            Dragon Dragon1 = new Dragon(nombre);
            contDragones++;
            Dragon Dragon2 = new Dragon(nombre);
            contDragones++;

            if (bandera == true && contador == 0) // simple demo
            {
                Simple.AgregarJugador(player);
                if (sj == nroJugadores)
                {                   //vuelve todo a cero para agregar los jugadores en otro tablero
                    sj = 0;
                    contador++;
                    contDragones = 0;
                }
            }
            else if (bandera == true && contador == 1) // intermedio demo
            {
                Intermedio.AgregarJugador(player);
                Intermedio.AgregarDragon(Dragon1, Dragon2);
                if (sj == nroJugadores)
                {                   
                    sj = 0;
                    contador++;
                    contDragones = 0;
                }
            }
            else if (bandera == true && contador == 2) // experto demo
            {
                Experto.AgregarJugador(player);
                Experto.AgregarDragon(Dragon1, Dragon2);
                if (sj == nroJugadores)
                {
                    contador = 0;
                }
            }
            else if (bandera == false) //manual
            {
                switch (tipoTablero)
                {
                    case 1:
                        Simple.AgregarJugador(player);
                        break;
                    case 2:
                        Intermedio.AgregarJugador(player);
                        Intermedio.AgregarDragon(Dragon1, Dragon2);
                        break;
                    case 3:
                        Experto.AgregarJugador(player);
                        Experto.AgregarDragon(Dragon1, Dragon2);
                        break;
                }
            }

            if (sj <= nroJugadores)  
            {
                sj++;                       //cuenta los jugadores
            }
        }

    }
}
