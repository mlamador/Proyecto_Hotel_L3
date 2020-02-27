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
    public partial class FormAsignador : Form
    {
        public FormAsignador()
        {
            InitializeComponent();
        }

        private void habitacionesDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formHdisponibles = new FormHdisponibles();

            formHdisponibles.Show();
        }
    }
}
