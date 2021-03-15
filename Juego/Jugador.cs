using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laboratorio2TP1
{
    class Jugador : Pieza
    {
        bool automatico;
        public bool penalizacion = false, estado = true;
        string nombre;
        int dado, triunfo, derrota;
        static int jugadores = 1;

        public int Dado
        {
            get { return dado; }
        }

        public bool Automatico
        {
            get { return automatico; }
            set { automatico = value; }
        }
        public bool Estado
        {
            get { return estado; }
        }

        public string Nombre
        {
            get { return nombre; }
        }
        public int Triunfo
        {
            get { return triunfo; }
            set { triunfo = value; }
        }
        public int Derrota
        {
            get { return derrota; }
            set { derrota = value; }
        }
        public readonly int numero;

        public int Numero
        {
            get { return numero; }
        }

        public Jugador(string nombre,int cantJug)
        {
            this.nombre = nombre;
            numero = jugadores;
            if (numero == cantJug)  
            {
                jugadores = 1;
            }
            else jugadores++;
        }

        public int TirarDado()
        {
            Random tiro = new Random();
            dado = 1 + tiro.Next(6);
            return dado;
        }

        public override void Mover()
        {
            posicion += TirarDado();
        }
    }
}
