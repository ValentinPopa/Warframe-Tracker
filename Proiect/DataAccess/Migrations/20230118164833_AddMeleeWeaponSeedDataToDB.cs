using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddMeleeWeaponSeedDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeleeWeapon",
                columns: table => new
                {
                    idmeleeWeapon = table.Column<int>(name: "id_meleeWeapon", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    meleeWeaponname = table.Column<string>(name: "meleeWeapon_name", type: "nvarchar(max)", nullable: false),
                    crafted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeleeWeapon", x => x.idmeleeWeapon);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeleeWeapon");
        }
    }
}
