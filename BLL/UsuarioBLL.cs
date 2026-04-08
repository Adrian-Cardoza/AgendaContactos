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
        // Una sola instancia de la DAL para toda la clase
        private UsuarioDal _usuarioDAL = new UsuarioDal();

        // MÉTODO PARA EL LOGIN
        public bool ValidarUsuario(string user, string pass)
        {
            // Llamamos a la DAL
            var resultado = _usuarioDAL.Validar(user, pass);

            // Si el resultado no es nulo, significa que el usuario EXISTE
            return resultado != null;
        }

        // MÉTODO PARA EL REGISTRO
        public string RegistrarNuevoUsuario(Usuario usuario)
        {
            // Regla 1: Validar que los datos no lleguen nulos o espacios vacíos
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario) || string.IsNullOrWhiteSpace(usuario.Contrasena))
                return "El usuario y la contraseña son obligatorios.";

            // Regla 2: Validar longitud de la contraseña
            if (usuario.Contrasena.Length < 5)
                return "La contraseña debe tener al menos 5 caracteres.";

            // Regla 3: Validar que no exista el nombre (Llamada a DAL)
            if (_usuarioDAL.ExisteUsuario(usuario.NombreUsuario))
                return "Este nombre de usuario ya está registrado. Elige otro.";

            // Si pasó todas las reglas, mandamos a guardar a través de la DAL
            bool resultado = _usuarioDAL.Insertar(usuario);

            return resultado ? "EXITO" : "Hubo un error interno en la base de datos.";
        }
    }
}