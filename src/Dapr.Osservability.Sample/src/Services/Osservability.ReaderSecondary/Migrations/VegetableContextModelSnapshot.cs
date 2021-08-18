﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Osservability.ReaderSecondary.Data;

namespace Osservability.ReaderSecondary.Migrations
{
    [DbContext(typeof(VegetableContext))]
    partial class VegetableContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Osservability.ReaderSecondary.Data.Models.VegetableEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Temperature")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Vegetables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Upright habit with attractive pier green leaves with crisp costa. Voluminous and heavy head, but well conformed. The great rusticity, even in critical periods, the resistance to the ascent to seed and over-ripening, allow the maximum elasticity of collection, ensuring a quality product, even during the summer. In the kitchen it is used for very fresh single salads with vinegar and a pinch of oil or mixed with cherry tomatoes and corn.",
                            ExpirationDate = new DateTime(2021, 8, 25, 4, 33, 7, 328, DateTimeKind.Utc).AddTicks(6271),
                            Name = "Lattuga Romana",
                            Quantity = 100,
                            Temperature = 10m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
