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
                MessageBox.Show("Por favor, ingrese sus credenciales.", "Agenda | Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lógica de validación 

            if (txtUsuario.Text.Equals("admin") && txtContrasena.Text.Equals("12345"))
            {
                // Si las credenciales son correctas
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Credenciales incorrectas
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
    }
}
