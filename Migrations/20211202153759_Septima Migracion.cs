using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominioADM.Migrations
{
    public partial class SeptimaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArriendaApartamentos_Apartamentos_ApartamentoId",
                table: "ArriendaApartamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_ArriendaApartamentos_Residentes_ResidenteId",
                table: "ArriendaApartamentos");

            migrationBuilder.DropIndex(
                name: "IX_ArriendaApartamentos_ApartamentoId",
                table: "ArriendaApartamentos");

            migrationBuilder.DropIndex(
                name: "IX_ArriendaApartamentos_ResidenteId",
                table: "ArriendaApartamentos");

            migrationBuilder.DropColumn(
                name: "ApartamentoId",
                table: "ArriendaApartamentos");

            migrationBuilder.DropColumn(
                name: "ResidenteId",
                table: "ArriendaApartamentos");

            migrationBuilder.AddColumn<string>(
                name: "Apartamento",
                table: "ArriendaApartamentos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Residente",
                table: "ArriendaApartamentos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 2, 11, 37, 58, 145, DateTimeKind.Local).AddTicks(6855));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apartamento",
                table: "ArriendaApartamentos");

            migrationBuilder.DropColumn(
                name: "Residente",
                table: "ArriendaApartamentos");

            migrationBuilder.AddColumn<int>(
                name: "ApartamentoId",
                table: "ArriendaApartamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResidenteId",
                table: "ArriendaApartamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 2, 1, 25, 10, 777, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.CreateIndex(
                name: "IX_ArriendaApartamentos_ApartamentoId",
                table: "ArriendaApartamentos",
                column: "ApartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArriendaApartamentos_ResidenteId",
                table: "ArriendaApartamentos",
                column: "ResidenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArriendaApartamentos_Apartamentos_ApartamentoId",
                table: "ArriendaApartamentos",
                column: "ApartamentoId",
                principalTable: "Apartamentos",
                principalColumn: "ApartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArriendaApartamentos_Residentes_ResidenteId",
                table: "ArriendaApartamentos",
                column: "ResidenteId",
                principalTable: "Residentes",
                principalColumn: "ResidenteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
