using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportStats.Migrations
{
    public partial class Migratia2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Akhmat",
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
                    table.PrimaryKey("PK_Akhmat", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Arsenal",
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
                    table.PrimaryKey("PK_Arsenal", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "CSKA",
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
                    table.PrimaryKey("PK_CSKA", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Dynamo",
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
                    table.PrimaryKey("PK_Dynamo", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Khimki",
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
                    table.PrimaryKey("PK_Khimki", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Krasnodar",
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
                    table.PrimaryKey("PK_Krasnodar", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "KrylyaSovetov",
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
                    table.PrimaryKey("PK_KrylyaSovetov", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Lokomotiv",
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
                    table.PrimaryKey("PK_Lokomotiv", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "NizhniyNovgorod",
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
                    table.PrimaryKey("PK_NizhniyNovgorod", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Rostov",
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
                    table.PrimaryKey("PK_Rostov", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Rubin",
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
                    table.PrimaryKey("PK_Rubin", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Sochi",
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
                    table.PrimaryKey("PK_Sochi", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Spartak",
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
                    table.PrimaryKey("PK_Spartak", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Ufa",
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
                    table.PrimaryKey("PK_Ufa", x => x.Title);
                });

            migrationBuilder.CreateTable(
                name: "Ural",
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
                    table.PrimaryKey("PK_Ural", x => x.Title);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Akhmat");

            migrationBuilder.DropTable(
                name: "Arsenal");

            migrationBuilder.DropTable(
                name: "CSKA");

            migrationBuilder.DropTable(
                name: "Dynamo");

            migrationBuilder.DropTable(
                name: "Khimki");

            migrationBuilder.DropTable(
                name: "Krasnodar");

            migrationBuilder.DropTable(
                name: "KrylyaSovetov");

            migrationBuilder.DropTable(
                name: "Lokomotiv");

            migrationBuilder.DropTable(
                name: "NizhniyNovgorod");

            migrationBuilder.DropTable(
                name: "Rostov");

            migrationBuilder.DropTable(
                name: "Rubin");

            migrationBuilder.DropTable(
                name: "Sochi");

            migrationBuilder.DropTable(
                name: "Spartak");

            migrationBuilder.DropTable(
                name: "Ufa");

            migrationBuilder.DropTable(
                name: "Ural");
        }
    }
}
