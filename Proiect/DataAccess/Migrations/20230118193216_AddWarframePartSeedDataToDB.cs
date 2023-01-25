using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddWarframePartSeedDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WarframePart",
                columns: table => new
                {
                    idwarframePart = table.Column<int>(name: "id_warframePart", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    warframename = table.Column<string>(name: "warframe_name", type: "nvarchar(max)", nullable: false),
                    warframeblueprintowned = table.Column<bool>(name: "warframe_blueprint_owned", type: "bit", nullable: false),
                    warframechassisowned = table.Column<bool>(name: "warframe_chassis_owned", type: "bit", nullable: false),
                    warframeneuropticsowned = table.Column<bool>(name: "warframe_neuroptics_owned", type: "bit", nullable: false),
                    warframesystemowned = table.Column<bool>(name: "warframe_system_owned", type: "bit", nullable: false),
                    warframeblueprintcrafted = table.Column<bool>(name: "warframe_blueprint_crafted", type: "bit", nullable: false),
                    warframechassiscrafted = table.Column<bool>(name: "warframe_chassis_crafted", type: "bit", nullable: false),
                    warframeneuropticscrafted = table.Column<bool>(name: "warframe_neuroptics_crafted", type: "bit", nullable: false),
                    warframesystemcrafted = table.Column<bool>(name: "warframe_system_crafted", type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarframePart", x => x.idwarframePart);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WarframePart");
        }
    }
}
