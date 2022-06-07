using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportStats.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zenit",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Stadium = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Head_Coach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Home_Win = table.Column<int>(type: "int", nullable: false),
                    Guest_Win = table.Column<int>(type: "int", nullable: false),
                    Home_Goals = table.Column<int>(type: "int", nullable: false),
                    Guest_Goals = table.Column<int>(type: "int", nullable: false),
                    YellowRoughPlay = table.Column<int>(type: "int", nullable: false),
                    YellowUnsportsmanlikeBehavior = table.Column<int>(type: "int", nullable: false),
                    YellowDisruptionOfTheAttack = table.Column<int>(type: "int", nullable: false),
                    Yellow_Other = table.Column<int>(type: "int", nullable: false),
                    Yellow_Cards = table.Column<int>(type: "int", nullable: false),
                    Red_Cards = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zenit", x => x.Title);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zenit");
        }
    }
}
