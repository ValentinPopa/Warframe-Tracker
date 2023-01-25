using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddSecondaryWeaponSeedDataToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SecondaryWeapon",
                columns: table => new
                {
                    idsecondaryWeapon = table.Column<int>(name: "id_secondaryWeapon", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    secondaryWeaponname = table.Column<string>(name: "secondaryWeapon_name", type: "nvarchar(max)", nullable: false),
                    crafted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondaryWeapon", x => x.idsecondaryWeapon);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SecondaryWeapon");
        }
    }
}
