using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Api.AspNet.Migrations
{
    /// <inheritdoc />
    public partial class Enchente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaDeRisco",
                columns: table => new
                {
                    AreaDeRiscoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LocalizacaoAreaDeRisco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NivelRioAreaDeRisco = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DataUltimoRegistro = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    RioId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    PluviometroId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaDeRisco", x => x.AreaDeRiscoId);
                });

            migrationBuilder.CreateTable(
                name: "Boia",
                columns: table => new
                {
                    FerramentaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    LocalizacaoFerramenta = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    StatusRio = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AlertaRisco = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    DataUltimoRegistro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    RioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boia", x => x.FerramentaId);
                });

            migrationBuilder.CreateTable(
                name: "Pluviometro",
                columns: table => new
                {
                    PluviometroId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NivelChuva = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DescricaoPluviometro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DataUltimoRegistro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pluviometro", x => x.PluviometroId);
                });

            migrationBuilder.CreateTable(
                name: "Rio",
                columns: table => new
                {
                    RioId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeRio = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DescricaoRio = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rio", x => x.RioId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaDeRisco");

            migrationBuilder.DropTable(
                name: "Boia");

            migrationBuilder.DropTable(
                name: "Pluviometro");

            migrationBuilder.DropTable(
                name: "Rio");
        }
    }
}
