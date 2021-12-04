using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominioADM.Migrations
{
    public partial class QuintaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Clave", "Fecha" },
                values: new object[] { "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", new DateTime(2021, 12, 1, 21, 50, 47, 968, DateTimeKind.Local).AddTicks(9122) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Clave", "Fecha" },
                values: new object[] { "03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4", new DateTime(2021, 12, 1, 21, 45, 0, 467, DateTimeKind.Local).AddTicks(6049) });
        }
    }
}
