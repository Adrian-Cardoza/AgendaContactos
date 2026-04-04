using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Contacto
    {
        public int ContactoID { get; set; }
        public int TipoContactoId { get; set; }
        public TipoContacto TipoContacto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string correo { get; set; }
        public string Direccion { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public string Notas { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public byte Activo { get; set; }
    }
}
