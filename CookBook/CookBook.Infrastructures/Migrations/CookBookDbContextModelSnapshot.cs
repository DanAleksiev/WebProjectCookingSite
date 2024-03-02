﻿// <auto-generated />
using System;
using CookBook.Infrastructures.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CookBook.Infrastructures.Migrations
{
    [DbContext(typeof(CookBookDbContext))]
    partial class CookBookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Drinks.DrinkRecepie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cups")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripton")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsAlcoholic")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PrepTime")
                        .HasColumnType("int");

                    b.Property<int>("TumbsUp")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("DrinkRecepies");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Food.FavouriteFoodRecepiesUsers", b =>
                {
                    b.Property<int>("FoodRecepieId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FoodRecepieId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("FavouriteFoodRecepiesUsers");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Food.FoodRecepie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CookTime")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripton")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastTimeYouHadIt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("OvenTypeId")
                        .HasColumnType("int");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Portions")
                        .HasColumnType("int");

                    b.Property<int>("PrepTime")
                        .HasColumnType("int");

                    b.Property<int>("RecepieTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Temperature")
                        .HasColumnType("int");

                    b.Property<int>("TemperatureMeasurmentId")
                        .HasColumnType("int");

                    b.Property<int>("TumbsUp")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OvenTypeId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("RecepieTypeId");

                    b.HasIndex("TemperatureMeasurmentId");

                    b.ToTable("FoodRecepies");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Food.FoodRecepiesUsers", b =>
                {
                    b.Property<int>("FoodRecepieId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FoodRecepieId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("FoodRecepiesUsers");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Food.OvenType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("OvenTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "No oven needed"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Conventional"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fan"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gas"
                        });
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Food.RecepieType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RecepieTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A salad is a dish consisting of mixed ingredients, frequently vegetables. They are typically served chilled or at room temperature, though some can be served warm. Condiments and salad dressings, which exist in a variety of flavors, are often used to enhance a salad.",
                            Name = "Salad"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Soup is a primarily liquid food, generally served warm or hot (but may be cool or cold), that is made by combining ingredients of meat or vegetables with stock, milk, or water. Hot soups are additionally characterized by boiling solid ingredients in liquids in a pot until the flavors are extracted, forming a broth.",
                            Name = "Soup"
                        },
                        new
                        {
                            Id = 3,
                            Description = "pastry, stiff dough made from flour, salt, a relatively high proportion of fat, and a small proportion of liquid. It may also contain sugar or flavourings. Most pastry is leavened only by the action of steam, but Danish pastry is raised with yeast.",
                            Name = "Pastry"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A stew is a combination of solid food ingredients that have been cooked in liquid and served in the resultant gravy. Ingredients can include any combination of vegetables and may include meat, especially tougher meats suitable for slow-cooking, such as beef, pork, venison, rabbit, lamb, poultry, sausages, and seafood.",
                            Name = "Stew"
                        },
                        new
                        {
                            Id = 20,
                            Description = "",
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Food.TemperatureMeasurment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("TemperaturesMeasurments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ºC"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ºF"
                        });
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.DrinkRecepiesUsers", b =>
                {
                    b.Property<int>("DrinkRecepieId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DrinkRecepieId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("DrinksRecepiesUsers");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<int>("MeasurementId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MeasurementId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.IngredientDrinkRecepie", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecepieId")
                        .HasColumnType("int");

                    b.HasKey("IngredientId", "RecepieId");

                    b.HasIndex("RecepieId");

                    b.ToTable("IngredientDrinkRecepies");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.IngredientFoodRecepie", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecepieId")
                        .HasColumnType("int");

                    b.HasKey("IngredientId", "RecepieId");

                    b.HasIndex("RecepieId");

                    b.ToTable("IngredientFoodRecepies");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.Measurement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Measurements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Each"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Gram"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kilograms"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Table spoon"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cups"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Milliliter"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Liter"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Pinch"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ounce"
                        },
                        new
                        {
                            Id = 20,
                            Name = "To taste"
                        });
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("DrinkRecepieId")
                        .HasColumnType("int");

                    b.Property<int?>("FoodRecepieId")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DrinkRecepieId");

                    b.HasIndex("FoodRecepieId");

                    b.ToTable("Steps");
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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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
                            Id = "2fed703f-2696-4945-9012-e2b8178934c7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4f746109-a843-40ca-9098-55afbd5fe125",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedUserName = "TEST@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEfb4wc8ZTiVgAju5iVT1VkWZNfpWJkX/ft7KVg+HkjV1UY4z2e3JJGilMPnyJHV2A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6f6d0232-74db-4fb1-9a29-5aadf22c688a",
                            TwoFactorEnabled = false,
                            UserName = "test@test.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Drinks.DrinkRecepie", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Food.FavouriteFoodRecepiesUsers", b =>
                {
                    b.HasOne("CookBook.Infrastructures.Data.Models.Food.FoodRecepie", "FoodRecepie")
                        .WithMany("FavouriteRecepiesUsers")
                        .HasForeignKey("FoodRecepieId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FoodRecepie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Food.FoodRecepie", b =>
                {
                    b.HasOne("CookBook.Infrastructures.Data.Models.Food.OvenType", "OvenType")
                        .WithMany()
                        .HasForeignKey("OvenTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CookBook.Infrastructures.Data.Models.Food.RecepieType", "RecepieType")
                        .WithMany()
                        .HasForeignKey("RecepieTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CookBook.Infrastructures.Data.Models.Food.TemperatureMeasurment", "TemperatureMeasurment")
                        .WithMany()
                        .HasForeignKey("TemperatureMeasurmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OvenType");

                    b.Navigation("Owner");

                    b.Navigation("RecepieType");

                    b.Navigation("TemperatureMeasurment");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Food.FoodRecepiesUsers", b =>
                {
                    b.HasOne("CookBook.Infrastructures.Data.Models.Food.FoodRecepie", "FoodRecepie")
                        .WithMany("RecepiesUsers")
                        .HasForeignKey("FoodRecepieId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FoodRecepie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.DrinkRecepiesUsers", b =>
                {
                    b.HasOne("CookBook.Infrastructures.Data.Models.Drinks.DrinkRecepie", "DrinkRecepie")
                        .WithMany("RecepiesUsers")
                        .HasForeignKey("DrinkRecepieId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DrinkRecepie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.Ingredient", b =>
                {
                    b.HasOne("CookBook.Infrastructures.Data.Models.Shared.Measurement", "Measurement")
                        .WithMany()
                        .HasForeignKey("MeasurementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Measurement");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.IngredientDrinkRecepie", b =>
                {
                    b.HasOne("CookBook.Infrastructures.Data.Models.Shared.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CookBook.Infrastructures.Data.Models.Drinks.DrinkRecepie", "Recepie")
                        .WithMany("IngredientsRecepies")
                        .HasForeignKey("RecepieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recepie");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.IngredientFoodRecepie", b =>
                {
                    b.HasOne("CookBook.Infrastructures.Data.Models.Shared.Ingredient", "Ingredient")
                        .WithMany("IngredientsRecepies")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CookBook.Infrastructures.Data.Models.Food.FoodRecepie", "Recepie")
                        .WithMany("IngredientsRecepies")
                        .HasForeignKey("RecepieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recepie");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.Step", b =>
                {
                    b.HasOne("CookBook.Infrastructures.Data.Models.Drinks.DrinkRecepie", null)
                        .WithMany("Steps")
                        .HasForeignKey("DrinkRecepieId");

                    b.HasOne("CookBook.Infrastructures.Data.Models.Food.FoodRecepie", null)
                        .WithMany("Steps")
                        .HasForeignKey("FoodRecepieId");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Drinks.DrinkRecepie", b =>
                {
                    b.Navigation("IngredientsRecepies");

                    b.Navigation("RecepiesUsers");

                    b.Navigation("Steps");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Food.FoodRecepie", b =>
                {
                    b.Navigation("FavouriteRecepiesUsers");

                    b.Navigation("IngredientsRecepies");

                    b.Navigation("RecepiesUsers");

                    b.Navigation("Steps");
                });

            modelBuilder.Entity("CookBook.Infrastructures.Data.Models.Shared.Ingredient", b =>
                {
                    b.Navigation("IngredientsRecepies");
                });
#pragma warning restore 612, 618
        }
    }
}
