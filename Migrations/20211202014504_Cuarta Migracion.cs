using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominioADM.Migrations
{
    public partial class CuartaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Clave", "Fecha" },
                values: new object[] { "03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4", new DateTime(2021, 12, 1, 21, 45, 0, 467, DateTimeKind.Local).AddTicks(6049) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Clave", "Fecha" },
                values: new object[] { "1234", new DateTime(2021, 12, 1, 17, 9, 35, 123, DateTimeKind.Local).AddTicks(8553) });
        }
    }
}
