using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaTecnica.Persistencia.Migrations
{
    /// <inheritdoc />
    public partial class primeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ZonaDePotencia = table.Column<string>(type: "text", nullable: false),
                    Participante = table.Column<string>(type: "text", nullable: false),
                    SubCuentaDelParticipante = table.Column<string>(type: "text", nullable: false),
                    CapacidadDemandadaMW = table.Column<double>(type: "double precision", nullable: false),
                    RequisitoAnualDePotenciaMWAnio = table.Column<double>(type: "double precision", nullable: false),
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CapacidadDemandadaYRAPEn2024BCAv20250131",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ZonaDePotencia = table.Column<string>(type: "text", nullable: false),
                    Participante = table.Column<string>(type: "text", nullable: false),
                    SubCuentaDelParticipante = table.Column<string>(type: "text", nullable: false),
                    CapacidadDemandadaMW = table.Column<double>(type: "double precision", nullable: false),
                    RequisitoAnualDePotenciaMWAnio = table.Column<double>(type: "double precision", nullable: false),
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapacidadDemandadaYRAPEn2024BCAv20250131", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ZonaDePotencia = table.Column<string>(type: "text", nullable: false),
                    Participante = table.Column<string>(type: "text", nullable: false),
                    SubCuentaDelParticipante = table.Column<string>(type: "text", nullable: false),
                    CapacidadDemandadaMW = table.Column<double>(type: "double precision", nullable: false),
                    RequisitoAnualDePotenciaMWAnio = table.Column<double>(type: "double precision", nullable: false),
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CapacidadDemandadaYRAPEn2024BCSv20250131",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ZonaDePotencia = table.Column<string>(type: "text", nullable: false),
                    Participante = table.Column<string>(type: "text", nullable: false),
                    SubCuentaDelParticipante = table.Column<string>(type: "text", nullable: false),
                    CapacidadDemandadaMW = table.Column<double>(type: "double precision", nullable: false),
                    RequisitoAnualDePotenciaMWAnio = table.Column<double>(type: "double precision", nullable: false),
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapacidadDemandadaYRAPEn2024BCSv20250131", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CapacidadDemandadaYRAPEn2024SINPreliminarv20250127",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ZonaDePotencia = table.Column<string>(type: "text", nullable: false),
                    Participante = table.Column<string>(type: "text", nullable: false),
                    SubCuentaDelParticipante = table.Column<string>(type: "text", nullable: false),
                    CapacidadDemandadaMW = table.Column<double>(type: "double precision", nullable: false),
                    RequisitoAnualDePotenciaMWAnio = table.Column<double>(type: "double precision", nullable: false),
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapacidadDemandadaYRAPEn2024SINPreliminarv20250127", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CapacidadDemandadaYRAPEn2024SINv20250131",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ZonaDePotencia = table.Column<string>(type: "text", nullable: false),
                    Participante = table.Column<string>(type: "text", nullable: false),
                    SubCuentaDelParticipante = table.Column<string>(type: "text", nullable: false),
                    CapacidadDemandadaMW = table.Column<double>(type: "double precision", nullable: false),
                    RequisitoAnualDePotenciaMWAnio = table.Column<double>(type: "double precision", nullable: false),
                    ValorDelRequisitoAnualDePotenciaEficienteMWAnio = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapacidadDemandadaYRAPEn2024SINv20250131", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CapacidadDemandadaYRAPEn2024BCAPreliminarv20250127");

            migrationBuilder.DropTable(
                name: "CapacidadDemandadaYRAPEn2024BCAv20250131");

            migrationBuilder.DropTable(
                name: "CapacidadDemandadaYRAPEn2024BCSPreliminarv20250127");

            migrationBuilder.DropTable(
                name: "CapacidadDemandadaYRAPEn2024BCSv20250131");

            migrationBuilder.DropTable(
                name: "CapacidadDemandadaYRAPEn2024SINPreliminarv20250127");

            migrationBuilder.DropTable(
                name: "CapacidadDemandadaYRAPEn2024SINv20250131");
        }
    }
}
