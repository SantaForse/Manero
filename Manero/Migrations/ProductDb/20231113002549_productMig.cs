using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Manero.Migrations.ProductDb
{
    /// <inheritdoc />
    public partial class productMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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
                    SalePrice = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductReviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReviews", x => new { x.ProductId, x.ReviewId });
                    table.ForeignKey(
                        name: "FK_ProductReviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductReviews_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Pants" },
                    { 2, "Accessories" },
                    { 3, "Shoes" },
                    { 4, "T-shirts" },
                    { 5, "Dresses" },
                    { 6, "Hoodie" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "ProductName", "Rating", "SalePrice" },
                values: new object[,]
                {
                    { 1, "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://media.discordapp.net/attachments/1161545688103006245/1171425219949371442/tactical-beard-brown.png?ex=655ca1c0&is=654a2cc0&hm=44c37be70087bceccb4e1e8b29418f640271e6e32984398ca58d349ba8aeb131&=&width=337&height=368", 399, "Skägg deluxe", 3, 300 },
                    { 2, "Handgjort vit klänning är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://images.pexels.com/photos/291759/pexels-photo-291759.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 699, "Vit klänning", 2, 500 },
                    { 3, "Handgjort vit hoodie är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://images.pexels.com/photos/981091/pexels-photo-981091.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 299, "Grön Hoodie", 4, 200 },
                    { 4, "Handgjort brun hoodie är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://images.pexels.com/photos/704857/pexels-photo-704857.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 299, "Brun Hoodie", 5, 200 },
                    { 5, "Handgjort svart hoodie är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://images.pexels.com/photos/744480/pexels-photo-744480.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 299, "Svart Hoodie", 5, null },
                    { 6, "Handgjort Grön klänning är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://images.pexels.com/photos/985635/pexels-photo-985635.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 299, "Grön klänning", 4, 200 },
                    { 7, "Handgjort svarta skor är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://images.pexels.com/photos/5214139/pexels-photo-5214139.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 299, "Svarta skor", 3, 200 },
                    { 8, "Handgjort vita skor är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://images.pexels.com/photos/5730956/pexels-photo-5730956.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 299, "Vita skor", 2, 200 },
                    { 9, "Handgjort Gula skor är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://images.pexels.com/photos/2529157/pexels-photo-2529157.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 299, "Gula skor", 5, 200 },
                    { 10, "Handgjort Bruna skor är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "https://images.pexels.com/photos/2562992/pexels-photo-2562992.png?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", 299, "Bruna skor", 3, 200 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CommentText", "Rating", "ReviewDate" },
                values: new object[,]
                {
                    { 1, "Excellent.I highly recommend this business", 5, new DateTime(2023, 11, 13, 1, 25, 49, 177, DateTimeKind.Local).AddTicks(7169) },
                    { 2, "Nice,I was completely impressed with their professionalism and customer service", 4, new DateTime(2023, 11, 13, 1, 25, 49, 177, DateTimeKind.Local).AddTicks(7223) },
                    { 3, "Thanks so much, I am very happy with my purchase", 3, new DateTime(2023, 11, 13, 1, 25, 49, 177, DateTimeKind.Local).AddTicks(7226) },
                    { 4, "Not bad, It could have been of better quality", 2, new DateTime(2023, 11, 13, 1, 25, 49, 177, DateTimeKind.Local).AddTicks(7229) },
                    { 5, "Eexellent, It has good quality", 5, new DateTime(2023, 11, 13, 1, 25, 49, 177, DateTimeKind.Local).AddTicks(7232) },
                    { 6, "That was OK", 3, new DateTime(2023, 11, 13, 1, 25, 49, 177, DateTimeKind.Local).AddTicks(7235) },
                    { 7, "Very good, and good quality", 5, new DateTime(2023, 11, 13, 1, 25, 49, 177, DateTimeKind.Local).AddTicks(7238) },
                    { 8, "Vey Bad, I am not satisfied at all", 1, new DateTime(2023, 11, 13, 1, 25, 49, 177, DateTimeKind.Local).AddTicks(7241) },
                    { 9, "Eexellent .Thanks so much, I am very happy with my purchase", 5, new DateTime(2023, 11, 13, 1, 25, 49, 177, DateTimeKind.Local).AddTicks(7243) },
                    { 10, "Nice ,I am very happy", 3, new DateTime(2023, 11, 13, 1, 25, 49, 177, DateTimeKind.Local).AddTicks(7246) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 5, 2 },
                    { 2, 3 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 5 },
                    { 5, 6 },
                    { 3, 7 },
                    { 2, 8 },
                    { 3, 8 },
                    { 2, 9 },
                    { 3, 9 },
                    { 2, 10 },
                    { 3, 10 }
                });

            migrationBuilder.InsertData(
                table: "ProductReviews",
                columns: new[] { "ProductId", "ReviewId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 7 },
                    { 1, 9 },
                    { 1, 10 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 5 },
                    { 4, 6 },
                    { 5, 7 },
                    { 6, 8 },
                    { 7, 10 },
                    { 8, 9 },
                    { 9, 10 },
                    { 10, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ReviewId",
                table: "ProductReviews",
                column: "ReviewId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductReviews");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
