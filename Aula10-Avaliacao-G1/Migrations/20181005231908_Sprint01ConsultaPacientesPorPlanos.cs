using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Aula10AvaliacaoG1.Migrations
{
    public partial class Sprint01ConsultaPacientesPorPlanos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "planos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    email = table.Column<string>(type: "longtext", nullable: true),
                    endereco = table.Column<string>(type: "longtext", nullable: true),
                    fone = table.Column<string>(type: "longtext", nullable: true),
                    nome = table.Column<string>(type: "longtext", nullable: true),
                    planoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_pacientes_planos_planoid",
                        column: x => x.planoid,
                        principalTable: "planos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "consultas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dataHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dataRevisao = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    oQueFoiFeito = table.Column<string>(type: "longtext", nullable: true),
                    oQueFoiFeitoRevisao = table.Column<string>(type: "longtext", nullable: true),
                    pacienteid = table.Column<int>(type: "int", nullable: true),
                    valorConsulta = table.Column<decimal>(type: "decimal(65, 30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consultas", x => x.id);
                    table.ForeignKey(
                        name: "FK_consultas_pacientes_pacienteid",
                        column: x => x.pacienteid,
                        principalTable: "pacientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_consultas_pacienteid",
                table: "consultas",
                column: "pacienteid");

            migrationBuilder.CreateIndex(
                name: "IX_pacientes_planoid",
                table: "pacientes",
                column: "planoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "consultas");

            migrationBuilder.DropTable(
                name: "pacientes");

            migrationBuilder.DropTable(
                name: "planos");
        }
    }
}
