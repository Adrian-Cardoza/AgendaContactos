using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDal
    {


        // MÉTODO PARA EL LOGIN
        public Usuario Validar(string nombreUsuario, string password)
        {
            try
            {
                using (var db = new AgendaDbContext())
                {
                    // Buscamos un usuario que coincida con el nombre y contraseña
                    return db.Usuarios.FirstOrDefault(u =>
                        u.NombreUsuario == nombreUsuario &&
                        u.Contrasena == password);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR DAL VALIDAR: " + ex.Message);
                return null;
            }
        }

        // MÉTODO PARA EL REGISTRO
        public bool ExisteUsuario(string nombreUsuario)
        {
            try
            {
                using (var db = new AgendaDbContext())
                {
                    return db.Usuarios.Any(u => u.NombreUsuario.ToLower() == nombreUsuario.ToLower());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR REAL: " + ex.Message);
                return false;
            }
        }

        // MÉTODO PARA EL REGISTRO
        public bool Insertar(Usuario entidad)
        {
            try
            {
                using (var db = new AgendaDbContext())
                {
                    db.Usuarios.Add(entidad);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
throw new Exception("Error en la base de datos: " + ex.Message);
                return false;
            }
        }
    }
}