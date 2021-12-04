using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominioADM.Migrations
{
    public partial class MondificandoEntidadesdePagos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "MontoRenta",
                table: "PagoParqueo",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "MontoRenta",
                table: "PagoApartamentos",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 3, 16, 52, 11, 145, DateTimeKind.Local).AddTicks(7397));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MontoRenta",
                table: "PagoParqueo");

            migrationBuilder.DropColumn(
                name: "MontoRenta",
                table: "PagoApartamentos");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 3, 16, 17, 28, 631, DateTimeKind.Local).AddTicks(1878));
        }
    }
}
