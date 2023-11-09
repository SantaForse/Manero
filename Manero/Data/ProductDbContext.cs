using Manero.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Manero.Data;

public class ProductDbContext : DbContext
{

    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
    }

    public DbSet <ProductEntity> Products { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<ProductCategoryEntity> ProductCategories { get; set; }


    //Static example product
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity
                {
                    ProductName = "Skägg deluxe",
                    Id = 1,
                    //CategoryId = 1, 
                    Description = "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 3,
                    SalePrice = 300,
                    Price = 399,
                    ImageUrl = "https://media.discordapp.net/attachments/1161545688103006245/1171425219949371442/tactical-beard-brown.png?ex=655ca1c0&is=654a2cc0&hm=44c37be70087bceccb4e1e8b29418f640271e6e32984398ca58d349ba8aeb131&=&width=337&height=368"
                },
                new ProductEntity
                {
                    ProductName = "Vit klänning",
                    Id = 2,
                    //CategoryId = 1, 
                    Description = "Handgjort vit klänning är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 2,
                    SalePrice = 500,
                    Price = 699,
                    ImageUrl = "https://media.discordapp.net/attachments/1161545688103006245/1171425219949371442/tactical-beard-brown.png?ex=655ca1c0&is=654a2cc0&hm=44c37be70087bceccb4e1e8b29418f640271e6e32984398ca58d349ba8aeb131&=&width=337&height=368"
                },
                new ProductEntity
                {
                    ProductName = "Svart Hoodie",
                    Id = 3,
                    //CategoryId = 1, 
                    Description = "Handgjort svart hoodie är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    Rating = 4,
                    SalePrice = 200,
                    Price = 299,
                    ImageUrl = "https://media.discordapp.net/attachments/1161545688103006245/1171425219949371442/tactical-beard-brown.png?ex=655ca1c0&is=654a2cc0&hm=44c37be70087bceccb4e1e8b29418f640271e6e32984398ca58d349ba8aeb131&=&width=337&height=368"
                },
                new ProductEntity
                {
                    Id = 4,
                    //CategoryId = 1, 
                    Description = "Med Andersson BHS 3.3 får du en kompakt och portabel högtalare med snygga detaljer och LED-ljus. Du kan enkelt ta samtal direkt ur högtalaren med handsfree-funktionen. Koppla din mobil till högtalaren via Bluetooth och börja lyssna!  ",
                    Rating = 3,
                    SalePrice = 300,
                    ImageUrl = "/static-images/pexels-mwabonje-12562635.jpg",
                    ProductName = "BHS 3.3",
                    Price = 399
                },

                new ProductEntity
                {
                    Id = 5,
                    //CategoryId = 1, 
                    Description = "De trådlösa hörlurarna är robusta och bekväma, med vadderad huvudbygel och mjuka öronkuddar, och kan utan problem användas flera timmar i sträck.",
                    Rating = 3,
                    SalePrice = 300,
                    ImageUrl = "/static-images/pexels-sound-on-3761020.jpg",
                    ProductName = "T570 BT",
                    Price = 399
                },

                new ProductEntity
                {
                    Id = 6,
                    //CategoryId = 2, 
                    Description = "Weber Master-Touch® GBS E-5750 är kolgrillen som förenar den traditionella grillkänslan med nya innovativa funktioner kombinerat med en rejäl dos bekvämlighet. Med det medföljande Gourmet BBQ System-grillgallret kan du laga frukost, tillaga ett långkok eller en frasig pizza ute i det fria. Årets Master-Touch har förbättrad ventilation som gör att du nu kan grilla och röka i en och samma grill, Tuck-Away lockhållare och One-Touch rengöringssystem som gör kolgrillning till vardags så mycket bekvämare.",
                    Rating = 3,
                    SalePrice = 300,
                    ImageUrl = "/static-images/pexels-min-an-1171585.jpg",
                    ProductName = "Master-Touch® GBS E-5750",
                    Price = 3290
                },

                new ProductEntity
                {
                    Id = 7,
                    //CategoryId = 2, 
                    Rating = 3,
                    SalePrice = 300,
                    Description = "D9 Max från Dreame är en kraftfull robotdammsugare med 4000 Pa i sugkapacitet och en borstlös gummiborste för att säkerställa att allt damm och smuts rensas bort från dina golv!",
                    ImageUrl = "/static-images/pexels-jens-mahnke-844874.jpg",
                    ProductName = "D9 Max",
                    Price = 3390
                },

                new ProductEntity
                {
                    Id = 8,
                    //CategoryId = 2, 
                    Rating = 3,
                    SalePrice = 300,
                    Description = "Beurer BM 28 är en helautomatisk blodtrycksmätare för överarmen. Den visar systoliskt och diastoliskt tryck samt puls.",
                    ImageUrl = "/static-images/pexels-mikhail-nilov-8670204.jpg",
                    ProductName = "BM 28",
                    Price = 449
                },

                new ProductEntity
                {
                    Id = 9,
                    //CategoryId = 3, 
                    Rating = 3,
                    SalePrice = 300,
                    Description = "Klassiska enlagers-kängor som passar för dig som rör dig i skogen, på leden eller i stan. Utformade med ovandel i Heinen Terracare-skinn och med vattentät, cellgummibotten med Certech 2.0-konstruktion som är både lätt och flexibel. Lundhags Wayfinder-yttersula är tillverkad i mjukt 60 ShA-gummimaterial och ger utmärkt grepp.",
                    ImageUrl = "/static-images/pexels-aidan-jarrett-718981.jpg",
                    ProductName = "U Park",
                    Price = 2175
                },

                new ProductEntity
                {
                    Id = 10,
                    //CategoryId = 3, 
                    Rating = 3,
                    SalePrice = 300,
                    Description = "Stabila löparskor med bekväm dämpning, för dig som springer längre pass. Skorna har en specialutformad ovandel i mesh som är ventilerande och som omsluter foten med en mjuk känsla. FlyteFoam-mellansulan ger lätt stötdämpning under löpningen och GEL-teknologin i hälen skapar mjukare landningar och smidigare övergångar.",
                    ImageUrl = "/static-images/pexels-melvin-buezo-2529148.jpg",
                    ProductName = "W Gt-1000",
                    Price = 1099
                },

                new ProductEntity
                {
                    Id = 11,
                    //CategoryId = 3, 
                    Rating = 3,
                    SalePrice = 300,
                    Description = "Sandaler med stötdämpande och elastisk naturkorksfotbädd som är fuktavvisande. Sandalerna ger även bra mellanfotsstöd och har djup hälkopp för optimal stabilitet.",
                    ImageUrl = "/static-images/pexels-mike-bird-112285.jpg",
                    ProductName = "U Comfort Sandal",
                    Price = 379
                },

                new ProductEntity
                {
                    Id = 12,
                    //CategoryId = 4, 
                    Rating = 3,
                    SalePrice = 300,
                    Description = "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                    ImageUrl = "/static-images/tactical-beard-brown.png",
                    ProductName = "Taktiskt skägg",
                    Price = 249
                }
                );

        modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity
                {
                    Id = 1,
                    CategoryName = "Pants",
                },
                new CategoryEntity
                {
                    Id = 2,
                    CategoryName = "Accessories",
                },
                new CategoryEntity
                {
                    Id = 3,
                    CategoryName = "Shoes",
                },
                new CategoryEntity
                {
                    Id = 4,
                    CategoryName = "T-shirts",
                },
                new CategoryEntity
                {
                    Id = 5,
                    CategoryName = "Dresses",
                });

                modelBuilder.Entity<ProductCategoryEntity>().HasData(
                new ProductCategoryEntity
                {
                    ProductId = 1,
                    CategoryId = 2,
                },
                new ProductCategoryEntity
                {
                    ProductId = 2,
                    CategoryId = 5,
                },
                new ProductCategoryEntity
                {
                    ProductId = 1,
                    CategoryId = 3,
                });
            }
                
}



