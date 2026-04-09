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

namespace GUI.Contactos
{
    public partial class AgregarContacto : Form
    {
        private Usuario _usuarioSesion;
        // BLOQUEO DE MEMORIA: Una vez que sea true, nada lo vuelve a ejecutar
        private static bool _estaGuardando = false;

        public AgregarContacto(Usuario usuario)
        {
            InitializeComponent();
            _usuarioSesion = usuario;
            _estaGuardando = false;

            // Limpieza de eventos
            this.buttonAgregar.Click -= Agregar_Click;
            this.buttonAgregar.Click += Agregar_Click;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (_estaGuardando) return;

            try
            {
                _estaGuardando = true;
                buttonAgregar.Enabled = false;

                // --- VALIDACIÓN COMPLETA DE CAMPOS ---
                // Verifica que ninguno de los campos esté vacío o solo con espacios
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("Todos los campos (Nombre, Teléfono, Correo y Dirección) son obligatorios.",
                                    "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    _estaGuardando = false;
                    buttonAgregar.Enabled = true;
                    return; // Detiene el proceso
                }

                // Si pasó la validación, creamos el objeto
                Contacto nuevoContacto = new Contacto
                {
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    UsuarioId = _usuarioSesion.UsuarioId,
                    FechaRegistro = DateTime.Now
                };

                ContactoBll bll = new ContactoBll();
                int resultado = bll.Guardar(nuevoContacto);

                if (resultado > 0)
                {
                    MessageBox.Show("¡Contacto guardado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                _estaGuardando = false;
                buttonAgregar.Enabled = true;
            }
            finally
            {
                _estaGuardando = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}