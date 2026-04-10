using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class Dashboard : Form
	{
		private Usuario _usuarioSesion;

		public Dashboard()
		{
			InitializeComponent();
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Modificamos el constructor para recibir al usuario
        public Dashboard(Usuario usuarioRecibido)
        {
            InitializeComponent();
            _usuarioSesion = usuarioRecibido;

            // Mostramos el nombre en un Label o en el título de la 
            lblNombreUsuario.Text = $"Agenda Dashboard de {_usuarioSesion.NombreCompleto}";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del formulario de Agregar y le pasamos el usuario actual
            GUI.Contactos.AgregarContacto frmCrear = new GUI.Contactos.AgregarContacto(_usuarioSesion);

            // Lo mostramos como un cuadro de diálogo
            frmCrear.ShowDialog();
        }

		private void btnListadoContactos_Click(object sender, EventArgs e)
		{
			GUI.Contactos.ListadoContactos frmListado = new GUI.Contactos.ListadoContactos(_usuarioSesion);
            this.Hide();
			frmListado.ShowDialog();
			this.Show();
		}

		private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
