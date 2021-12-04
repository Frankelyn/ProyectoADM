using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominioADM.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apartamentos",
                columns: table => new
                {
                    ApartamentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Numero = table.Column<int>(type: "INTEGER", nullable: false),
                    Habitaciones = table.Column<int>(type: "INTEGER", nullable: false),
                    Disponible = table.Column<bool>(type: "INTEGER", nullable: false),
                    PrecioRenta = table.Column<float>(type: "REAL", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartamentos", x => x.ApartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "EstadosCiviles",
                columns: table => new
                {
                    EstadoCivilId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosCiviles", x => x.EstadoCivilId);
                });

            migrationBuilder.CreateTable(
                name: "Parqueos",
                columns: table => new
                {
                    ParqueoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Numero = table.Column<int>(type: "INTEGER", nullable: false),
                    PrecioRenta = table.Column<float>(type: "REAL", nullable: false),
                    Disponible = table.Column<bool>(type: "INTEGER", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parqueos", x => x.ParqueoId);
                });

            migrationBuilder.CreateTable(
                name: "Sexos",
                columns: table => new
                {
                    SexoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexos", x => x.SexoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Clave = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Residentes",
                columns: table => new
                {
                    ResidenteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    SexoId = table.Column<int>(type: "INTEGER", nullable: false),
                    EstadoCivilId = table.Column<int>(type: "INTEGER", nullable: false),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residentes", x => x.ResidenteId);
                    table.ForeignKey(
                        name: "FK_Residentes_EstadosCiviles_EstadoCivilId",
                        column: x => x.EstadoCivilId,
                        principalTable: "EstadosCiviles",
                        principalColumn: "EstadoCivilId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Residentes_Sexos_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexos",
                        principalColumn: "SexoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArriendaApartamentos",
                columns: table => new
                {
                    ArriendaApartamentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ResidenteId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApartamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArriendaApartamentos", x => x.ArriendaApartamentoId);
                    table.ForeignKey(
                        name: "FK_ArriendaApartamentos_Apartamentos_ApartamentoId",
                        column: x => x.ApartamentoId,
                        principalTable: "Apartamentos",
                        principalColumn: "ApartamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArriendaApartamentos_Residentes_ResidenteId",
                        column: x => x.ResidenteId,
                        principalTable: "Residentes",
                        principalColumn: "ResidenteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArriendaParqueos",
                columns: table => new
                {
                    ArriendaParqueosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ResidenteId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParqueoId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArriendaParqueos", x => x.ArriendaParqueosId);
                    table.ForeignKey(
                        name: "FK_ArriendaParqueos_Parqueos_ParqueoId",
                        column: x => x.ParqueoId,
                        principalTable: "Parqueos",
                        principalColumn: "ParqueoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArriendaParqueos_Residentes_ResidenteId",
                        column: x => x.ResidenteId,
                        principalTable: "Residentes",
                        principalColumn: "ResidenteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepositoApartamento",
                columns: table => new
                {
                    DepositoApartamentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ResidenteId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApartamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Monto = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositoApartamento", x => x.DepositoApartamentoId);
                    table.ForeignKey(
                        name: "FK_DepositoApartamento_Apartamentos_ApartamentoId",
                        column: x => x.ApartamentoId,
                        principalTable: "Apartamentos",
                        principalColumn: "ApartamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepositoApartamento_Residentes_ResidenteId",
                        column: x => x.ResidenteId,
                        principalTable: "Residentes",
                        principalColumn: "ResidenteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepositoParqueo",
                columns: table => new
                {
                    DepositoParqueoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ResidenteId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParqueoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Monto = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositoParqueo", x => x.DepositoParqueoId);
                    table.ForeignKey(
                        name: "FK_DepositoParqueo_Parqueos_ParqueoId",
                        column: x => x.ParqueoId,
                        principalTable: "Parqueos",
                        principalColumn: "ParqueoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepositoParqueo_Residentes_ResidenteId",
                        column: x => x.ResidenteId,
                        principalTable: "Residentes",
                        principalColumn: "ResidenteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deudas",
                columns: table => new
                {
                    DeudaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Monto = table.Column<float>(type: "REAL", nullable: false),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false),
                    ResidenteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deudas", x => x.DeudaId);
                    table.ForeignKey(
                        name: "FK_Deudas_Residentes_ResidenteId",
                        column: x => x.ResidenteId,
                        principalTable: "Residentes",
                        principalColumn: "ResidenteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagoApartamentos",
                columns: table => new
                {
                    PagoApartamentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ResidenteId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApartamentoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MontoPago = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagoApartamentos", x => x.PagoApartamentoId);
                    table.ForeignKey(
                        name: "FK_PagoApartamentos_Apartamentos_ApartamentoId",
                        column: x => x.ApartamentoId,
                        principalTable: "Apartamentos",
                        principalColumn: "ApartamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PagoApartamentos_Residentes_ResidenteId",
                        column: x => x.ResidenteId,
                        principalTable: "Residentes",
                        principalColumn: "ResidenteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagoParqueo",
                columns: table => new
                {
                    PagoParqueoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ResidenteId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParqueoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MontoPago = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagoParqueo", x => x.PagoParqueoId);
                    table.ForeignKey(
                        name: "FK_PagoParqueo_Parqueos_ParqueoId",
                        column: x => x.ParqueoId,
                        principalTable: "Parqueos",
                        principalColumn: "ParqueoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PagoParqueo_Residentes_ResidenteId",
                        column: x => x.ResidenteId,
                        principalTable: "Residentes",
                        principalColumn: "ResidenteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EstadosCiviles",
                columns: new[] { "EstadoCivilId", "Descripcion" },
                values: new object[] { 1, "Casado/a" });

            migrationBuilder.InsertData(
                table: "EstadosCiviles",
                columns: new[] { "EstadoCivilId", "Descripcion" },
                values: new object[] { 2, "Soltero/a" });

            migrationBuilder.InsertData(
                table: "Sexos",
                columns: new[] { "SexoId", "Descripcion" },
                values: new object[] { 1, "Masculino" });

            migrationBuilder.InsertData(
                table: "Sexos",
                columns: new[] { "SexoId", "Descripcion" },
                values: new object[] { 2, "Femenino" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Clave", "Email", "Fecha", "Nombres" },
                values: new object[] { 1, "1234", "fulano@gmail.com", new DateTime(2021, 11, 27, 15, 23, 24, 170, DateTimeKind.Local).AddTicks(3009), "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_ArriendaApartamentos_ApartamentoId",
                table: "ArriendaApartamentos",
                column: "ApartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArriendaApartamentos_ResidenteId",
                table: "ArriendaApartamentos",
                column: "ResidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_ArriendaParqueos_ParqueoId",
                table: "ArriendaParqueos",
                column: "ParqueoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArriendaParqueos_ResidenteId",
                table: "ArriendaParqueos",
                column: "ResidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositoApartamento_ApartamentoId",
                table: "DepositoApartamento",
                column: "ApartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositoApartamento_ResidenteId",
                table: "DepositoApartamento",
                column: "ResidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositoParqueo_ParqueoId",
                table: "DepositoParqueo",
                column: "ParqueoId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositoParqueo_ResidenteId",
                table: "DepositoParqueo",
                column: "ResidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Deudas_ResidenteId",
                table: "Deudas",
                column: "ResidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_PagoApartamentos_ApartamentoId",
                table: "PagoApartamentos",
                column: "ApartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PagoApartamentos_ResidenteId",
                table: "PagoApartamentos",
                column: "ResidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_PagoParqueo_ParqueoId",
                table: "PagoParqueo",
                column: "ParqueoId");

            migrationBuilder.CreateIndex(
                name: "IX_PagoParqueo_ResidenteId",
                table: "PagoParqueo",
                column: "ResidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Residentes_EstadoCivilId",
                table: "Residentes",
                column: "EstadoCivilId");

            migrationBuilder.CreateIndex(
                name: "IX_Residentes_SexoId",
                table: "Residentes",
                column: "SexoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArriendaApartamentos");

            migrationBuilder.DropTable(
                name: "ArriendaParqueos");

            migrationBuilder.DropTable(
                name: "DepositoApartamento");

            migrationBuilder.DropTable(
                name: "DepositoParqueo");

            migrationBuilder.DropTable(
                name: "Deudas");

            migrationBuilder.DropTable(
                name: "PagoApartamentos");

            migrationBuilder.DropTable(
                name: "PagoParqueo");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Apartamentos");

            migrationBuilder.DropTable(
                name: "Parqueos");

            migrationBuilder.DropTable(
                name: "Residentes");

            migrationBuilder.DropTable(
                name: "EstadosCiviles");

            migrationBuilder.DropTable(
                name: "Sexos");
        }
    }
}
