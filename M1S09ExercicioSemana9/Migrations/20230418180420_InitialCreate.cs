using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace M1S09ExercicioSemana9.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Semana",
                columns: table => new
                {
                    Código = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Conteúdo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Aplicado = table.Column<bool>(name: "Aplicado?", type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semana", x => x.Código);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Semana");
        }
    }
}
