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
        // contexto de base de datos
        private AgendaDbContext _db;

        public Usuario Validar(string nombreUsuario, string password)
        {
            Usuario usuario = null;
            try
            {
                using (_db = new AgendaDbContext())
                {
                    // Buscamos un usuario que coincida con el nombre y el password
                    usuario = _db.Usuarios.FirstOrDefault(u =>
                        u.NombreUsuario == nombreUsuario &&
                        u.Contrasena == password);
                }
            }
            catch (Exception ex)
            {
                // Si algo truena, al menos sabemos qué fue
                Console.WriteLine("ERROR DAL USUARIO: " + ex.Message);
            }
            return usuario;
        }
    }
}
