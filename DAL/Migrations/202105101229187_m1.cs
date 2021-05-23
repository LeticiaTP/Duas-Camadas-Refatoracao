namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                p => new
                    {
                        Id = p.Int(nullable: false, identity: true),
                        Nome = p.String(),
                        Marca = p.String(),
                        Tipo = p.String(),
                        Quantidade = p.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
        }
    }
}
