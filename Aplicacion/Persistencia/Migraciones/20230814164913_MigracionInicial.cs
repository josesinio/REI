using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplicacion.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dispositvo",
                columns: table => new
                {
                    IdDispositivo = table.Column<Guid>(type: "char(20)", maxLength: 20, nullable: false, collation: "ascii_general_ci"),
                    NumSerie = table.Column<int>(type: "int", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispositvo", x => x.IdDispositivo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Falta",
                columns: table => new
                {
                    Idfalta = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Mensaje = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDispositivo = table.Column<int>(type: "int", nullable: false),
                    DispositivoIdDispositivo = table.Column<Guid>(type: "char(20)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Falta", x => x.Idfalta);
                    table.ForeignKey(
                        name: "FK_Falta_Dispositvo_DispositivoIdDispositivo",
                        column: x => x.DispositivoIdDispositivo,
                        principalTable: "Dispositvo",
                        principalColumn: "IdDispositivo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medicion",
                columns: table => new
                {
                    IdMedicion = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Unidad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdDispositivo = table.Column<int>(type: "int", nullable: false),
                    DispositivoIdDispositivo = table.Column<Guid>(type: "char(20)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicion", x => x.IdMedicion);
                    table.ForeignKey(
                        name: "FK_Medicion_Dispositvo_DispositivoIdDispositivo",
                        column: x => x.DispositivoIdDispositivo,
                        principalTable: "Dispositvo",
                        principalColumn: "IdDispositivo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Notificacion",
                columns: table => new
                {
                    IdNotificacion = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Mensaje = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdDispositivo = table.Column<int>(type: "int", nullable: false),
                    DispositivoIdDispositivo = table.Column<Guid>(type: "char(20)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacion", x => x.IdNotificacion);
                    table.ForeignKey(
                        name: "FK_Notificacion_Dispositvo_DispositivoIdDispositivo",
                        column: x => x.DispositivoIdDispositivo,
                        principalTable: "Dispositvo",
                        principalColumn: "IdDispositivo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Falta_DispositivoIdDispositivo",
                table: "Falta",
                column: "DispositivoIdDispositivo");

            migrationBuilder.CreateIndex(
                name: "IX_Medicion_DispositivoIdDispositivo",
                table: "Medicion",
                column: "DispositivoIdDispositivo");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacion_DispositivoIdDispositivo",
                table: "Notificacion",
                column: "DispositivoIdDispositivo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Falta");

            migrationBuilder.DropTable(
                name: "Medicion");

            migrationBuilder.DropTable(
                name: "Notificacion");

            migrationBuilder.DropTable(
                name: "Dispositvo");
        }
    }
}
