namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IniciarBaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contactos",
                c => new
                    {
                        ContactoID = c.Int(nullable: false, identity: true),
                        TipoContactoId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.String(),
                        Celular = c.String(),
                        correo = c.String(),
                        Direccion = c.String(),
                        Empresa = c.String(),
                        Cargo = c.String(),
                        Notas = c.String(),
                        FechaCreacion = c.DateTime(nullable: false),
                        FechaModificacion = c.DateTime(nullable: false),
                        Activo = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ContactoID)
                .ForeignKey("dbo.TipoContactos", t => t.TipoContactoId, cascadeDelete: true)
                .Index(t => t.TipoContactoId);
            
            CreateTable(
                "dbo.TipoContactos",
                c => new
                    {
                        TipoContactoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Activo = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.TipoContactoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contactos", "TipoContactoId", "dbo.TipoContactos");
            DropIndex("dbo.Contactos", new[] { "TipoContactoId" });
            DropTable("dbo.TipoContactos");
            DropTable("dbo.Contactos");
        }
    }
}
