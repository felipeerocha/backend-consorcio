using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end.Migrations
{
    /// <inheritdoc />
    public partial class CriandoProjeto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Cadastros",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 1,
                column: "NumeroCota",
                value: 5656);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 2,
                column: "NumeroCota",
                value: 4226);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 3,
                column: "NumeroCota",
                value: 2451);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 4,
                column: "NumeroCota",
                value: 3643);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 5,
                column: "NumeroCota",
                value: 2592);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 6,
                column: "NumeroCota",
                value: 2729);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 7,
                column: "NumeroCota",
                value: 8135);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 8,
                column: "NumeroCota",
                value: 5524);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 9,
                column: "NumeroCota",
                value: 9622);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 10,
                column: "NumeroCota",
                value: 5005);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 11,
                column: "NumeroCota",
                value: 5656);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 12,
                column: "NumeroCota",
                value: 4226);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 13,
                column: "NumeroCota",
                value: 2451);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 14,
                column: "NumeroCota",
                value: 3643);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 15,
                column: "NumeroCota",
                value: 2592);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 16,
                column: "NumeroCota",
                value: 2729);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 17,
                column: "NumeroCota",
                value: 8135);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 18,
                column: "NumeroCota",
                value: 5524);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 19,
                column: "NumeroCota",
                value: 9622);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 20,
                column: "NumeroCota",
                value: 5005);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 21,
                column: "NumeroCota",
                value: 5656);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 22,
                column: "NumeroCota",
                value: 4226);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 23,
                column: "NumeroCota",
                value: 2451);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 24,
                column: "NumeroCota",
                value: 3643);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 25,
                column: "NumeroCota",
                value: 2592);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 26,
                column: "NumeroCota",
                value: 2729);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 27,
                column: "NumeroCota",
                value: 8135);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 28,
                column: "NumeroCota",
                value: 5524);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 29,
                column: "NumeroCota",
                value: 9622);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 30,
                column: "NumeroCota",
                value: 5005);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Cadastros",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 1,
                column: "NumeroCota",
                value: 6430);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 2,
                column: "NumeroCota",
                value: 5497);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 3,
                column: "NumeroCota",
                value: 2487);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 4,
                column: "NumeroCota",
                value: 9966);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 5,
                column: "NumeroCota",
                value: 9084);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 6,
                column: "NumeroCota",
                value: 4753);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 7,
                column: "NumeroCota",
                value: 7110);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 8,
                column: "NumeroCota",
                value: 7501);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 9,
                column: "NumeroCota",
                value: 8048);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 10,
                column: "NumeroCota",
                value: 5322);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 11,
                column: "NumeroCota",
                value: 6430);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 12,
                column: "NumeroCota",
                value: 5497);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 13,
                column: "NumeroCota",
                value: 2487);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 14,
                column: "NumeroCota",
                value: 9966);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 15,
                column: "NumeroCota",
                value: 9084);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 16,
                column: "NumeroCota",
                value: 4753);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 17,
                column: "NumeroCota",
                value: 7110);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 18,
                column: "NumeroCota",
                value: 7501);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 19,
                column: "NumeroCota",
                value: 8048);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 20,
                column: "NumeroCota",
                value: 5322);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 21,
                column: "NumeroCota",
                value: 6430);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 22,
                column: "NumeroCota",
                value: 5497);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 23,
                column: "NumeroCota",
                value: 2487);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 24,
                column: "NumeroCota",
                value: 9966);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 25,
                column: "NumeroCota",
                value: 9084);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 26,
                column: "NumeroCota",
                value: 4753);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 27,
                column: "NumeroCota",
                value: 7110);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 28,
                column: "NumeroCota",
                value: 7501);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 29,
                column: "NumeroCota",
                value: 8048);

            migrationBuilder.UpdateData(
                table: "Cotas",
                keyColumn: "Id",
                keyValue: 30,
                column: "NumeroCota",
                value: 5322);
        }
    }
}
