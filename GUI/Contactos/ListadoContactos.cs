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
        int idUsuarioLogueado = 1;
        public ListadoContactos()
        {
            InitializeComponent();
        }

        private void ListadoContactos_Load(object sender, EventArgs e)
        {
            ObtenerContactos();
        }

        private void ObtenerContactos()
        {
            // 'dgvContactos' es el nombre de tu DataGridView. 
            // Si le pusiste otro nombre en las propiedades, cámbialo aquí.
            try
            {
                var lista = _contactoBLL.ObtenerContactos(idUsuarioLogueado);
                dgvListadoContactos.DataSource = null;
                dgvListadoContactos.DataSource = lista;
                dgvListadoContactos.AutoGenerateColumns = true;
                dgvListadoContactos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnAñadirContacto_Click(object sender, EventArgs e)
        {
            // 1. Creamos una instancia de la ventana
            AgregarContacto ventanaAgregar = new AgregarContacto();

            // 2. La mostramos de forma modal (bloquea la ventana de atrás hasta cerrar esta)
            ventanaAgregar.ShowDialog();
            

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

            // 1. Traemos la lista completa original
            var listaCompleta = _contactoBLL.MostrarContactos(idUsuarioLogueado);

            // 2. Filtramos usando LINQ (necesitas 'using System.Linq;' arriba)
            var filtrado = listaCompleta.Where(c =>
                (c.Nombre != null && c.Nombre.ToLower().Contains(palabra)) ||
                (c.Telefono != null && c.Telefono.Contains(palabra))
            ).ToList();

            // 3. Mostramos solo los resultados filtrados en el DataGridView
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
    }
}
