using Microsoft.EntityFrameworkCore.Migrations;

namespace AkijFood.Migrations
{
    public partial class AkijFood1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblColdDrink",
                columns: table => new
                {
                    intColdDrinksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strColdDrinksName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numQuantity = table.Column<float>(type: "real", nullable: false),
                    numUnitPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblColdDrink", x => x.intColdDrinksId);
                });

            migrationBuilder.InsertData(
                table: "tblColdDrink",
                columns: new[] { "intColdDrinksId", "numQuantity", "numUnitPrice", "strColdDrinksName" },
                values: new object[] { 1, 450f, 20f, "Clemon" });

            migrationBuilder.InsertData(
                table: "tblColdDrink",
                columns: new[] { "intColdDrinksId", "numQuantity", "numUnitPrice", "strColdDrinksName" },
                values: new object[] { 2, 500f, 25f, "Frutika" });

            migrationBuilder.InsertData(
                table: "tblColdDrink",
                columns: new[] { "intColdDrinksId", "numQuantity", "numUnitPrice", "strColdDrinksName" },
                values: new object[] { 3, 600f, 30f, "Speed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblColdDrink");
        }
    }
}
