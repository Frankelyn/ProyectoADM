using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominioADM.Migrations
{
    public partial class ModificandoEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MontoRenta",
                table: "PagoParqueo");

            migrationBuilder.DropColumn(
                name: "MontoRenta",
                table: "PagoApartamentos");

            migrationBuilder.AddColumn<float>(
                name: "MontoRenta",
                table: "ArriendaParqueos",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "MontoRenta",
                table: "ArriendaApartamentos",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 3, 17, 6, 39, 647, DateTimeKind.Local).AddTicks(1387));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MontoRenta",
                table: "ArriendaParqueos");

            migrationBuilder.DropColumn(
                name: "MontoRenta",
                table: "ArriendaApartamentos");

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
    }
}
