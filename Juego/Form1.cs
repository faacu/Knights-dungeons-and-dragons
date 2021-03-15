using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        public void Iniciar ()
        {
            pbJugador1.Left = 60;
            pbJugador1.Top = 126;
            pbJugador2.Left = 60;
            pbJugador2.Top = 152;
            pbJugador3.Left = 60;
            pbJugador3.Top = 178;
            pbJugador4.Left = 60;
            pbJugador4.Top = 204;

            pbDragon11.Left = 86;
            pbDragon11.Top = 126;
            pbDragon21.Left = 86;
            pbDragon21.Top = 152;
            pbDragon31.Left = 86;
            pbDragon31.Top = 178;
            pbDragon41.Left = 86;
            pbDragon41.Top = 204;

            pbDragon12.Left = 112;
            pbDragon12.Top = 126;
            pbDragon22.Left = 112;
            pbDragon22.Top = 152;
            pbDragon32.Left = 112;
            pbDragon32.Top = 178;
            pbDragon42.Left = 112;
            pbDragon42.Top = 204;

            pbCalabozo1.Left = 52;
            pbCalabozo1.Top = 124;
            pbCalabozo2.Left = 52;
            pbCalabozo2.Top = 124;
            pbCalabozo3.Left = 52;
            pbCalabozo3.Top = 124;
        }
        Juego nuevo = new Juego();
        CrearJugador cj;
        public bool bandera; //para ver si es manual o demo
        int tipo, filas, columnas;
        VentanaGanador ventana;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) //tirar dado
        {
            switch(tipo)
            {
                case 1:
                    for (int x = 0; x < nuevo.Simple.nroJugadores; x++)
                    {
                        nuevo.Simple.Jugar(x);
                        Graficos(x);
                        switch (nuevo.Simple.Jugadores[x].numero)
                        {
                            case 1:
                                lbDado1.Text = "+" + nuevo.Simple.Jugadores[x].Dado;
                                lbPuntaje1.Text = "Derrotas: " + nuevo.Simple.Jugadores[0].Derrota + " | Victorias: " + nuevo.Simple.Jugadores[x].Triunfo;
                                break;
                            case 2:
                                lbDado2.Text = "+" + nuevo.Simple.Jugadores[x].Dado;
                                lbPuntaje2.Text = "Derrotas: " + nuevo.Simple.Jugadores[0].Derrota + " | Victorias: " + nuevo.Simple.Jugadores[x].Triunfo;
                                break;
                            case 3:
                                lbDado3.Text = "+" + nuevo.Simple.Jugadores[x].Dado;
                                lbPuntaje3.Text = "Derrotas: " + nuevo.Simple.Jugadores[0].Derrota + " | Victorias: " + nuevo.Simple.Jugadores[x].Triunfo;
                                break;
                            case 4:
                                lbDado4.Text = "+" + nuevo.Simple.Jugadores[x].Dado;
                                lbPuntaje4.Text = "Derrotas: " + nuevo.Simple.Jugadores[0].Derrota + " | Victorias: " + nuevo.Simple.Jugadores[x].Triunfo;
                                break;
                        }
                        Thread.Sleep(1000);
                    }
                    break;
                case 2:
                    for (int x = 0; x < nuevo.Intermedio.nroJugadores; x++)
                    {
                        nuevo.Intermedio.Jugar(x);
                        Graficos(x);
                        switch (nuevo.Intermedio.Jugadores[x].numero)
                        {
                            case 1:
                                lbEvento1.Text = nuevo.Intermedio.Evento;
                                lbDado1.Text = "+" + nuevo.Intermedio.Jugadores[x].Dado;
                                lbPuntaje1.Text = "Derrotas: " + nuevo.Intermedio.Jugadores[x].Derrota + " | Victorias: " + nuevo.Intermedio.Jugadores[x].Triunfo;
                                break;
                            case 2:
                                lbEvento2.Text = nuevo.Intermedio.Evento;
                                lbDado2.Text = "+" + nuevo.Intermedio.Jugadores[x].Dado;
                                lbPuntaje2.Text = "Derrotas: " + nuevo.Intermedio.Jugadores[x].Derrota + " | Victorias: " + nuevo.Intermedio.Jugadores[x].Triunfo;
                                break;
                            case 3:
                                lbEvento3.Text = nuevo.Intermedio.Evento;
                                lbDado3.Text = "+" + nuevo.Intermedio.Jugadores[x].Dado;
                                lbPuntaje3.Text = "Derrotas: " + nuevo.Intermedio.Jugadores[x].Derrota + " | Victorias: " + nuevo.Intermedio.Jugadores[x].Triunfo;
                                break;
                            case 4:
                                lbEvento4.Text = nuevo.Intermedio.Evento;
                                lbDado4.Text = "+" + nuevo.Intermedio.Jugadores[x].Dado;
                                lbPuntaje4.Text = "Derrotas: " + nuevo.Intermedio.Jugadores[x].Derrota + " | Victorias: " + nuevo.Intermedio.Jugadores[x].Triunfo;
                                break;
                        }
                        Thread.Sleep(1000);
                        nuevo.Intermedio.Evento = "";
                    }
                    break;

                case 3:
                    for (int x = 0; x < nuevo.Experto.nroJugadores; x++)
                    {
                        nuevo.Experto.Jugar(x);
                        Graficos(x);
                        switch (nuevo.Experto.Jugadores[x].numero)
                        {
                            case 1:
                                lbEvento1.Text = nuevo.Experto.Evento;
                                lbDado1.Text = "+" + nuevo.Experto.Jugadores[x].Dado;
                                lbPuntaje1.Text = "Derrota: " + nuevo.Experto.Jugadores[x].Derrota + " | Victoria: " + nuevo.Experto.Jugadores[x].Triunfo;
                                break;
                            case 2:
                                lbEvento2.Text = nuevo.Experto.Evento;
                                lbDado2.Text = "+" + nuevo.Experto.Jugadores[x].Dado;
                                lbPuntaje2.Text = "Derrota: " + nuevo.Experto.Jugadores[x].Derrota + " | Victoria: " + nuevo.Experto.Jugadores[x].Triunfo;
                                break;
                            case 3:
                                lbEvento3.Text = nuevo.Experto.Evento;
                                lbDado3.Text = "+" + nuevo.Experto.Jugadores[x].Dado;
                                lbPuntaje3.Text = "Derrota: " + nuevo.Experto.Jugadores[x].Derrota + " | Victoria: " + nuevo.Experto.Jugadores[x].Triunfo;
                                break;
                            case 4:
                                lbEvento4.Text = nuevo.Experto.Evento;
                                lbDado4.Text = "+" + nuevo.Experto.Jugadores[x].Dado;
                                lbPuntaje4.Text = "Derrota: " + nuevo.Experto.Jugadores[x].Derrota + " | Victoria: " + nuevo.Experto.Jugadores[x].Triunfo;
                                break;
                        }
                        Thread.Sleep(1000);
                        nuevo.Experto.Evento = "";
                    }
                        break;
            }
        }

        private void button2_Click(object sender, EventArgs e)//boton demo
        {
            do
            {
                for (int x = 0; x < nuevo.Simple.nroJugadores; x++)
                {
                    tipo = 1;           
                    nuevo.Simple.Jugar(x);
                    Thread.Sleep(1000);
                    Graficos(x);
                    if (nuevo.Simple.Jugadores[0].Posicion >= 50 || nuevo.Simple.Jugadores[1].Posicion >= 50)
                    {
                        lbPuntaje1.Text = "Derrotas: " + nuevo.Simple.Jugadores[0].Derrota + " | Victorias: " + nuevo.Simple.Jugadores[0].Triunfo;
                        lbPuntaje2.Text = "Derrotas: " + nuevo.Simple.Jugadores[1].Derrota + " | Victorias: " + nuevo.Simple.Jugadores[1].Triunfo;
                        
                        nuevo.Simple.Jugadores[0].Posicion = 1;
                        nuevo.Simple.Jugadores[1].Posicion = 1;
                        break;
                    }
                }
                if (nuevo.Simple.Jugadores[0].Posicion == 1 && nuevo.Simple.Jugadores[1].Posicion == 1)
                {
                    break;
                }
            } while (nuevo.Simple.Jugadores[0].Posicion < 50 || nuevo.Simple.Jugadores[1].Posicion < 50);
            do
            {
                for (int x = 0; x < nuevo.Intermedio.nroJugadores; x++)
                {
                    tipo = 2;
                    nuevo.Intermedio.Jugar(x);
                    Thread.Sleep(1000);     
                    Graficos(x);
                    if (nuevo.Intermedio.Jugadores[0].Posicion >= 50 || nuevo.Intermedio.Jugadores[1].Posicion >= 50)
                    {
                        lbPuntaje1.Text = "Derrotas: " + nuevo.Intermedio.Jugadores[0].Derrota + " | Victorias: " + nuevo.Intermedio.Jugadores[0].Triunfo;
                        lbPuntaje2.Text = "Derrotas: " + nuevo.Intermedio.Jugadores[1].Derrota + " | Victorias: " + nuevo.Intermedio.Jugadores[1].Triunfo;
                                
                        nuevo.Intermedio.Jugadores[0].Posicion = 1;
                        nuevo.Intermedio.Jugadores[1].Posicion = 1;
                        break;
                    }
                }
                if (nuevo.Intermedio.Jugadores[0].Posicion == 1 && nuevo.Intermedio.Jugadores[1].Posicion == 1)
                {
                    break;
                }
            } while (nuevo.Intermedio.Jugadores[0].Posicion < 50 || nuevo.Intermedio.Jugadores[1].Posicion < 50);
            do
            {
                for (int x = 0; x < nuevo.Experto.nroJugadores; x++)
                {
                    tipo = 3;
                    nuevo.Experto.Jugar(x);
                    Thread.Sleep(1000);
                    Graficos(x);

                    if (nuevo.Experto.Jugadores[0].Posicion >= 50 || nuevo.Experto.Jugadores[1].Posicion >= 50)
                    {
                        lbPuntaje1.Text = "Derrotas: " + nuevo.Experto.Jugadores[0].Derrota + " | Victorias: " + nuevo.Experto.Jugadores[0].Triunfo;
                        lbPuntaje2.Text = "Derrotas: " + nuevo.Experto.Jugadores[1].Derrota + " | Victorias: " + nuevo.Experto.Jugadores[1].Triunfo;
                        nuevo.Experto.Jugadores[0].Posicion = 1;
                        nuevo.Experto.Jugadores[1].Posicion = 1;
                        break;
                    }
                }
                if (nuevo.Experto.Jugadores[0].Posicion == 1 && nuevo.Experto.Jugadores[1].Posicion == 1)
                {                      
                    break;
                }
            } while (nuevo.Experto.Jugadores[0].Posicion < 50 || nuevo.Experto.Jugadores[1].Posicion < 50);

            Application.Restart();
        }

        private void b_Jugar_Click(object sender, EventArgs e) //boton jugar
        {
            cj = new CrearJugador();
            cj.ShowDialog();

            if (cj.rb_Manual.Checked==true) // Manual
            {
                bandera = false;
                if (cj.rb_Simple.Checked == true)
                    tipo = 1;
                else if (cj.rb_Intermedio.Checked == true)
                {
                    tipo = 2;
                    pbDragon11.Visible = true;
                    pbDragon12.Visible = true;
                    pbDragon21.Visible = true;
                    pbDragon22.Visible = true;
                    pbDragon31.Visible = true;
                    pbDragon32.Visible = true;
                    pbDragon41.Visible = true;
                    pbDragon42.Visible = true;
                }
                else if (cj.rb_Experto.Checked == true)
                {
                    tipo = 3;
                    pbDragon11.Visible = true;
                    pbDragon12.Visible = true;
                    pbDragon21.Visible = true;
                    pbDragon22.Visible = true;
                    pbDragon31.Visible = true;
                    pbDragon32.Visible = true;
                    pbDragon41.Visible = true;
                    pbDragon42.Visible = true;
                }

                nuevo.NuevoJuego(Convert.ToInt32(cj.n_nroJugadores.Value), tipo);
                nuevo.CrearJugador(cj.tb_Nombre.Text, false,bandera);

                gbJugador1.Text = cj.tb_Nombre.Text;

                for (int i = 2; i <= Convert.ToInt32(cj.n_nroJugadores.Value); i++)
                {
                    string nombre = "Jugador " + i;
                    nuevo.CrearJugador(nombre, false ,bandera);
                }
                // posicionar calabozos
                if (tipo == 3)
                {
                    columnas = (nuevo.Experto.Calabozos[0].Posicion % 9) * 100;
                    filas = (nuevo.Experto.Calabozos[0].Posicion / 9) * 100;
                    pbCalabozo1.Left = 52 + columnas;
                    pbCalabozo1.Top = 124 + filas;
                    columnas = (nuevo.Experto.Calabozos[1].Posicion % 9) * 100;
                    filas = (nuevo.Experto.Calabozos[1].Posicion / 9) * 100;
                    pbCalabozo2.Left = 52 + columnas;
                    pbCalabozo2.Top = 124 + filas;
                    columnas = (nuevo.Experto.Calabozos[2].Posicion % 9) * 100;
                    filas = (nuevo.Experto.Calabozos[2].Posicion / 9) * 100;
                    pbCalabozo3.Left = 52 + columnas;
                    pbCalabozo3.Top = 124 + filas;

                    pbCalabozo1.Visible = true;
                    pbCalabozo2.Visible = true;
                    pbCalabozo3.Visible = true;
                }
            }
            else if (cj.rb_Demo.Checked == true) // Demo
            {                                                   //modificacion
                bandera = true;
                nuevo.NuevoJuegoDemo(Convert.ToInt32(cj.n_nroJugadores.Value));
                for (int x = 0; x < 3; x++)                    //para que cree de una vez todos los jugadores en los tres tableros
                {
                    nuevo.CrearJugador(cj.tb_Nombre.Text, true, bandera);

                    for (int i = 1; i < Convert.ToInt32(cj.n_nroJugadores.Value); i++)
                    {
                        string nombre = "Jugador " + i;
                        nuevo.CrearJugador(nombre, true, bandera);
                    }
                }
            }
        }

        public void Graficos(int i)
        {
            switch (tipo)
            {
                case 1:

                    switch (nuevo.Simple.Jugadores[i].Numero) // Tablero Simple
                    {
                        case 1:
                            if (nuevo.Simple.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador1.Left = 60 + columnas;
                                pbJugador1.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Simple.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Simple.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Simple.Jugadores[i].Posicion / 9) * 100;
                                pbJugador1.Left = 60 + columnas;
                                pbJugador1.Top = 126 + filas;
                            }
                            break;

                        case 2:
                            if (nuevo.Simple.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador2.Left = 60 + columnas;
                                pbJugador2.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Simple.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Simple.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Simple.Jugadores[i].Posicion / 9) * 100;
                                pbJugador2.Left = 60 + columnas;
                                pbJugador2.Top = 152 + filas;
                            }
                            break;

                        case 3:
                            if (nuevo.Simple.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador3.Left = 60 + columnas;
                                pbJugador3.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Simple.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Simple.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Simple.Jugadores[i].Posicion / 9) * 100;
                                pbJugador3.Left = 60 + columnas;
                                pbJugador3.Top = 178 + filas;
                            }
                            break;

                        case 4:
                            if (nuevo.Simple.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador4.Left = 60 + columnas;
                                pbJugador4.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Simple.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Simple.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Simple.Jugadores[i].Posicion / 9) * 100;
                                pbJugador4.Left = 60 + columnas;
                                pbJugador4.Top = 204 + filas;
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (nuevo.Intermedio.Jugadores[i].Numero) // Tablero Intermedio
                    {
                        case 1:
                            if (nuevo.Intermedio.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador1.Left = 60 + columnas;
                                pbJugador1.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Intermedio.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Intermedio.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.Jugadores[i].Posicion / 9) * 100;
                                pbJugador1.Left = 60 + columnas;
                                pbJugador1.Top = 126 + filas;
                            }
                            break;

                        case 2:
                            if (nuevo.Intermedio.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador2.Left = 60 + columnas;
                                pbJugador2.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Intermedio.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Intermedio.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.Jugadores[i].Posicion / 9) * 100;
                                pbJugador2.Left = 60 + columnas;
                                pbJugador2.Top = 152 + filas;
                            }
                            break;

                        case 3:
                            if (nuevo.Intermedio.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador3.Left = 60 + columnas;
                                pbJugador3.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Intermedio.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Intermedio.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.Jugadores[i].Posicion / 9) * 100;
                                pbJugador3.Left = 60 + columnas;
                                pbJugador3.Top = 178 + filas;
                            }
                            break;

                        case 4:
                            if (nuevo.Intermedio.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador4.Left = 60 + columnas;
                                pbJugador4.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Intermedio.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Intermedio.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.Jugadores[i].Posicion / 9) * 100;
                                pbJugador4.Left = 60 + columnas;
                                pbJugador4.Top = 204 + filas;
                            }
                            break;
                    }
                    for (int x = 0; x < nuevo.Intermedio.nroDragones; x++)
                    {
                        switch (x)
                        {
                            case 0:
                                columnas = (nuevo.Intermedio.dragones[x].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.dragones[x].Posicion / 9) * 100;
                                pbDragon11.Left = 86 + columnas;
                                pbDragon11.Top = 126 + filas;
                                break;

                            case 2:
                                columnas = (nuevo.Intermedio.dragones[x].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.dragones[x].Posicion / 9) * 100;
                                pbDragon21.Left = 86 + columnas;
                                pbDragon21.Top = 152 + filas;
                                break;

                            case 4:
                                columnas = (nuevo.Intermedio.dragones[x].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.dragones[x].Posicion / 9) * 100;
                                pbDragon31.Left = 86 + columnas;
                                pbDragon31.Top = 178 + filas;
                                break;

                            case 6:
                                columnas = (nuevo.Intermedio.dragones[x].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.dragones[x].Posicion / 9) * 100;
                                pbDragon41.Left = 86 + columnas;
                                pbDragon41.Top = 204 + filas;
                                break;
                            case 1:
                                columnas = (nuevo.Intermedio.dragones[x].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.dragones[x].Posicion / 9) * 100;
                                pbDragon12.Left = 112 + columnas;
                                pbDragon12.Top = 126 + filas;
                                break;
                            case 3:
                                columnas = (nuevo.Intermedio.dragones[x].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.dragones[x].Posicion / 9) * 100;
                                pbDragon22.Left = 112 + columnas;
                                pbDragon22.Top = 152 + filas;
                                break;
                            case 5:
                                columnas = (nuevo.Intermedio.dragones[x].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.dragones[x].Posicion / 9) * 100;
                                pbDragon32.Left = 112 + columnas;
                                pbDragon32.Top = 178 + filas;
                                break;
                            case 7:
                                columnas = (nuevo.Intermedio.dragones[x].Posicion % 9) * 100;
                                filas = (nuevo.Intermedio.dragones[x].Posicion / 9) * 100;
                                pbDragon42.Left = 112 + columnas;
                                pbDragon42.Top = 204 + filas;
                                break;
                        }
                    }
                    break;
                case 3:

                    switch (nuevo.Experto.Jugadores[i].Numero) // Tablero Experto
                    {
                        case 1:
                            if (nuevo.Experto.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador1.Left = 60 + columnas;
                                pbJugador1.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Experto.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Experto.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Experto.Jugadores[i].Posicion / 9) * 100;
                                pbJugador1.Left = 60 + columnas;
                                pbJugador1.Top = 126 + filas;
                            }
                            break;

                        case 2:
                            if (nuevo.Experto.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador2.Left = 60 + columnas;
                                pbJugador2.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Experto.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Experto.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Experto.Jugadores[i].Posicion / 9) * 100;
                                pbJugador2.Left = 60 + columnas;
                                pbJugador2.Top = 152 + filas;
                            }
                            break;

                        case 3:
                            if (nuevo.Experto.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador3.Left = 60 + columnas;
                                pbJugador3.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Experto.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Experto.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Experto.Jugadores[i].Posicion / 9) * 100;
                                pbJugador3.Left = 60 + columnas;
                                pbJugador3.Top = 178 + filas;
                            }
                            break;

                        case 4:
                            if (nuevo.Experto.Jugadores[i].Posicion >= 50)
                            {
                                columnas = (50 % 9) * 100;
                                filas = (50 / 9) * 100;
                                pbJugador4.Left = 60 + columnas;
                                pbJugador4.Top = 126 + filas;
                                ventana = new VentanaGanador();
                                ventana.lbGanador.Text = "Ganador: " + nuevo.Experto.Jugadores[i].Nombre;
                                ventana.ShowDialog();
                                if (ventana.DialogResult == DialogResult.OK)
                                {
                                    Iniciar();
                                }
                            }
                            else
                            {
                                columnas = (nuevo.Experto.Jugadores[i].Posicion % 9) * 100;
                                filas = (nuevo.Experto.Jugadores[i].Posicion / 9) * 100;
                                pbJugador4.Left = 60 + columnas;
                                pbJugador4.Top = 204 + filas;
                            }
                            break;
                    }
                    for (int z = 0; z < nuevo.Experto.nroDragones; z++)
                    {
                        switch (z)
                        {
                            case 0:
                                columnas = (nuevo.Experto.dragones[z].Posicion % 9) * 100;
                                filas = (nuevo.Experto.dragones[z].Posicion / 9) * 100;
                                pbDragon11.Left = 86 + columnas;
                                pbDragon11.Top = 126 + filas;
                                break;

                            case 2:
                                columnas = (nuevo.Experto.dragones[z].Posicion % 9) * 100;
                                filas = (nuevo.Experto.dragones[z].Posicion / 9) * 100;
                                pbDragon21.Left = 86 + columnas;
                                pbDragon21.Top = 152 + filas;
                                break;

                            case 4:
                                columnas = (nuevo.Experto.dragones[z].Posicion % 9) * 100;
                                filas = (nuevo.Experto.dragones[z].Posicion / 9) * 100;
                                pbDragon31.Left = 86 + columnas;
                                pbDragon31.Top = 178 + filas;
                                break;

                            case 6:
                                columnas = (nuevo.Experto.dragones[z].Posicion % 9) * 100;
                                filas = (nuevo.Experto.dragones[z].Posicion / 9) * 100;
                                pbDragon41.Left = 86 + columnas;
                                pbDragon41.Top = 204 + filas;
                                break;
                            case 1:
                                columnas = (nuevo.Experto.dragones[z].Posicion % 9) * 100;
                                filas = (nuevo.Experto.dragones[z].Posicion / 9) * 100;
                                pbDragon12.Left = 112 + columnas;
                                pbDragon12.Top = 126 + filas;
                                break;
                            case 3:
                                columnas = (nuevo.Experto.dragones[z].Posicion % 9) * 100;
                                filas = (nuevo.Experto.dragones[z].Posicion / 9) * 100;
                                pbDragon22.Left = 112 + columnas;
                                pbDragon22.Top = 152 + filas;
                                break;
                            case 5:
                                columnas = (nuevo.Experto.dragones[z].Posicion % 9) * 100;
                                filas = (nuevo.Experto.dragones[z].Posicion / 9) * 100;
                                pbDragon32.Left = 112 + columnas;
                                pbDragon32.Top = 178 + filas;
                                break;
                            case 7:
                                columnas = (nuevo.Experto.dragones[z].Posicion % 9) * 100;
                                filas = (nuevo.Experto.dragones[z].Posicion / 9) * 100;
                                pbDragon42.Left = 112 + columnas;
                                pbDragon42.Top = 204 + filas;
                                break;
                        }
                    }
                    break;
            }
        }
        private void pbCalabozo3_Click(object sender, EventArgs e)
        {

        }

        private void pbCalabozo1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gbJugador1_Enter(object sender, EventArgs e)
        {

        }

        private void lbEvento1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }

}
