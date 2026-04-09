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
    public partial class ListadoContactos : Form
    {
        ContactoBll _contactoBLL = new ContactoBll();
		private Usuario _usuarioSesion;
		public ListadoContactos(Usuario usuarioRecibido)
        {
            InitializeComponent();
			_usuarioSesion = usuarioRecibido;
		}

        private void ListadoContactos_Load(object sender, EventArgs e)
        {
            ObtenerContactos();
        }

        private void ObtenerContactos()
        {
			try
			{
				// Pasamos el ID que este logueado
				var lista = _contactoBLL.ObtenerContactos(_usuarioSesion.UsuarioId);

				dgvListadoContactos.DataSource = null;
				dgvListadoContactos.DataSource = lista;
				dgvListadoContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

				if (dgvListadoContactos.Columns["UsuarioId"] != null)
					dgvListadoContactos.Columns["UsuarioId"].Visible = false;

				if (dgvListadoContactos.Columns["Usuario"] != null)
					dgvListadoContactos.Columns["Usuario"].Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

        private void btnAñadirContacto_Click(object sender, EventArgs e)
        {
			Usuario usuarioActual = new Usuario();
			usuarioActual.UsuarioId = _usuarioSesion.UsuarioId;

			// 1. Creamos una instancia de la ventana
			AgregarContacto ventanaAgregar = new AgregarContacto(usuarioActual);

            // 2. La mostramos de forma modal (bloquea la ventana de atrás hasta cerrar esta)
            ventanaAgregar.ShowDialog();
            
            ObtenerContactos(); // Refrescamos la tabla al volver de agregar un contacto
		}

        // 1. Cuando el usuario entra al cuadro
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar un Contacto")
            {
                txtBuscar.SelectionStart = 0;
                txtBuscar.SelectionLength = txtBuscar.Text.Length;
            }
        }

        // 2. Cuando el usuario sale del cuadro y lo deja vacío
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar un Contacto";
                txtBuscar.ForeColor = Color.Gray; // Vuelve al color de sugerencia
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string palabra = txtBuscar.Text.ToLower(); // 'txtBuscar' es el nombre de tu TextBox

            if (palabra == "Buscar un Contacto" || string.IsNullOrWhiteSpace(palabra))
            {
                ObtenerContactos(); // Mostramos la lista completa
                return;
            }
            _contactoBLL = new ContactoBll();

            // Traemos la lista completa original
            var listaCompleta = _contactoBLL.MostrarContactos(_usuarioSesion.UsuarioId);

            // Filtramos usando LINQ (necesitas 'using System.Linq;' arriba)
            var filtrado = listaCompleta.Where(c =>
                (c.Nombre != null && c.Nombre.ToLower().Contains(palabra)) ||
                (c.Telefono != null && c.Telefono.Contains(palabra))
            ).ToList();

            // Mostramos solo los resultados filtrados en el DataGridView
            dgvListadoContactos.DataSource = null;
            dgvListadoContactos.DataSource = filtrado;
        }

        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            // 1. Verificamos si hay una fila seleccionada en el DataGridView
            if (dgvListadoContactos.SelectedRows.Count > 0)
            {
                // 2. Obtenemos el objeto Contacto de la fila seleccionada
                Contacto contactoSeleccionado = (Contacto)dgvListadoContactos.CurrentRow.DataBoundItem;

                // 3. Abrimos la ventana de edición pasando el contacto
                EditarContacto ventanaEditar = new EditarContacto(contactoSeleccionado);
                ventanaEditar.ShowDialog();

                // 4. Refrescamos la tabla al volver
                ObtenerContactos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un contacto de la lista para editar.");
            }
        }

		private void btnEliminarContacto_Click(object sender, EventArgs e)
		{
			// Verificamos si hay una fila seleccionada
			if (dgvListadoContactos.SelectedRows.Count > 0)
			{
				// Obtenemos el objeto seleccionado
				Contacto contactoSeleccionado = (Contacto)dgvListadoContactos.CurrentRow.DataBoundItem;

				// Preguntamos al usuario si está seguro
				DialogResult resultado = MessageBox.Show(
					$"¿Está seguro de que desea eliminar a {contactoSeleccionado.Nombre}?",
					"Confirmar eliminación",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning
				);

				if (resultado == DialogResult.Yes)
				{
					try
					{
						// Llamamos a la BLL para eliminar
						bool eliminado = _contactoBLL.Eliminar(contactoSeleccionado.ContactoId);

						if (eliminado)
						{
							MessageBox.Show("Contacto eliminado correctamente.");
							ObtenerContactos();
						}
						else
						{
							MessageBox.Show("No se pudo eliminar el contacto.");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error al eliminar: " + ex.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("Por favor, seleccione un contacto de la lista para eliminar.");
			}
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
