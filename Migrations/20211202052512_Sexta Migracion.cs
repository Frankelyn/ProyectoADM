using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominioADM.Migrations
{
    public partial class SextaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepositoApartamento_Apartamentos_ApartamentoId",
                table: "DepositoApartamento");

            migrationBuilder.DropForeignKey(
                name: "FK_DepositoApartamento_Residentes_ResidenteId",
                table: "DepositoApartamento");

            migrationBuilder.DropForeignKey(
                name: "FK_DepositoParqueo_Parqueos_ParqueoId",
                table: "DepositoParqueo");

            migrationBuilder.DropForeignKey(
                name: "FK_DepositoParqueo_Residentes_ResidenteId",
                table: "DepositoParqueo");

            migrationBuilder.DropIndex(
                name: "IX_DepositoParqueo_ParqueoId",
                table: "DepositoParqueo");

            migrationBuilder.DropIndex(
                name: "IX_DepositoApartamento_ApartamentoId",
                table: "DepositoApartamento");

            migrationBuilder.DropColumn(
                name: "ParqueoId",
                table: "DepositoParqueo");

            migrationBuilder.DropColumn(
                name: "ApartamentoId",
                table: "DepositoApartamento");

            migrationBuilder.RenameColumn(
                name: "ResidenteId",
                table: "DepositoParqueo",
                newName: "ArriendaParqueosId");

            migrationBuilder.RenameIndex(
                name: "IX_DepositoParqueo_ResidenteId",
                table: "DepositoParqueo",
                newName: "IX_DepositoParqueo_ArriendaParqueosId");

            migrationBuilder.RenameColumn(
                name: "ResidenteId",
                table: "DepositoApartamento",
                newName: "ArriendaApartamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_DepositoApartamento_ResidenteId",
                table: "DepositoApartamento",
                newName: "IX_DepositoApartamento_ArriendaApartamentoId");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 2, 1, 25, 10, 777, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.AddForeignKey(
                name: "FK_DepositoApartamento_ArriendaApartamentos_ArriendaApartamentoId",
                table: "DepositoApartamento",
                column: "ArriendaApartamentoId",
                principalTable: "ArriendaApartamentos",
                principalColumn: "ArriendaApartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepositoParqueo_ArriendaParqueos_ArriendaParqueosId",
                table: "DepositoParqueo",
                column: "ArriendaParqueosId",
                principalTable: "ArriendaParqueos",
                principalColumn: "ArriendaParqueosId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepositoApartamento_ArriendaApartamentos_ArriendaApartamentoId",
                table: "DepositoApartamento");

            migrationBuilder.DropForeignKey(
                name: "FK_DepositoParqueo_ArriendaParqueos_ArriendaParqueosId",
                table: "DepositoParqueo");

            migrationBuilder.RenameColumn(
                name: "ArriendaParqueosId",
                table: "DepositoParqueo",
                newName: "ResidenteId");

            migrationBuilder.RenameIndex(
                name: "IX_DepositoParqueo_ArriendaParqueosId",
                table: "DepositoParqueo",
                newName: "IX_DepositoParqueo_ResidenteId");

            migrationBuilder.RenameColumn(
                name: "ArriendaApartamentoId",
                table: "DepositoApartamento",
                newName: "ResidenteId");

            migrationBuilder.RenameIndex(
                name: "IX_DepositoApartamento_ArriendaApartamentoId",
                table: "DepositoApartamento",
                newName: "IX_DepositoApartamento_ResidenteId");

            migrationBuilder.AddColumn<int>(
                name: "ParqueoId",
                table: "DepositoParqueo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApartamentoId",
                table: "DepositoApartamento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 1, 21, 50, 47, 968, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.CreateIndex(
                name: "IX_DepositoParqueo_ParqueoId",
                table: "DepositoParqueo",
                column: "ParqueoId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositoApartamento_ApartamentoId",
                table: "DepositoApartamento",
                column: "ApartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepositoApartamento_Apartamentos_ApartamentoId",
                table: "DepositoApartamento",
                column: "ApartamentoId",
                principalTable: "Apartamentos",
                principalColumn: "ApartamentoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepositoApartamento_Residentes_ResidenteId",
                table: "DepositoApartamento",
                column: "ResidenteId",
                principalTable: "Residentes",
                principalColumn: "ResidenteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepositoParqueo_Parqueos_ParqueoId",
                table: "DepositoParqueo",
                column: "ParqueoId",
                principalTable: "Parqueos",
                principalColumn: "ParqueoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepositoParqueo_Residentes_ResidenteId",
                table: "DepositoParqueo",
                column: "ResidenteId",
                principalTable: "Residentes",
                principalColumn: "ResidenteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
