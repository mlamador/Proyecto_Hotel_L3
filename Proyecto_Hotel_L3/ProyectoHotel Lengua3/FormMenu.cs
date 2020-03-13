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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var formEstado = new FormEstado();
            
            formEstado.Show();
        }

        private void asignadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAsignador = new FormAsignador();
            
            formAsignador.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportes = new FormReportes();
            
            formReportes.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCliente = new FormCliente();
            formCliente.Show();
        }
    }
}
