using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2TP1
{
    public partial class CrearJugador : Form
    {
        public CrearJugador()
        {
            InitializeComponent();
        }

        private void b_Manual_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled=true;
        }

        private void b_Ok_Click(object sender, EventArgs e)
        {
            gb_Partida.Enabled = false;
            groupBox1.Enabled = true;
            if (rb_Demo.Checked == true)
            {
                groupBoxTablero.Enabled = false;
            }

        }

        private void CrearJugador_Load(object sender, EventArgs e)
        {

        }
    }
}
