using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddWarframeToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Warframe",
                columns: table => new
                {
                    idwarframe = table.Column<int>(name: "id_warframe", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    warframename = table.Column<string>(name: "warframe_name", type: "nvarchar(max)", nullable: false),
                    crafted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warframe", x => x.idwarframe);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warframe");
        }
    }
}
