using BL.Apartados;
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
    public partial class FormDisponibles : Form
    {
        public FormDisponibles()
        {
            InitializeComponent();

            var habitacionesBL = new HabitacionesBL();
        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
