using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EL;

namespace BLL
{
    public class UsuarioBll
    {
        public DAL.UsuarioDal _usuarioDAL = new DAL.UsuarioDal();

        public bool ValidarUsuario(string user, string pass)
        {
            // Llamamos a la DAL
            var resultado = _usuarioDAL.Validar(user, pass);

            // Si el resultado no es nulo, significa que el usuario EXISTE
            return resultado != null;
        }
    }
}
