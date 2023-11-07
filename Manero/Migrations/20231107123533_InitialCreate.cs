using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Manero.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    SalePrice = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "ProductName", "Rating", "SalePrice" },
                values: new object[] { 1, "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://media.discordapp.net/attachments/1161545688103006245/1171425219949371442/tactical-beard-brown.png?ex=655ca1c0&is=654a2cc0&hm=44c37be70087bceccb4e1e8b29418f640271e6e32984398ca58d349ba8aeb131&=&width=337&height=368", 399, "Skägg deluxe", 3, 300 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
