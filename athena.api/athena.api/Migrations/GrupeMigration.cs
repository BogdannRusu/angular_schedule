using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace athena.api.Migrations
{
    /// <inheritdoc />
    public partial class GrupeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cabinete",
                columns: table => new
                {
                    id_cabinet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nr_cabinet = table.Column<int>(type: "int", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabinete", x => x.id_cabinet);
                });

            migrationBuilder.CreateTable(
                name: "Grupe",
                columns: table => new
                {
                    id_grupa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume_grupa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    anul = table.Column<int>(type: "int", nullable: false),
                    id_link = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupe", x => x.id_grupa);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cabinete");

            migrationBuilder.DropTable(
                name: "Grupe");
        }
    }
}
