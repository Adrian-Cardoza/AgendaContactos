using EL;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class ContactoDal
    {
        AgendaDbContext _db; // Variable privada para el contexto

        // Método para guardar o editar un contacto
        public int Guardar(Contacto contacto, bool esEdicion = false)
        {
            int resultado = 0;

            try
            {
                // Inicializar nuestro DbContext
                _db = new AgendaDbContext();

                if (esEdicion)
                {
                    // Lógica para editar un contacto existente
                    var contactoExistente = _db.Contactos.Find(contacto.ContactoId);
                    if (contactoExistente != null)
                    {
                        contactoExistente.Nombre = contacto.Nombre;
                        contactoExistente.Telefono = contacto.Telefono;
                        contactoExistente.Correo = contacto.Correo;
                        contactoExistente.Direccion = contacto.Direccion;

                        _db.SaveChanges();
                        resultado = contacto.ContactoId;
                    }
                }
                else
                {
                    // Insertar nuestro contacto
                    _db.Contactos.Add(contacto);

                    // Guardar los cambios en SQL Server
                    _db.SaveChanges();

                    // Retornamos el ID generado
                    resultado = contacto.ContactoId;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR REAL: " + ex.InnerException?.InnerException?.Message ?? ex.Message);
                resultado = -1;
            }

            return resultado;
        }

        // Método para mostrar los contactos filtrados por el usuario logueado
        public List<Contacto> MostrarContactos(int idUsuario)
        {
            List<Contacto> contactos = new List<Contacto>();
            try
            {
                // Inicializar nuestro DbContext
                _db = new AgendaDbContext();

                // Obtener la lista filtrada para que la agenda sea privada
                contactos = _db.Contactos.Where(c => c.UsuarioId == idUsuario).ToList();
            }
            catch (Exception ex)
            {
                // En caso de error, retorna la lista vacía
            }
            return contactos;
        }
        public bool Eliminar(int idContacto)
        {
            bool respuesta = false;
            try
            {
                // Inicializamos el contexto
                _db = new AgendaDbContext();

                // Buscamos el registro en la base de datos por su ID
                var contacto = _db.Contactos.Find(idContacto);

                if (contacto != null)
                {
                    // Lo removemos del DbSet
                    _db.Contactos.Remove(contacto);

                    // Guardamos los cambios en SQL Server
                    _db.SaveChanges();

                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                // Si hay un error de conexión o restricción, respuesta sigue siendo false
                respuesta = false;
            }

            return respuesta;
        }
    }
}

