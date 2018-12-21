using EscolaVirtual.Conteudo.Data.Context;
using EscolaVirtual.Conteudo.Domain.Cursos;
using System;
using System.Data.Entity.Migrations;

namespace EscolaVirtual.Conteudo.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ConteudoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ConteudoContext context)
        {
            context.Cursos.AddOrUpdate(x => x.CursoId,
                new Curso()
                {
                    CursoId = Guid.Parse("5c551b6c-4158-4d5a-92d1-707ed9a5839c"),
                    DataInicio = new DateTime(2018, 03, 12),
                    Nome = "Refactorings em geral",
                    Vagas = 30,
                    Valor = 340
                },
                new Curso()
                {
                    CursoId = Guid.Parse("777f1911-da04-41e9-a99f-2184b70b808c"),
                    DataInicio = new DateTime(2018, 04, 13),
                    Nome = "Domain Driven Design",
                    Vagas = 40,
                    Valor = 375
                }
            );
        }
    }
}