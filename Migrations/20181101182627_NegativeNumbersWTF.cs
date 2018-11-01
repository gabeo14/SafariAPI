using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SafariAPI.Migrations
{
    public partial class NegativeNumbersWTF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeenAnimals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Species = table.Column<string>(nullable: true),
                    CountOfTimesSeen = table.Column<int>(nullable: false),
                    LocationOfLastSeen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeenAnimals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SeenAnimals",
                columns: new[] { "Id", "CountOfTimesSeen", "LocationOfLastSeen", "Species" },
                values: new object[,]
                {
                    { -1, 3, "Umbrella Acacias", "Springbok" },
                    { -2, 5, "Watering Hole", "Spotted Hyena" },
                    { -3, 6, "Rock Outcrop", "Meerkat" },
                    { -4, 1, "Termite Mound", "Aardvark" },
                    { -5, 3, "Watering Hole", "Wildebeest" },
                    { -6, 2, "Rock Outcrop", "African Rock Python" },
                    { -7, 4, "Umbrella Acacias", "Grant's Gazelle" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeenAnimals");
        }
    }
}
