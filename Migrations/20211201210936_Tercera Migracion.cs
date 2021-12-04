using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominioADM.Migrations
{
    public partial class TerceraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParqueoId",
                table: "PagoParqueo");

            migrationBuilder.DropColumn(
                name: "ResidenteId",
                table: "PagoParqueo");

            migrationBuilder.DropColumn(
                name: "ApartamentoId",
                table: "PagoApartamentos");

            migrationBuilder.DropColumn(
                name: "ResidenteId",
                table: "PagoApartamentos");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 1, 17, 9, 35, 123, DateTimeKind.Local).AddTicks(8553));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParqueoId",
                table: "PagoParqueo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResidenteId",
                table: "PagoParqueo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApartamentoId",
                table: "PagoApartamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResidenteId",
                table: "PagoApartamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 1, 14, 30, 13, 588, DateTimeKind.Local).AddTicks(2835));
        }
    }
}
