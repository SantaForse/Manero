﻿// <auto-generated />
using System;
using Manero.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Manero.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20231109141121_added-products")]
    partial class addedproducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Manero.Models.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Pants"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Accessories"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Shoes"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "T-shirts"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Dresses"
                        });
                });

            modelBuilder.Entity("Manero.Models.Entities.ProductCategoryEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("Manero.Models.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("SalePrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                            ImageUrl = "https://media.discordapp.net/attachments/1161545688103006245/1171425219949371442/tactical-beard-brown.png?ex=655ca1c0&is=654a2cc0&hm=44c37be70087bceccb4e1e8b29418f640271e6e32984398ca58d349ba8aeb131&=&width=337&height=368",
                            Price = 399,
                            ProductName = "Skägg deluxe",
                            Rating = 3,
                            SalePrice = 300
                        },
                        new
                        {
                            Id = 2,
                            Description = "Handgjort vit klänning är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                            ImageUrl = "https://media.discordapp.net/attachments/1161545688103006245/1171425219949371442/tactical-beard-brown.png?ex=655ca1c0&is=654a2cc0&hm=44c37be70087bceccb4e1e8b29418f640271e6e32984398ca58d349ba8aeb131&=&width=337&height=368",
                            Price = 699,
                            ProductName = "Vit klänning",
                            Rating = 2,
                            SalePrice = 500
                        },
                        new
                        {
                            Id = 3,
                            Description = "Handgjort svart hoodie är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                            ImageUrl = "https://media.discordapp.net/attachments/1161545688103006245/1171425219949371442/tactical-beard-brown.png?ex=655ca1c0&is=654a2cc0&hm=44c37be70087bceccb4e1e8b29418f640271e6e32984398ca58d349ba8aeb131&=&width=337&height=368",
                            Price = 299,
                            ProductName = "Svart Hoodie",
                            Rating = 4,
                            SalePrice = 200
                        },
                        new
                        {
                            Id = 4,
                            Description = "Med Andersson BHS 3.3 får du en kompakt och portabel högtalare med snygga detaljer och LED-ljus. Du kan enkelt ta samtal direkt ur högtalaren med handsfree-funktionen. Koppla din mobil till högtalaren via Bluetooth och börja lyssna!  ",
                            ImageUrl = "/static-images/pexels-mwabonje-12562635.jpg",
                            Price = 399,
                            ProductName = "BHS 3.3",
                            Rating = 3,
                            SalePrice = 300
                        },
                        new
                        {
                            Id = 5,
                            Description = "De trådlösa hörlurarna är robusta och bekväma, med vadderad huvudbygel och mjuka öronkuddar, och kan utan problem användas flera timmar i sträck.",
                            ImageUrl = "/static-images/pexels-sound-on-3761020.jpg",
                            Price = 399,
                            ProductName = "T570 BT",
                            Rating = 3,
                            SalePrice = 300
                        },
                        new
                        {
                            Id = 6,
                            Description = "Weber Master-Touch® GBS E-5750 är kolgrillen som förenar den traditionella grillkänslan med nya innovativa funktioner kombinerat med en rejäl dos bekvämlighet. Med det medföljande Gourmet BBQ System-grillgallret kan du laga frukost, tillaga ett långkok eller en frasig pizza ute i det fria. Årets Master-Touch har förbättrad ventilation som gör att du nu kan grilla och röka i en och samma grill, Tuck-Away lockhållare och One-Touch rengöringssystem som gör kolgrillning till vardags så mycket bekvämare.",
                            ImageUrl = "/static-images/pexels-min-an-1171585.jpg",
                            Price = 3290,
                            ProductName = "Master-Touch® GBS E-5750",
                            Rating = 3,
                            SalePrice = 300
                        },
                        new
                        {
                            Id = 7,
                            Description = "D9 Max från Dreame är en kraftfull robotdammsugare med 4000 Pa i sugkapacitet och en borstlös gummiborste för att säkerställa att allt damm och smuts rensas bort från dina golv!",
                            ImageUrl = "/static-images/pexels-jens-mahnke-844874.jpg",
                            Price = 3390,
                            ProductName = "D9 Max",
                            Rating = 3,
                            SalePrice = 300
                        },
                        new
                        {
                            Id = 8,
                            Description = "Beurer BM 28 är en helautomatisk blodtrycksmätare för överarmen. Den visar systoliskt och diastoliskt tryck samt puls.",
                            ImageUrl = "/static-images/pexels-mikhail-nilov-8670204.jpg",
                            Price = 449,
                            ProductName = "BM 28",
                            Rating = 3,
                            SalePrice = 300
                        },
                        new
                        {
                            Id = 9,
                            Description = "Klassiska enlagers-kängor som passar för dig som rör dig i skogen, på leden eller i stan. Utformade med ovandel i Heinen Terracare-skinn och med vattentät, cellgummibotten med Certech 2.0-konstruktion som är både lätt och flexibel. Lundhags Wayfinder-yttersula är tillverkad i mjukt 60 ShA-gummimaterial och ger utmärkt grepp.",
                            ImageUrl = "/static-images/pexels-aidan-jarrett-718981.jpg",
                            Price = 2175,
                            ProductName = "U Park",
                            Rating = 3,
                            SalePrice = 300
                        },
                        new
                        {
                            Id = 10,
                            Description = "Stabila löparskor med bekväm dämpning, för dig som springer längre pass. Skorna har en specialutformad ovandel i mesh som är ventilerande och som omsluter foten med en mjuk känsla. FlyteFoam-mellansulan ger lätt stötdämpning under löpningen och GEL-teknologin i hälen skapar mjukare landningar och smidigare övergångar.",
                            ImageUrl = "/static-images/pexels-melvin-buezo-2529148.jpg",
                            Price = 1099,
                            ProductName = "W Gt-1000",
                            Rating = 3,
                            SalePrice = 300
                        },
                        new
                        {
                            Id = 11,
                            Description = "Sandaler med stötdämpande och elastisk naturkorksfotbädd som är fuktavvisande. Sandalerna ger även bra mellanfotsstöd och har djup hälkopp för optimal stabilitet.",
                            ImageUrl = "/static-images/pexels-mike-bird-112285.jpg",
                            Price = 379,
                            ProductName = "U Comfort Sandal",
                            Rating = 3,
                            SalePrice = 300
                        },
                        new
                        {
                            Id = 12,
                            Description = "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                            ImageUrl = "/static-images/tactical-beard-brown.png",
                            Price = 249,
                            ProductName = "Taktiskt skägg",
                            Rating = 3,
                            SalePrice = 300
                        });
                });

            modelBuilder.Entity("Manero.Models.Entities.ProductCategoryEntity", b =>
                {
                    b.HasOne("Manero.Models.Entities.CategoryEntity", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Manero.Models.Entities.ProductEntity", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
