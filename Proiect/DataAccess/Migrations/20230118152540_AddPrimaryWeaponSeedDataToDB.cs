using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddPrimaryWeaponSeedDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "PrimaryWeapon",
                columns: table => new
                {
                    idprimaryWeapon = table.Column<int>(name: "id_primaryWeapon", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    primaryWeaponname = table.Column<string>(name: "primaryWeapon_name", type: "nvarchar(max)", nullable: false),
                    crafted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryWeapon", x => x.idprimaryWeapon);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrimaryWeapon");

            migrationBuilder.CreateTable(
                name: "PrimaryWeapons",
                columns: table => new
                {
                    idprimaryWeapon = table.Column<int>(name: "id_primaryWeapon", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    crafted = table.Column<bool>(type: "bit", nullable: false),
                    primaryWeaponname = table.Column<string>(name: "primaryWeapon_name", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryWeapons", x => x.idprimaryWeapon);
                });
        }
    }
}
