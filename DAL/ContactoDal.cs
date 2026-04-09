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
        AgendaDbContext _db;

        public int Guardar(Contacto contacto, bool esEdicion = false)
        {
            int resultado = 0;

            try
            {
                _db = new AgendaDbContext();

                if (esEdicion)
                {
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
                    // ASIGNAMOS FECHA Y GUARDAMOS UNA SOLA VEZ
                    contacto.FechaRegistro = DateTime.Now;
                    _db.Contactos.Add(contacto);
                    _db.SaveChanges();

                    // Retornamos el ID generado por SQL
                    resultado = contacto.ContactoId;
                }
            }
            catch (Exception ex)
            {
                string errorInner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                System.Diagnostics.Trace.WriteLine("ERROR_SQL_LOG: " + errorInner);
                resultado = 0;
            }

            return resultado;
        }
       

        public List<Contacto> MostrarContactos(int idUsuario)
        {
            List<Contacto> contactos = new List<Contacto>();
            try
            {
                _db = new AgendaDbContext();
                contactos = _db.Contactos.Where(c => c.UsuarioId == idUsuario).ToList();
            }
            catch (Exception ex)
            {
                // Se mantiene igual
            }
            return contactos;
        }

        public bool Eliminar(int idContacto)
        {
            bool respuesta = false;
            try
            {
                _db = new AgendaDbContext();
                var contacto = _db.Contactos.Find(idContacto);

                if (contacto != null)
                {
                    _db.Contactos.Remove(contacto);
                    _db.SaveChanges();
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
            }

            return respuesta;
        }


    }
}