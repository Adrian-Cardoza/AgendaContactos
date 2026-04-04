using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
	public class TipoContacto
	{
		public int TipoContactoId { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public byte Activo { get; set; }
	}
}
