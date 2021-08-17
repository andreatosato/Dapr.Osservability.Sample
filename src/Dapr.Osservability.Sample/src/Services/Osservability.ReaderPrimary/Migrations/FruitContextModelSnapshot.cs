﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Osservability.ReaderPrimary.Data;

namespace Osservability.ReaderPrimary.Migrations
{
    [DbContext(typeof(FruitContext))]
    partial class FruitContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Osservability.ReaderPrimary.Data.Models.FruitEntity", b =>
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

                    b.ToTable("Fruits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "We pick Fuji Melinda from mid-October onwards, when all the other apples have been picked and the highest peaks of the Trentino valleys are already covered with snow. Staying so long on the plant, it accumulates sugars: a real pleasure for the palate.",
                            ExpirationDate = new DateTime(2021, 8, 24, 14, 33, 33, 691, DateTimeKind.Utc).AddTicks(2671),
                            Name = "Mela Fuji",
                            Quantity = 100,
                            Temperature = 10m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
