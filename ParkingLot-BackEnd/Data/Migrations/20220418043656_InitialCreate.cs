using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingLot.BackEnd.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarifa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    HoraInicialDia = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    HoraFinalDia = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    PrecioHoraFraccion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioDia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinutosTolerancia = table.Column<int>(type: "int", nullable: false),
                    HoraInicialNoche = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    HoraFinalNoche = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    MultaNoche = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentoEntidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Abreviatura = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentoEntidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubigeo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoUbigeo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    CodigoDepartamento = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    NombreDepartamento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CodigoProvincia = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    NombreProvincia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CodigoDistrito = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    NombreDistrito = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubigeo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UbigeoId = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_TipoDocumentoEntidad_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumentoEntidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_Ubigeo_UbigeoId",
                        column: x => x.UbigeoId,
                        principalTable: "Ubigeo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlacaVehicular = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    TarifaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Tarifa_TarifaId",
                        column: x => x.TarifaId,
                        principalTable: "Tarifa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroTicket = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraIngreso = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", maxLength: 6, nullable: false),
                    HoraSalida = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    TarifaId = table.Column<int>(type: "int", nullable: false),
                    PrecioHoraFraccion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioDia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalTicket = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TiempoTranscurrido = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Persona_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Tarifa_TarifaId",
                        column: x => x.TarifaId,
                        principalTable: "Tarifa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Vehiculo_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_TipoDocumentoId",
                table: "Persona",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_UbigeoId",
                table: "Persona",
                column: "UbigeoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PersonaId",
                table: "Ticket",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TarifaId",
                table: "Ticket",
                column: "TarifaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_VehiculoId",
                table: "Ticket",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_PersonaId",
                table: "Vehiculo",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_TarifaId",
                table: "Vehiculo",
                column: "TarifaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Tarifa");

            migrationBuilder.DropTable(
                name: "TipoDocumentoEntidad");

            migrationBuilder.DropTable(
                name: "Ubigeo");
        }
    }
}
