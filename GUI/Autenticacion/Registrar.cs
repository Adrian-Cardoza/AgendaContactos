using BLL;
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

namespace GUI.Autenticacion
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Validación de campos vacíos (Evita que se guarden NULLs o espacios en blanco)
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Verificamos que las contraseñas coincidan
            if (txtPass.Text != txtConfirmarPass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifica.",
                                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. Creamos el objeto Usuario con los datos de los TEXTBOX
                // Usamos .Trim() para quitar espacios accidentales al inicio o final
                Usuario nuevoUsuario = new Usuario()
                {
                    NombreUsuario = txtUsuario.Text.Trim(),
                    Contrasena = txtPass.Text.Trim(),
                    NombreCompleto = txtNombreCompleto.Text.Trim()
                };

                // 4. Llamamos a la capa de Negocio (BLL)
                UsuarioBll bll = new UsuarioBll();
                string resultado = bll.RegistrarNuevoUsuario(nuevoUsuario);

                // 5. Manejo de la respuesta
                if (resultado == "EXITO")
                {
                    MessageBox.Show("Usuario creado exitosamente", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cerramos esta ventana y regresamos al Login
                }
                else
                {
                    // Esto mostrará errores de lógica (ej. "El usuario ya existe")
                    MessageBox.Show(resultado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Esto atrapará errores de conexión o de SQL
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message,
                                "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
