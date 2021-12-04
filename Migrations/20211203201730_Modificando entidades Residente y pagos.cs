using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominioADM.Migrations
{
    public partial class ModificandoentidadesResidenteypagos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepositoApartamento_ArriendaApartamentos_ArriendaApartamentoId",
                table: "DepositoApartamento");

            migrationBuilder.DropForeignKey(
                name: "FK_DepositoParqueo_ArriendaParqueos_ArriendaParqueosId",
                table: "DepositoParqueo");

            migrationBuilder.DropForeignKey(
                name: "FK_PagoApartamentos_ArriendaApartamentos_ArriendaApartamentoId",
                table: "PagoApartamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_PagoParqueo_ArriendaParqueos_ArriendaParqueosId",
                table: "PagoParqueo");

            migrationBuilder.DropIndex(
                name: "IX_DepositoParqueo_ArriendaParqueosId",
                table: "DepositoParqueo");

            migrationBuilder.DropIndex(
                name: "IX_DepositoApartamento_ArriendaApartamentoId",
                table: "DepositoApartamento");

            migrationBuilder.RenameColumn(
                name: "ArriendaParqueosId",
                table: "DepositoParqueo",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "ArriendaApartamentoId",
                table: "DepositoApartamento",
                newName: "UsuarioId");

            migrationBuilder.AddColumn<float>(
                name: "BalancePendiente",
                table: "Residentes",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<int>(
                name: "ArriendaParqueosId",
                table: "PagoParqueo",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "PagoParqueo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ArriendaApartamentoId",
                table: "PagoApartamentos",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "PagoApartamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NombreResidente",
                table: "DepositoParqueo",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroParqueo",
                table: "DepositoParqueo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NombreResidente",
                table: "DepositoApartamento",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroApartamento",
                table: "DepositoApartamento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 3, 16, 17, 28, 631, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.AddForeignKey(
                name: "FK_PagoApartamentos_ArriendaApartamentos_ArriendaApartamentoId",
                table: "PagoApartamentos",
                column: "ArriendaApartamentoId",
                principalTable: "ArriendaApartamentos",
                principalColumn: "ArriendaApartamentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PagoParqueo_ArriendaParqueos_ArriendaParqueosId",
                table: "PagoParqueo",
                column: "ArriendaParqueosId",
                principalTable: "ArriendaParqueos",
                principalColumn: "ArriendaParqueosId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PagoApartamentos_ArriendaApartamentos_ArriendaApartamentoId",
                table: "PagoApartamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_PagoParqueo_ArriendaParqueos_ArriendaParqueosId",
                table: "PagoParqueo");

            migrationBuilder.DropColumn(
                name: "BalancePendiente",
                table: "Residentes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "PagoParqueo");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "PagoApartamentos");

            migrationBuilder.DropColumn(
                name: "NombreResidente",
                table: "DepositoParqueo");

            migrationBuilder.DropColumn(
                name: "NumeroParqueo",
                table: "DepositoParqueo");

            migrationBuilder.DropColumn(
                name: "NombreResidente",
                table: "DepositoApartamento");

            migrationBuilder.DropColumn(
                name: "NumeroApartamento",
                table: "DepositoApartamento");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "DepositoParqueo",
                newName: "ArriendaParqueosId");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "DepositoApartamento",
                newName: "ArriendaApartamentoId");

            migrationBuilder.AlterColumn<int>(
                name: "ArriendaParqueosId",
                table: "PagoParqueo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArriendaApartamentoId",
                table: "PagoApartamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 3, 12, 2, 44, 453, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.CreateIndex(
                name: "IX_DepositoParqueo_ArriendaParqueosId",
                table: "DepositoParqueo",
                column: "ArriendaParqueosId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositoApartamento_ArriendaApartamentoId",
                table: "DepositoApartamento",
                column: "ArriendaApartamentoId");

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
    }
}
