using BL.Apartados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        TiposBL _tiposBL;
       // Contexto _contexto;
      //linea borrada

        public FormCliente()
        {
            InitializeComponent();

            _habitaciones = new HabitacionesBL();

            listaHabitacionesBindingSource.DataSource = _habitaciones.ObtenerHabitaciones();

            _tiposBL = new TiposBL();

            listaTiposBindingSource.DataSource = _tiposBL.ObtenerTipos();  


        }

        private void listaHabitacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //==============
            listaHabitacionesBindingSource.EndEdit();
            //================
            var habitacion = (Habitacion)listaHabitacionesBindingSource.Current;

            var resultado = _habitaciones.GuardarHabitacion(habitacion);
            if (resultado.Exitoso ==true)
            {
                listaHabitacionesBindingSource.ResetBindings(false);
                DeshabilitarHbilitarBotones(true);

                MessageBox.Show("Reserva Guardado");

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
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
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
            _habitaciones.CancelarCambios();

            DeshabilitarHbilitarBotones(true);
            //Eliminar(0);
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaTiposBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
