using EL;
using System;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class AgendaDbContext : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'AgendaDbContext' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'DAL.AgendaDbContext' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'AgendaDbContext'  en el archivo de configuración de la aplicación.
        public AgendaDbContext()
            : base("name=AgendaDbContext")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Contacto> Contacto { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}