using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace back_end.Migrations
{
    /// <inheritdoc />
    public partial class CriandoDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consorcios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<int>(type: "int", nullable: true),
                    QuantidadeCotas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consorcios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cotas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsorcioId = table.Column<int>(type: "int", nullable: false),
                    NumeroCota = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cotas_Consorcios_ConsorcioId",
                        column: x => x.ConsorcioId,
                        principalTable: "Consorcios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cadastros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CotaId = table.Column<int>(type: "int", nullable: false),
                    NumeroCota = table.Column<int>(type: "int", nullable: false),
                    NomeUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parcelamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cadastros_Cotas_CotaId",
                        column: x => x.CotaId,
                        principalTable: "Cotas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Consorcios",
                columns: new[] { "Id", "QuantidadeCotas", "Tipo", "Titulo", "Valor" },
                values: new object[,]
                {
                    { 1, 10, "Imóvel", "Consórcio de Casa", 500000 },
                    { 2, 10, "Carro", "Consórcio de Carro", 200000 },
                    { 3, 10, "Serviço", "Consórcio de Reforma", 70000 }
                });

            migrationBuilder.InsertData(
                table: "Cotas",
                columns: new[] { "Id", "ConsorcioId", "NumeroCota", "Status", "Valor" },
                values: new object[,]
                {
                    { 1, 1, 6430, "Disponível", 50000m },
                    { 2, 1, 5497, "Disponível", 50000m },
                    { 3, 1, 2487, "Disponível", 50000m },
                    { 4, 1, 9966, "Disponível", 50000m },
                    { 5, 1, 9084, "Disponível", 50000m },
                    { 6, 1, 4753, "Disponível", 50000m },
                    { 7, 1, 7110, "Disponível", 50000m },
                    { 8, 1, 7501, "Disponível", 50000m },
                    { 9, 1, 8048, "Disponível", 50000m },
                    { 10, 1, 5322, "Disponível", 50000m },
                    { 11, 2, 6430, "Disponível", 20000m },
                    { 12, 2, 5497, "Disponível", 20000m },
                    { 13, 2, 2487, "Disponível", 20000m },
                    { 14, 2, 9966, "Disponível", 20000m },
                    { 15, 2, 9084, "Disponível", 20000m },
                    { 16, 2, 4753, "Disponível", 20000m },
                    { 17, 2, 7110, "Disponível", 20000m },
                    { 18, 2, 7501, "Disponível", 20000m },
                    { 19, 2, 8048, "Disponível", 20000m },
                    { 20, 2, 5322, "Disponível", 20000m },
                    { 21, 3, 6430, "Disponível", 7000m },
                    { 22, 3, 5497, "Disponível", 7000m },
                    { 23, 3, 2487, "Disponível", 7000m },
                    { 24, 3, 9966, "Disponível", 7000m },
                    { 25, 3, 9084, "Disponível", 7000m },
                    { 26, 3, 4753, "Disponível", 7000m },
                    { 27, 3, 7110, "Disponível", 7000m },
                    { 28, 3, 7501, "Disponível", 7000m },
                    { 29, 3, 8048, "Disponível", 7000m },
                    { 30, 3, 5322, "Disponível", 7000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cadastros_CotaId",
                table: "Cadastros",
                column: "CotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotas_ConsorcioId",
                table: "Cotas",
                column: "ConsorcioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastros");

            migrationBuilder.DropTable(
                name: "Cotas");

            migrationBuilder.DropTable(
                name: "Consorcios");
        }
    }
}
