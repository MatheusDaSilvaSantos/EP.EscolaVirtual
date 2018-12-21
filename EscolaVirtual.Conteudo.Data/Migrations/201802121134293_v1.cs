namespace EscolaVirtual.Conteudo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursos",
                c => new
                    {
                        CursoId = c.Guid(nullable: false),
                        Nome = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataInicio = c.DateTime(nullable: false),
                        Vagas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CursoId);
            
            CreateTable(
                "dbo.Matriculas",
                c => new
                    {
                        MatriculaId = c.Guid(nullable: false),
                        AlunoId = c.Guid(nullable: false),
                        CursoId = c.Guid(nullable: false),
                        DataMatricula = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MatriculaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Matriculas");
            DropTable("dbo.Cursos");
        }
    }
}
