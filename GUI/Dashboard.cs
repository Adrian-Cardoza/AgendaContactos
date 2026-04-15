using BLL;
using EL;
using GUI.Autenticacion;
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
		private ContactoBll _contactoBLL = new ContactoBll();

		public Dashboard(Usuario usuarioRecibido)
		{
			InitializeComponent();
            if (usuarioRecibido != null)
            {
                _usuarioSesion = usuarioRecibido;
                if (_usuarioSesion != null && !string.IsNullOrEmpty(_usuarioSesion.NombreCompleto))
                {
                    // 1. Dividimos el nombre completo en partes separadas por espacios
                    string[] partes = _usuarioSesion.NombreCompleto.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // 2. Verificamos si tiene al menos dos partes (Nombre y Apellido)
                    if (partes.Length >= 2)
                    {
                        // Tomamos la posición 0 (Nombre) y la 2 (Apellido)
                        lblNombreUsuario.Text = $"Bienvenido, {partes[0]} {partes[2]}";
                    }
                    else
                    {
                        // Si por alguna razón solo tiene un nombre, ponemos ese
                        lblNombreUsuario.Text = $"Bienvenido, {partes[0]}";
                    }
                }
                ActualizarEstadisticas();
            }
            else
            {
                MessageBox.Show("Error de sesión. Por favor inicie sesión nuevamente.");
                this.Close();
            }
        }

		private void Dashboard_Load(object sender, EventArgs e)
		{
			ActualizarEstadisticas();
		}

		private void ActualizarEstadisticas()
		{
			try
			{
				// Obtenemos todos los contactos del usuario
				var lista = _contactoBLL.ObtenerContactos(_usuarioSesion.UsuarioId);

				// Calculamos el total
				int totalContactos = lista.Count;

				// Obtenemos los últimos 2 agregados
				var ultimos = lista.OrderByDescending(c => c.FechaRegistro).Take(2).ToList();

				string textoUltimos = "Ninguno";
				if (ultimos.Any())
				{
					textoUltimos = string.Join(", ", ultimos.Select(c => c.Nombre));
				}

				// Mostramos la info en el Label de la barra inferior
				lblInfoResumen.Text = $"📊 Total de contactos: {totalContactos}   |   🕒 Últimos agregados: {textoUltimos}";
			}
			catch (Exception ex)
			{
				lblInfoResumen.Text = "No se pudieron cargar las estadísticas.";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Creamos la instancia del formulario de Agregar y le pasamos el usuario actual
			GUI.Contactos.AgregarContacto frmCrear = new GUI.Contactos.AgregarContacto(_usuarioSesion);

			// Lo mostramos como un cuadro de diálogo
			frmCrear.ShowDialog();
			ActualizarEstadisticas();
		}

		private void btnListadoContactos_Click(object sender, EventArgs e)
		{
			GUI.Contactos.ListadoContactos frmListado = new GUI.Contactos.ListadoContactos(_usuarioSesion);
			this.Hide();
			frmListado.ShowDialog();
			ActualizarEstadisticas();
			this.Show();
		}

		private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
		{
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // 1. Preguntar al usuario si realmente quiere salir
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // 2. Instanciar el formulario de Login
                Login frmLogin = new Login();

                // 3. Mostrar el Login
                frmLogin.Show();

                // 4. Desvincular el evento FormClosed momentáneamente para que no cierre la aplicación
                this.FormClosed -= Dashboard_FormClosed;

                // 5. Cerrar el Dashboard actual
                this.Close();
            }
        }
    }
}
