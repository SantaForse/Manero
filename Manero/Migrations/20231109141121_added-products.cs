using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Manero.Migrations
{
    /// <inheritdoc />
    public partial class addedproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "ProductName", "Rating", "SalePrice" },
                values: new object[,]
                {
                    { 4, "Med Andersson BHS 3.3 får du en kompakt och portabel högtalare med snygga detaljer och LED-ljus. Du kan enkelt ta samtal direkt ur högtalaren med handsfree-funktionen. Koppla din mobil till högtalaren via Bluetooth och börja lyssna!  ", "/static-images/pexels-mwabonje-12562635.jpg", 399, "BHS 3.3", 3, 300 },
                    { 5, "De trådlösa hörlurarna är robusta och bekväma, med vadderad huvudbygel och mjuka öronkuddar, och kan utan problem användas flera timmar i sträck.", "/static-images/pexels-sound-on-3761020.jpg", 399, "T570 BT", 3, 300 },
                    { 6, "Weber Master-Touch® GBS E-5750 är kolgrillen som förenar den traditionella grillkänslan med nya innovativa funktioner kombinerat med en rejäl dos bekvämlighet. Med det medföljande Gourmet BBQ System-grillgallret kan du laga frukost, tillaga ett långkok eller en frasig pizza ute i det fria. Årets Master-Touch har förbättrad ventilation som gör att du nu kan grilla och röka i en och samma grill, Tuck-Away lockhållare och One-Touch rengöringssystem som gör kolgrillning till vardags så mycket bekvämare.", "/static-images/pexels-min-an-1171585.jpg", 3290, "Master-Touch® GBS E-5750", 3, 300 },
                    { 7, "D9 Max från Dreame är en kraftfull robotdammsugare med 4000 Pa i sugkapacitet och en borstlös gummiborste för att säkerställa att allt damm och smuts rensas bort från dina golv!", "/static-images/pexels-jens-mahnke-844874.jpg", 3390, "D9 Max", 3, 300 },
                    { 8, "Beurer BM 28 är en helautomatisk blodtrycksmätare för överarmen. Den visar systoliskt och diastoliskt tryck samt puls.", "/static-images/pexels-mikhail-nilov-8670204.jpg", 449, "BM 28", 3, 300 },
                    { 9, "Klassiska enlagers-kängor som passar för dig som rör dig i skogen, på leden eller i stan. Utformade med ovandel i Heinen Terracare-skinn och med vattentät, cellgummibotten med Certech 2.0-konstruktion som är både lätt och flexibel. Lundhags Wayfinder-yttersula är tillverkad i mjukt 60 ShA-gummimaterial och ger utmärkt grepp.", "/static-images/pexels-aidan-jarrett-718981.jpg", 2175, "U Park", 3, 300 },
                    { 10, "Stabila löparskor med bekväm dämpning, för dig som springer längre pass. Skorna har en specialutformad ovandel i mesh som är ventilerande och som omsluter foten med en mjuk känsla. FlyteFoam-mellansulan ger lätt stötdämpning under löpningen och GEL-teknologin i hälen skapar mjukare landningar och smidigare övergångar.", "/static-images/pexels-melvin-buezo-2529148.jpg", 1099, "W Gt-1000", 3, 300 },
                    { 11, "Sandaler med stötdämpande och elastisk naturkorksfotbädd som är fuktavvisande. Sandalerna ger även bra mellanfotsstöd och har djup hälkopp för optimal stabilitet.", "/static-images/pexels-mike-bird-112285.jpg", 379, "U Comfort Sandal", 3, 300 },
                    { 12, "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", "/static-images/tactical-beard-brown.png", 249, "Taktiskt skägg", 3, 300 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
