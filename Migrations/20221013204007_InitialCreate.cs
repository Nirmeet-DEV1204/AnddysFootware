using Microsoft.EntityFrameworkCore.Migrations;

namespace AnddysFootware.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AndysFootware",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyName = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    modelName = table.Column<string>(nullable: true),
                    color = table.Column<string>(nullable: true),
                    size = table.Column<int>(nullable: false),
                    rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AndysFootware", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AndysFootware");
        }
    }
}
