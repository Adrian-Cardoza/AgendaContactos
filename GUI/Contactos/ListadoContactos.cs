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
		[System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]

		private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
		private const int EM_SETCUEBANNER = 0x1501;

		ContactoBll _contactoBLL = new ContactoBll();
		private Usuario _usuarioSesion;

		public ListadoContactos(Usuario usuarioRecibido)
        {
            InitializeComponent();
			_usuarioSesion = usuarioRecibido;
		}

        private void ListadoContactos_Load(object sender, EventArgs e)
        {
			SendMessage(txtBuscar.Handle, EM_SETCUEBANNER, 0, "Buscar un contacto...");
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
			string palabra = txtBuscar.Text.Trim().ToLower();

			// Si está vacío, mostramos todo. 
			// Ya no hay riesgo de que compare contra "Buscar un contacto"
			if (string.IsNullOrWhiteSpace(palabra))
			{
				ObtenerContactos();
				return;
			}

			_contactoBLL = new ContactoBll();
			var listaCompleta = _contactoBLL.MostrarContactos(_usuarioSesion.UsuarioId);

			var filtrado = listaCompleta.Where(c =>
				(c.Nombre != null && c.Nombre.ToLower().Contains(palabra)) ||
				(c.Telefono != null && c.Telefono.Contains(palabra))
			).ToList();

			dgvListadoContactos.DataSource = null;
			dgvListadoContactos.DataSource = filtrado;
		}

        private void btnEditarContacto_Click(object sender, EventArgs e)
        {
            // 1. Verificamos si hay una fila seleccionada en el DataGridView
            if (dgvListadoContactos.SelectedRows.Count > 0)
            {
                // 2. Obtenemos el objeto Contacto de la fila seleccionaddvv  dwsadawdsada
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
