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
    public partial class EditarContacto : Form
    {
        Contacto _contacto; // Aquí guardaremos el contacto que viene de la lista
        ContactoBll _contactoBLL = new ContactoBll();

        public EditarContacto(Contacto contactoRecibido)
        {
            InitializeComponent();
            _contacto = contactoRecibido; // Guardamos el contacto
            CargarDatos(); // Llenamos los TextBox con la info actual
        }

        private void CargarDatos()
        {
            // Supongamos que tus TextBox se llaman así:
            txtNombre.Text = _contacto.Nombre;
            txtTelefono.Text = _contacto.Telefono;
            txtCorreo.Text = _contacto.Correo;
            txtDireccion.Text = _contacto.Direccion;
        }
       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1. VALIDACIÓN: Verificamos que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El nombre y el teléfono son campos obligatorios.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene el código aquí para que no guarde
            }
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text.Trim(), patronCorreo))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // 2. Si pasó la validación, actualizamos el objeto
            // Usamos .Trim() para quitar espacios accidentales al inicio o final
            _contacto.Nombre = txtNombre.Text.Trim();
            _contacto.Telefono = txtTelefono.Text.Trim();
            _contacto.Correo = txtCorreo.Text.Trim();
            _contacto.Direccion = txtDireccion.Text.Trim();

            // 3. Intentamos guardar los cambios
            try
            {
                int resultado = _contactoBLL.Guardar(_contacto, true);

                if (resultado > 0)
                {
                    MessageBox.Show("Contacto actualizado correctamente", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el contacto. Intente de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message);
            }
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

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
