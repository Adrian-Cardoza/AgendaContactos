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
                        ContactoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Telefono = c.String(),
                        Correo = c.String(),
                        Direccion = c.String(),
                        FechaRegistro = c.DateTime(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactoId)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        NombreUsuario = c.String(),
                        Contrasena = c.String(),
                        NombreCompleto = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contactos", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Contactos", new[] { "UsuarioId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Contactos");
        }
    }
}
