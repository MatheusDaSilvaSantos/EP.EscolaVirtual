namespace EscolaVirtual.Vendas.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pagamentos",
                c => new
                    {
                        PagamentoId = c.Guid(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MeioPagamento = c.Int(nullable: false),
                        AlunoId = c.Guid(nullable: false),
                        PedidoId = c.Guid(nullable: false),
                        DataPagamento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PagamentoId)
                .ForeignKey("dbo.Pedidos", t => t.PagamentoId)
                .Index(t => t.PagamentoId);
            
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        PedidoId = c.Guid(nullable: false),
                        AlunoId = c.Guid(nullable: false),
                        StatusPedido = c.Int(nullable: false),
                        DataPedido = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PedidoId);
            
            CreateTable(
                "dbo.PedidoItems",
                c => new
                    {
                        PedidoItemId = c.Guid(nullable: false),
                        CursoId = c.Guid(nullable: false),
                        Descricao = c.String(maxLength: 100, unicode: false),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PedidoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.PedidoItemId)
                .ForeignKey("dbo.Pedidos", t => t.PedidoId)
                .Index(t => t.PedidoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PedidoItems", "PedidoId", "dbo.Pedidos");
            DropForeignKey("dbo.Pagamentos", "PagamentoId", "dbo.Pedidos");
            DropIndex("dbo.PedidoItems", new[] { "PedidoId" });
            DropIndex("dbo.Pagamentos", new[] { "PagamentoId" });
            DropTable("dbo.PedidoItems");
            DropTable("dbo.Pedidos");
            DropTable("dbo.Pagamentos");
        }
    }
}
