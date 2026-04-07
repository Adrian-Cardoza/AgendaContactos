using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class Usuario
	{
		public int UsuarioId { get; set; }
		public string NombreUsuario { get; set; } // Para el Login
		public string Contrasena { get; set; }      // Para el Login
		public string NombreCompleto { get; set; }

		// Propiedad de navegación: Un usuario tiene muchos contactos
		public List<Contacto> Contactos { get; set; }
	}
}
