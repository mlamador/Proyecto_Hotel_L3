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
    public partial class FormCliente : Form
    {
        HabitacionesBL _habitaciones;

        public FormCliente()
        {
            InitializeComponent();

            _habitaciones = new HabitacionesBL();

            listaHabitacionesBindingSource.DataSource = _habitaciones.ObtenerHabitaciones();
        }


    }
}
