using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using EL;


namespace CUI
{
	public class Program
	{
        static ContactoBll _contactoBLL;
        static int idUsuarioLogueado = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO A LA AGENDA DEL ING. PIÑATA");
            do
            {
                Console.WriteLine("\nIngrese Opcion:");
                Console.WriteLine("1. Ver mis Contactos.");
                Console.WriteLine("2. Crear nuevo Contacto.");
                Console.WriteLine("3. Buscar Contacto.");
                Console.WriteLine("4. Eliminar Contacto.");
                Console.WriteLine("5. Actualizar Contacto.");
                Console.WriteLine("0. Salir");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("¡Hasta pronto!");
                            return;
                        case 1:
                            ObtenerContactos();
                            break;
                        case 2:
                            GuardarContacto();
                            break;
                        case 3:
                            BuscarContacto();
                            break;
                        case 4:
                            EliminarContacto(); 
                            break;
                        case 5:
                            ActualizarContacto();
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida, intente de nuevo.");
                }
            }
            while (true);
        }

        static void GuardarContacto()
        {
            Contacto contacto = new Contacto();

            Console.WriteLine("\n--- Registro de Nuevo Contacto ---");
            Console.Write("Nombre completo: ");
            contacto.Nombre = Console.ReadLine();

            Console.Write("Teléfono: ");
            contacto.Telefono = Console.ReadLine();

            Console.Write("Correo electrónico: ");
            contacto.Correo = Console.ReadLine();

            Console.Write("Dirección: ");
            contacto.Direccion = Console.ReadLine();

            contacto.FechaRegistro = DateTime.Now;

            // Asignamos el contacto al usuario que tiene la sesión
            contacto.UsuarioId = idUsuarioLogueado;

            _contactoBLL = new ContactoBll();
            int resultado = _contactoBLL.Guardar(contacto);

            if (resultado > 0)
            {
                Console.WriteLine(">> Contacto guardado con éxito. ID: " + resultado);
            }
            else
            {
                Console.WriteLine(">> Error: No se pudo guardar el contacto.");
            }
        }

        static void ObtenerContactos()
        {
            _contactoBLL = new ContactoBll();

            // Pasamos el ID del usuario para que solo vea los suyos
            var lista = _contactoBLL.ObtenerContactos(idUsuarioLogueado);

            Console.WriteLine("\n--- Lista de Contactos ---");
            if (lista.Count == 0) Console.WriteLine("No hay contactos registrados.");

            foreach (var item in lista)
            {
                Console.WriteLine($"- {item.Nombre} | Tel: {item.Telefono} | Email: {item.Correo}");
            }
        }

        static void ActualizarContacto()
        {
            Console.WriteLine("\n--- Actualizar Contacto ---");
            Console.Write("Ingrese el ID del contacto que desea actualizar: ");

            if (int.TryParse(Console.ReadLine(), out int idActualizar))
            {
                Contacto contacto = new Contacto();
                contacto.ContactoId = idActualizar;

                Console.WriteLine("Ingrese los nuevos datos:");

                Console.Write("Nuevo Nombre completo: ");
                contacto.Nombre = Console.ReadLine();

                Console.Write("Nuevo Teléfono: ");
                contacto.Telefono = Console.ReadLine();

                Console.Write("Nuevo Correo electrónico: ");
                contacto.Correo = Console.ReadLine();

                Console.Write("Nueva Dirección: ");
                contacto.Direccion = Console.ReadLine();

                contacto.UsuarioId = idUsuarioLogueado;

                _contactoBLL = new ContactoBll();

                // CAMBIO AQUÍ: Usamos 'int' porque Guardar devuelve un entero
                int resultado = _contactoBLL.Guardar(contacto, true);

                if (resultado > 0)
                {
                    Console.WriteLine(">> Contacto actualizado con éxito.");
                }
                else
                {
                    Console.WriteLine(">> Error: No se pudo actualizar. Verifique que el ID exista.");
                }
            }
            else
            {
                Console.WriteLine(">> ID inválido.");
            }
        }


        static void EliminarContacto()
        {
            Console.WriteLine("\nEliminar Contacto");
            Console.Write("Ingrese el ID del contacto que desea eliminar: ");

            if (int.TryParse(Console.ReadLine(), out int idEliminar))
            {
                _contactoBLL = new ContactoBll();

                // Antes de borrar, podrías pedir una confirmación
                Console.Write($"¿Está seguro de eliminar el contacto con ID {idEliminar}? (s/n): ");
                string confirmar = Console.ReadLine();

                if (confirmar.ToLower() == "s")
                {
                    bool eliminado = _contactoBLL.Eliminar(idEliminar);

                    if (eliminado)
                    {
                        Console.WriteLine(" Contacto eliminado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine(" Error: No se encontró el contacto o no se pudo eliminar.");
                    }
                }
                else
                {
                    Console.WriteLine(" Operación cancelada.");
                }
            }
            else
            {
                Console.WriteLine(" ID inválido.");
            }
        }

        static void BuscarContacto()
        {
            Console.Write("\nIngrese el nombre o teléfono a buscar: ");
            string palabra = Console.ReadLine().ToLower();

            _contactoBLL = new ContactoBll();

            // 1. Obtenemos todos los contactos del usuario
            var todosLosContactos = _contactoBLL.MostrarContactos(idUsuarioLogueado);

            // 2. Filtramos en memoria usando LINQ
            var resultados = todosLosContactos.Where(c =>
                (c.Nombre != null && c.Nombre.ToLower().Contains(palabra)) ||
                (c.Telefono != null && c.Telefono.Contains(palabra))
            ).ToList();

            Console.WriteLine("\n--- Resultados de Búsqueda ---");
            if (resultados.Count == 0)
            {
                Console.WriteLine("No se encontraron coincidencias.");
            }
            else
            {
                foreach (var item in resultados)
                {
                    Console.WriteLine($"- {item.Nombre} | Tel: {item.Telefono}");
                }
            }
        }
    }
}

