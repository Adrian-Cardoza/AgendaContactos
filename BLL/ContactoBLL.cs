using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;



namespace BLL
{
    public class ContactoBll
    {
        // Instancia de la clase ContactoDal
        public ContactoDal _contactoDal;

        // Método para guardar un contacto con limpieza de datos
        public int Guardar(Contacto contacto, bool esEdicion = false)
        {
            // Inicializar la instancia de ContactoDal
            _contactoDal = new ContactoDal();

            // Lógica de limpieza (Trimming y quitar guiones de los teléfonos)
            // Esto asegura que si el usuario pone "  7788 - 9900  ", se guarde como "77889900"
            if (!string.IsNullOrEmpty(contacto.Telefono))
            {
                contacto.Telefono = contacto.Telefono.Trim().Replace("-", "").Replace(" ", "");
            }

            if (!string.IsNullOrEmpty(contacto.Nombre))
            {
                contacto.Nombre = contacto.Nombre.Trim();
            }

            // Llamar al método Guardar de la clase ContactoDal
            int resultado = _contactoDal.Guardar(contacto, esEdicion);

            return resultado;
        }

        // Obtener el listado de contactos filtrado por usuario
        public List<Contacto> ObtenerContactos(int idUsuario)
        {
            // Inicializar la instancia de ContactoDal
            _contactoDal = new ContactoDal();

            // Llamamos al método MostrarContactos de la clase ContactoDal
            var listado = _contactoDal.MostrarContactos(idUsuario);

            return listado;
        }

        // Método para eliminar (siguiendo la misma lógica de instancia)
        public bool Eliminar(int idContacto)
        {
            _contactoDal = new ContactoDal();
            return _contactoDal.Eliminar(idContacto);
        }

        // Método para buscar (siguiendo la misma lógica de instancia)
        public List<Contacto> MostrarContactos(int idUsuario)
        {
            _contactoDal = new ContactoDal();
            return _contactoDal.MostrarContactos(idUsuario);
        }

		public bool ValidarTelefonoExistente(string telefono, int usuarioId)
		{
			// Obtenemos todos los contactos del usuario
			var contactos = ObtenerContactos(usuarioId);

			// Verificamos si alguno tiene el mismo número (limpiando espacios)
			return contactos.Any(c => c.Telefono.Trim() == telefono.Trim());
		}
	}
}