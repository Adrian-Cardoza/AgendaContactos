using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Contacto
    {
        // Se cambió ContactoID a Id para coincidir con la llave primaria de la tabla
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        // Se ajustó a PascalCase (Correo) por convención de C#
        public string Correo { get; set; }

        public string Direccion { get; set; }

        // Se cambió FechaCreacion a FechaRegistro para coincidir con el diseño del DataGridView
        public DateTime FechaRegistro { get; set; }
    }
}
