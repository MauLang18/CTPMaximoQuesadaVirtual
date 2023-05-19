using Microsoft.EntityFrameworkCore.Migrations;

namespace PaginaCole.Migrations
{
    public partial class db_cole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HorariosSe",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Seccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorariosSe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DId = table.Column<int>(type: "int", nullable: true),
                    SId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Horarios_HorariosDi_DId",
                        column: x => x.DId,
                        principalTable: "HorariosDi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Horarios_HorariosSe_SId",
                        column: x => x.SId,
                        principalTable: "HorariosSe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_DId",
                table: "Horarios",
                column: "DId");

            migrationBuilder.CreateIndex(
                name: "IX_Horarios_SId",
                table: "Horarios",
                column: "SId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "HorariosSe");
        }
    }
}
