﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantProject.DataLayer;

#nullable disable

namespace RestaurantProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class RestarauntDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("TableId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("TableId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Drink", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAlcoholic")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("RestarauntId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("RestarauntId");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("RestarauntId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("RestarauntId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Restaraunt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaraunts");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Table", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("RestarauntId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WaiterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RestarauntId");

                    b.HasIndex("WaiterId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Waiter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RestarauntId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RestarauntId");

                    b.ToTable("Waiters");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Customer", b =>
                {
                    b.HasOne("RestaurantProject.DataLayer.DtoModels.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantProject.DataLayer.DtoModels.Table", "Table")
                        .WithOne("Customer")
                        .HasForeignKey("RestaurantProject.DataLayer.DtoModels.Customer", "TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Drink", b =>
                {
                    b.HasOne("RestaurantProject.DataLayer.DtoModels.Bill", null)
                        .WithMany("Drinks")
                        .HasForeignKey("BillId");

                    b.HasOne("RestaurantProject.DataLayer.DtoModels.Restaraunt", null)
                        .WithMany("Drinks")
                        .HasForeignKey("RestarauntId");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Food", b =>
                {
                    b.HasOne("RestaurantProject.DataLayer.DtoModels.Bill", null)
                        .WithMany("Foods")
                        .HasForeignKey("BillId");

                    b.HasOne("RestaurantProject.DataLayer.DtoModels.Restaraunt", null)
                        .WithMany("Foods")
                        .HasForeignKey("RestarauntId");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Table", b =>
                {
                    b.HasOne("RestaurantProject.DataLayer.DtoModels.Restaraunt", null)
                        .WithMany("Tables")
                        .HasForeignKey("RestarauntId");

                    b.HasOne("RestaurantProject.DataLayer.DtoModels.Waiter", "Waiter")
                        .WithMany()
                        .HasForeignKey("WaiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Waiter");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Waiter", b =>
                {
                    b.HasOne("RestaurantProject.DataLayer.DtoModels.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantProject.DataLayer.DtoModels.Restaraunt", null)
                        .WithMany("Waiters")
                        .HasForeignKey("RestarauntId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Bill", b =>
                {
                    b.Navigation("Drinks");

                    b.Navigation("Foods");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Restaraunt", b =>
                {
                    b.Navigation("Drinks");

                    b.Navigation("Foods");

                    b.Navigation("Tables");

                    b.Navigation("Waiters");
                });

            modelBuilder.Entity("RestaurantProject.DataLayer.DtoModels.Table", b =>
                {
                    b.Navigation("Customer")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
