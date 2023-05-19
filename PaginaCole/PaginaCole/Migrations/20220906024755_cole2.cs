using Microsoft.EntityFrameworkCore.Migrations;

namespace PaginaCole.Migrations
{
    public partial class cole2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "HorariosSe");

            migrationBuilder.AddColumn<int>(
                name: "IDD",
                table: "HorariosDi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDS",
                table: "HorariosDi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagenS",
                table: "HorariosDi",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Seccion",
                table: "HorariosDi",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDD",
                table: "HorariosDi");

            migrationBuilder.DropColumn(
                name: "IDS",
                table: "HorariosDi");

            migrationBuilder.DropColumn(
                name: "ImagenS",
                table: "HorariosDi");

            migrationBuilder.DropColumn(
                name: "Seccion",
                table: "HorariosDi");

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
    }
}
