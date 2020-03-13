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
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }


        private void gananciasPorTiempoRentadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formGanancias = new FormGanancias();

            formGanancias.Show();
        }

        private void pagoDeDeudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDeudas = new FormDeudas();

            formDeudas.Show();
        }

        private void totalDeGananciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTganancias = new FormTganancias();

            formTganancias.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
