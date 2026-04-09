using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EL;
using BLL;
namespace GUI.Autenticacion
{
    public partial class Login : Form
    {
        // Instancia de la lógica de negocio para validar usuarios
 
        UsuarioBll _usuarioBLL = new UsuarioBll();

        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // 1. Validar que no estén vacíos
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, ingrese sus credenciales.", "Agenda Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lógica de validación con BASE DE DATOS
            UsuarioBll bll = new UsuarioBll();
            // Llamamos a la función que creamos (asegúrate de que exista en tu BLL)
            var usuarioLogueado = bll.ValidarUsuario(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());

            if (usuarioLogueado != null)
            {
                // Si el usuario existe en SQL, damos la bienvenida
                MessageBox.Show($"¡Bienvenido {usuarioLogueado.NombreCompleto}!", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Si no existe o la clave está mal
                MessageBox.Show("Usuario o contraseña incorrectos.", "Agenda | Inicio de Sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsuario.Clear();
                txtContrasena.Clear();
                txtUsuario.Focus();
            }
        }

        private void Contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirRegistro_Click(object sender, EventArgs e)
        {
            // Creamos una instancia de tu nuevo formulario
            Registrar ventanaRegistro = new Registrar();

            // Lo abrimos como un cuadro de diálogo (bloquea el login hasta cerrar este)
            ventanaRegistro.ShowDialog();
        }

        private void btnIrARegistro_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Asegúrate de que el nombre 'Registrar' sea el de tu formulario
            Registrar ventana = new Registrar();
            ventana.ShowDialog();
        }
        private void lnkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Llamamos a la ventana que acabas de crear
            Registrar ventanaRegistro = new Registrar();
            ventanaRegistro.ShowDialog();
        }
    }
}
