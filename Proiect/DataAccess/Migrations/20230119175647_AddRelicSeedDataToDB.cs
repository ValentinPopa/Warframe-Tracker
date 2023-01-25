using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddRelicSeedDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Relic",
                columns: table => new
                {
                    idrelic = table.Column<int>(name: "id_relic", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    relicname = table.Column<string>(name: "relic_name", type: "nvarchar(max)", nullable: false),
                    common1 = table.Column<string>(name: "common_1", type: "nvarchar(max)", nullable: false),
                    common2 = table.Column<string>(name: "common_2", type: "nvarchar(max)", nullable: false),
                    common3 = table.Column<string>(name: "common_3", type: "nvarchar(max)", nullable: false),
                    uncommon1 = table.Column<string>(name: "uncommon_1", type: "nvarchar(max)", nullable: false),
                    uncommon2 = table.Column<string>(name: "uncommon_2", type: "nvarchar(max)", nullable: false),
                    rare1 = table.Column<string>(name: "rare_1", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relic", x => x.idrelic);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relic");
        }
    }
}
