namespace EscolaVirtual.Cadastro.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunos",
                c => new
                    {
                        AlunoId = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                        CPF = c.String(maxLength: 100, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        Premium = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AlunoId);
           
        }
        
        public override void Down()
        {
            DropTable("dbo.Alunos");
        }
    }
}
