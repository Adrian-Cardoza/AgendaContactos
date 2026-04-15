using EL;
using GUI.Autenticacion;
using GUI.Contactos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            while (true) // Bucle infinito de la app
            {
                // Usamos using para que cada vez que se cierre el login se limpie la memoria
                using (Login formLogin = new Login())
                {
                    if (formLogin.ShowDialog() == DialogResult.OK)
                    {
                        // Verificamos que el usuario realmente exista antes de abrir el Dashboard
                        if (formLogin.UsuarioAutenticado != null)
                        {
                            Application.Run(new Dashboard(formLogin.UsuarioAutenticado));
                        }
                    }
                    else
                    {
                        // Si el usuario cierra el login con la X sale del bucle
                        break;
                    }
                }
            }
        }
    }
}