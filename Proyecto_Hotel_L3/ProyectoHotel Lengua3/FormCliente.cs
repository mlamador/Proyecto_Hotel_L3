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
        private Habitacion habitacion;

        public FormCliente()
        {
            InitializeComponent();

            _habitaciones = new HabitacionesBL();

            listaHabitacionesBindingSource.DataSource = _habitaciones.ObtenerHabitaciones();

              


        }

        private void listaHabitacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //==============
            listaHabitacionesBindingSource.EndEdit();
            //================
            var habitaciones = (Habitacion)listaHabitacionesBindingSource.Current;

            var resultado = _habitaciones.GuardarHabitacion(habitacion);
            if (resultado.Exitoso ==true)
            {
                listaHabitacionesBindingSource.ResetBindings(false);
                DeshabilitarHbilitarBotones(true);

            }
            else
            {

                MessageBox.Show(resultado.Mensaje);

            }


        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _habitaciones.AgregarHabitacion();
            listaHabitacionesBindingSource.MoveLast();

            DeshabilitarHbilitarBotones(false);


        }

        private void DeshabilitarHbilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;

            toolStripButtonCancelar.Visible = !valor;
        }




        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            if (idTextBox.Text!= "")
            {
                var id = int.Parse(idTextBox.Text);
                Eliminar(id);
            
            }

        }

        private void Eliminar(int id)
        {
           
            var resultado = _habitaciones.EliminarHabitacion(id);

            if (resultado == true)
            {
                listaHabitacionesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurriio un error al eliminar la habitacion");

            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHbilitarBotones(true);
            Eliminar(0);
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
