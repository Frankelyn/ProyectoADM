using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominioADM.Migrations
{
    public partial class ModificandoEntidadesdeArrienda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArriendaParqueos_Parqueos_ParqueoId",
                table: "ArriendaParqueos");

            migrationBuilder.DropForeignKey(
                name: "FK_ArriendaParqueos_Residentes_ResidenteId",
                table: "ArriendaParqueos");

            migrationBuilder.DropIndex(
                name: "IX_ArriendaParqueos_ParqueoId",
                table: "ArriendaParqueos");

            migrationBuilder.DropIndex(
                name: "IX_ArriendaParqueos_ResidenteId",
                table: "ArriendaParqueos");

            migrationBuilder.DropColumn(
                name: "ParqueoId",
                table: "ArriendaParqueos");

            migrationBuilder.DropColumn(
                name: "Apartamento",
                table: "ArriendaApartamentos");

            migrationBuilder.RenameColumn(
                name: "ResidenteId",
                table: "ArriendaParqueos",
                newName: "NumeroParqueo");

            migrationBuilder.RenameColumn(
                name: "Residente",
                table: "ArriendaApartamentos",
                newName: "NombreResidente");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRenovacion",
                table: "ArriendaParqueos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NombreResidente",
                table: "ArriendaParqueos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaRenovacion",
                table: "ArriendaApartamentos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "NumeroApartamento",
                table: "ArriendaApartamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 3, 12, 2, 44, 453, DateTimeKind.Local).AddTicks(1577));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaRenovacion",
                table: "ArriendaParqueos");

            migrationBuilder.DropColumn(
                name: "NombreResidente",
                table: "ArriendaParqueos");

            migrationBuilder.DropColumn(
                name: "FechaRenovacion",
                table: "ArriendaApartamentos");

            migrationBuilder.DropColumn(
                name: "NumeroApartamento",
                table: "ArriendaApartamentos");

            migrationBuilder.RenameColumn(
                name: "NumeroParqueo",
                table: "ArriendaParqueos",
                newName: "ResidenteId");

            migrationBuilder.RenameColumn(
                name: "NombreResidente",
                table: "ArriendaApartamentos",
                newName: "Residente");

            migrationBuilder.AddColumn<int>(
                name: "ParqueoId",
                table: "ArriendaParqueos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Apartamento",
                table: "ArriendaApartamentos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 2, 11, 37, 58, 145, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.CreateIndex(
                name: "IX_ArriendaParqueos_ParqueoId",
                table: "ArriendaParqueos",
                column: "ParqueoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArriendaParqueos_ResidenteId",
                table: "ArriendaParqueos",
                column: "ResidenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArriendaParqueos_Parqueos_ParqueoId",
                table: "ArriendaParqueos",
                column: "ParqueoId",
                principalTable: "Parqueos",
                principalColumn: "ParqueoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArriendaParqueos_Residentes_ResidenteId",
                table: "ArriendaParqueos",
                column: "ResidenteId",
                principalTable: "Residentes",
                principalColumn: "ResidenteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
