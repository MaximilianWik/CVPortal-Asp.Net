﻿// <auto-generated />
using System;
using CVPortalen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CVPortalen.Migrations
{
    [DbContext(typeof(ProfilContext))]
    [Migration("20231221131211_Sugar")]
    partial class Sugar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CVPortalen.Models.Anvandare", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "00fdeed5-06f6-4b9c-ac0e-fe09ca76e20d",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedUserName = "FILIPNYDEN",
                            PasswordHash = "AQAAAAIAAYagAAAAEGOFMLWAEJf5pY+7keP7dhp0TjCaNWg92ylUGOhZyeWYSGeuRhonpIkUsdLAf5xSvw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ZHC7O3BJZA6YHMG7J4LWDL7NW4VPWY3D",
                            TwoFactorEnabled = false,
                            UserName = "filipnyden"
                        },
                        new
                        {
                            Id = "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0533d953-ffba-442d-a99b-9368479a2969",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedUserName = "ANTONLIND",
                            PasswordHash = "AQAAAAIAAYagAAAAEALc0XkwA+lz9cyoKHl396wtSVcLEtpdidrxuo3nRV038x0Hl5hm4ghNOr6iv+e6wA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3KSCKA2ZWKSZLFTU6VTN2U47BE2WEQRN",
                            TwoFactorEnabled = false,
                            UserName = "AntonLind"
                        },
                        new
                        {
                            Id = "95140368-5cbe-46a2-8ff0-f573534cb391",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "546a5521-c0b3-434d-b3df-1ae5973ecb54",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedUserName = "JOHANS",
                            PasswordHash = "AQAAAAIAAYagAAAAEMXC/lY3tbpGHLgzXHSe+XBPrNk1qBRh3fzuh4WegZjH8zb6oTDeXHboxYyFcQj8rg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2QB3XVNXYN3E3JKGLPF37UNUDS57MJC2",
                            TwoFactorEnabled = false,
                            UserName = "JohanS"
                        },
                        new
                        {
                            Id = "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a846724d-79a9-43ca-9cd9-ef7714322447",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedUserName = "JACOBW",
                            PasswordHash = "AQAAAAIAAYagAAAAECz0jQBWKaLceG96fQtaSK1oNdUYyLtudO8i88XQeaEur1wemrG3WMMBs/K7Yx5YHg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "S4LN2MR2XLOF2MAH2DALTCBZ6UMVJV22",
                            TwoFactorEnabled = false,
                            UserName = "JacobW"
                        },
                        new
                        {
                            Id = "25d150cf-9187-4a8b-9fba-301c1972ddee",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "21f28f1c-957a-4daf-840c-6f418efa1d27",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedUserName = "MAXWIK",
                            PasswordHash = "AQAAAAIAAYagAAAAECb3hhXh+PSZ5S/Qu/0q84weqGVahX11ZIug1N6ZACD+HIjsZfbWbz5tP3UIIKX6vw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "WHIMEAWPQ44OOY5IIDFFD4444W3VLH3G",
                            TwoFactorEnabled = false,
                            UserName = "MaxWik"
                        });
                });

            modelBuilder.Entity("CVPortalen.Models.CV", b =>
                {
                    b.Property<int>("CVId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CVId"));

                    b.Property<string>("Arbetsplats")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beskrivning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CVId");

                    b.ToTable("cVs");

                    b.HasData(
                        new
                        {
                            CVId = 1,
                            Arbetsplats = "TestCO",
                            Beskrivning = "Hej",
                            Titel = "Test1"
                        },
                        new
                        {
                            CVId = 2,
                            Arbetsplats = "TestCO",
                            Beskrivning = "Hej",
                            Titel = "Test2"
                        });
                });

            modelBuilder.Entity("CVPortalen.Models.Meddelande", b =>
                {
                    b.Property<int>("MeddelandeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MeddelandeId"));

                    b.Property<string>("MeddelandeText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SkickatTill")
                        .HasColumnType("int");

                    b.HasKey("MeddelandeId");

                    b.ToTable("meddelande");
                });

            modelBuilder.Entity("CVPortalen.Models.Profil", b =>
                {
                    b.Property<int>("ProfilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfilId"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnvandarNamn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Epost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Losenord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelefonNummer")
                        .HasColumnType("int");

                    b.Property<int>("TillhorandeCV")
                        .HasColumnType("int");

                    b.HasKey("ProfilId");

                    b.ToTable("Profils");
                });

            modelBuilder.Entity("CVPortalen.Models.Projekt", b =>
                {
                    b.Property<int>("ProjektId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjektId"));

                    b.Property<int>("Artal")
                        .HasColumnType("int");

                    b.Property<string>("Infromation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjektName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Tid")
                        .HasColumnType("date");

                    b.HasKey("ProjektId");

                    b.ToTable("projekt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CVPortalen.Models.Anvandare", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CVPortalen.Models.Anvandare", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CVPortalen.Models.Anvandare", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CVPortalen.Models.Anvandare", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
