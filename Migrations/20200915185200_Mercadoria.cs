using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MStartSupply_CT.Migrations
{
    public partial class Mercadoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mercadoria",
                columns: table => new
                {
                    MercadoriaID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantidade = table.Column<int>(nullable: false),
                    NumeroRegistro = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Fabricante = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercadoria", x => x.MercadoriaID);
                });

            migrationBuilder.CreateTable(
                name: "Entrada",
                columns: table => new
                {
                    EntradaID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantidade = table.Column<int>(nullable: false),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    LocalEntrada = table.Column<string>(nullable: true),
                    MercadoriaID = table.Column<string>(nullable: true),
                    MercadoriaID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrada", x => x.EntradaID);
                    table.ForeignKey(
                        name: "FK_Entrada_Mercadoria_MercadoriaID1",
                        column: x => x.MercadoriaID1,
                        principalTable: "Mercadoria",
                        principalColumn: "MercadoriaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Saida",
                columns: table => new
                {
                    SaidaID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantidade = table.Column<int>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: false),
                    LocalSaida = table.Column<string>(nullable: true),
                    MercadoriaID = table.Column<string>(nullable: true),
                    MercadoriaID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saida", x => x.SaidaID);
                    table.ForeignKey(
                        name: "FK_Saida_Mercadoria_MercadoriaID1",
                        column: x => x.MercadoriaID1,
                        principalTable: "Mercadoria",
                        principalColumn: "MercadoriaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_MercadoriaID1",
                table: "Entrada",
                column: "MercadoriaID1");

            migrationBuilder.CreateIndex(
                name: "IX_Saida_MercadoriaID1",
                table: "Saida",
                column: "MercadoriaID1");

            migrationBuilder.Sql(@"CREATE TRIGGER afterInsertEntrada
                AFTER INSERT
                ON Entrada
                FOR EACH ROW
                BEGIN UPDATE Mercadoria SET Quantidade = Quantidade + NEW.Quantidade
                WHERE MercadoriaID = NEW.MercadoriaID;
                END");

            migrationBuilder.Sql(@"CREATE TRIGGER afterDeleteEntrada
                AFTER DELETE
                ON Entrada
                FOR EACH ROW
                BEGIN
                UPDATE Mercadoria SET Quantidade = Quantidade - OLD.Quantidade
                WHERE MercadoriaID = OLD.MercadoriaID;
                END");

            migrationBuilder.Sql(@"CREATE TRIGGER afterInsertSaida
                AFTER INSERT
                ON Saida
                FOR EACH ROW
                BEGIN UPDATE Mercadoria SET Quantidade = Quantidade + NEW.Quantidade
                WHERE MercadoriaID = NEW.MercadoriaID;
                END");

            migrationBuilder.Sql(@"CREATE TRIGGER afterDeleteSaida
                AFTER DELETE
                ON Saida
                FOR EACH ROW
                BEGIN
                UPDATE Mercadoria SET Quantidade = Quantidade - OLD.Quantidade
                WHERE MercadoriaID = OLD.MercadoriaID;
                END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrada");

            migrationBuilder.DropTable(
                name: "Saida");

            migrationBuilder.DropTable(
                name: "Mercadoria");

            migrationBuilder.Sql(@"DROP TRIGGER afterInsertEntrada");
            migrationBuilder.Sql(@"DROP TRIGGER afterDeleteEntrada");

            migrationBuilder.Sql(@"DROP TRIGGER afterInsertSaida");
            migrationBuilder.Sql(@"DROP TRIGGER afterDeleteSaida");
        }
    }
}
