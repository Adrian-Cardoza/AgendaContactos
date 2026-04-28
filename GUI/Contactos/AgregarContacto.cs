using BLL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

		private void ResetBotones()
		{
			_estaGuardando = false;
			buttonAgregar.Enabled = true;
		}

		private void Agregar_Click(object sender, EventArgs e)
        {
            if (_estaGuardando) return;

            try
            {
                _estaGuardando = true;
                buttonAgregar.Enabled = false;


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
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text.Trim(), patronCorreo))
                {
                    MessageBox.Show("El formato del correo electrónico no es válido.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Revertimos los botones para que el usuario pueda intentar de nuevo
                    _estaGuardando = false;
                    buttonAgregar.Enabled = true;
                    return;
                }

				ContactoBll bll = new ContactoBll();
				string telefonoAChecar = txtTelefono.Text.Trim();

				var listaExistente = bll.ObtenerContactos(_usuarioSesion.UsuarioId);
				bool yaExiste = listaExistente.Any(c => c.Telefono.Trim() == telefonoAChecar);

				if (yaExiste)
				{
					MessageBox.Show("Este número de teléfono ya está registrado en tu agenda.",
									"Contacto Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					ResetBotones();
					return;
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}