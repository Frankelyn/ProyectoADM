using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominioADM.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PagoApartamentos_Apartamentos_ApartamentoId",
                table: "PagoApartamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_PagoApartamentos_Residentes_ResidenteId",
                table: "PagoApartamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_PagoParqueo_Parqueos_ParqueoId",
                table: "PagoParqueo");

            migrationBuilder.DropForeignKey(
                name: "FK_PagoParqueo_Residentes_ResidenteId",
                table: "PagoParqueo");

            migrationBuilder.DropIndex(
                name: "IX_PagoParqueo_ParqueoId",
                table: "PagoParqueo");

            migrationBuilder.DropIndex(
                name: "IX_PagoParqueo_ResidenteId",
                table: "PagoParqueo");

            migrationBuilder.DropIndex(
                name: "IX_PagoApartamentos_ApartamentoId",
                table: "PagoApartamentos");

            migrationBuilder.DropIndex(
                name: "IX_PagoApartamentos_ResidenteId",
                table: "PagoApartamentos");

            migrationBuilder.AddColumn<int>(
                name: "ArriendaParqueosId",
                table: "PagoParqueo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArriendaApartamentoId",
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

            migrationBuilder.CreateIndex(
                name: "IX_PagoParqueo_ArriendaParqueosId",
                table: "PagoParqueo",
                column: "ArriendaParqueosId");

            migrationBuilder.CreateIndex(
                name: "IX_PagoApartamentos_ArriendaApartamentoId",
                table: "PagoApartamentos",
                column: "ArriendaApartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PagoApartamentos_ArriendaApartamentos_ArriendaApartamentoId",
                table: "PagoApartamentos",
                column: "ArriendaApartamentoId",
                principalTable: "ArriendaApartamentos",
                principalColumn: "ArriendaApartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PagoParqueo_ArriendaParqueos_ArriendaParqueosId",
                table: "PagoParqueo",
                column: "ArriendaParqueosId",
                principalTable: "ArriendaParqueos",
                principalColumn: "ArriendaParqueosId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PagoApartamentos_ArriendaApartamentos_ArriendaApartamentoId",
                table: "PagoApartamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_PagoParqueo_ArriendaParqueos_ArriendaParqueosId",
                table: "PagoParqueo");

            migrationBuilder.DropIndex(
                name: "IX_PagoParqueo_ArriendaParqueosId",
                table: "PagoParqueo");

            migrationBuilder.DropIndex(
                name: "IX_PagoApartamentos_ArriendaApartamentoId",
                table: "PagoApartamentos");

            migrationBuilder.DropColumn(
                name: "ArriendaParqueosId",
                table: "PagoParqueo");

            migrationBuilder.DropColumn(
                name: "ArriendaApartamentoId",
                table: "PagoApartamentos");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 11, 27, 15, 23, 24, 170, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.CreateIndex(
                name: "IX_PagoParqueo_ParqueoId",
                table: "PagoParqueo",
                column: "ParqueoId");

            migrationBuilder.CreateIndex(
                name: "IX_PagoParqueo_ResidenteId",
                table: "PagoParqueo",
                column: "ResidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_PagoApartamentos_ApartamentoId",
                table: "PagoApartamentos",
                column: "ApartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PagoApartamentos_ResidenteId",
                table: "PagoApartamentos",
                column: "ResidenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_PagoApartamentos_Apartamentos_ApartamentoId",
                table: "PagoApartamentos",
                column: "ApartamentoId",
                principalTable: "Apartamentos",
                principalColumn: "ApartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PagoApartamentos_Residentes_ResidenteId",
                table: "PagoApartamentos",
                column: "ResidenteId",
                principalTable: "Residentes",
                principalColumn: "ResidenteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PagoParqueo_Parqueos_ParqueoId",
                table: "PagoParqueo",
                column: "ParqueoId",
                principalTable: "Parqueos",
                principalColumn: "ParqueoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PagoParqueo_Residentes_ResidenteId",
                table: "PagoParqueo",
                column: "ResidenteId",
                principalTable: "Residentes",
                principalColumn: "ResidenteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
