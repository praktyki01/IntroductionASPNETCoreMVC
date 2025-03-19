using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroductionASPNETCoreMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Samochod",
                columns: table => new
                {
                    SamochodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kolor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PojSilnika = table.Column<float>(type: "real", nullable: false),
                    RokProdukcji = table.Column<int>(type: "int", nullable: false),
                    Przebieg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samochod", x => x.SamochodId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Samochod");
        }
    }
}
