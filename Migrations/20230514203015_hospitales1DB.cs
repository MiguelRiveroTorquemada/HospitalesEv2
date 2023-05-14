using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hospitales.Migrations
{
    public partial class hospitales1DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nombreEspecialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rotativa = table.Column<bool>(type: "bit", nullable: false),
                    inicioEspecialidad = table.Column<DateTime>(type: "datetime2", nullable: false),
                    salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    afiliados = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alta_baja = table.Column<bool>(type: "bit", nullable: false),
                    fecha_ingreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    peso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Trabajadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    baja = table.Column<bool>(type: "bit", nullable: false),
                    inicioTrabajo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajadores", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Trabajadores");
        }
    }
}
