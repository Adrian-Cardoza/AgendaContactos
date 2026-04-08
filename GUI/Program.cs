using GUI.Autenticacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // pre-validación para iniciar nuestro sistema
            // a través de nuestro Login

            // crear una instancia (objeto) de nuestra clase Login
            Login formLogin = new Login();

            // guardar el valor devuelto
            var respuesta = formLogin.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                // este método inicializa el formulario a mostrar
                // (Cambia Form1 por el nombre de tu Menú Principal si es distinto)
                Application.Run(new Form1());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
