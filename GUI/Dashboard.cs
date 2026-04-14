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

namespace GUI
{
	public partial class Dashboard : Form
	{
		private Usuario _usuarioSesion;
		private ContactoBll _contactoBLL = new ContactoBll();

		public Dashboard(Usuario usuarioRecibido)
		{
			InitializeComponent();
			_usuarioSesion = usuarioRecibido;
			lblNombreUsuario.Text = $"Agenda Dashboard de {_usuarioSesion.NombreCompleto}";
			ActualizarEstadisticas();
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
			Application.Exit();
		}
	}
}
