using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHotel_Lengua3
{
    public partial class FormEstado : Form
    {
        public FormEstado()
        {
            InitializeComponent();
        }

        private void habitacionesOcupadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formOcupados = new FormOcupados();

            formOcupados.Show();
        }

        private void habitacionesDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDisponibles = new FormDisponibles();

            formDisponibles.Show();
        }

        private void habitacionesApartadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formApartados = new FormApartados();

            formApartados.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
