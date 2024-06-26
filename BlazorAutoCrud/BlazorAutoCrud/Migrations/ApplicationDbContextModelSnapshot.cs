﻿// <auto-generated />
using BlazorAutoCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorAutoCrud.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shared.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Name 1",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Name 2",
                            Quantity = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Name 3",
                            Quantity = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Name 4",
                            Quantity = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Name 5",
                            Quantity = 5
                        },
                        new
                        {
                            Id = 6,
                            Name = "Name 6",
                            Quantity = 6
                        },
                        new
                        {
                            Id = 7,
                            Name = "Name 7",
                            Quantity = 7
                        },
                        new
                        {
                            Id = 8,
                            Name = "Name 8",
                            Quantity = 8
                        },
                        new
                        {
                            Id = 9,
                            Name = "Name 9",
                            Quantity = 9
                        },
                        new
                        {
                            Id = 10,
                            Name = "Name 10",
                            Quantity = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
