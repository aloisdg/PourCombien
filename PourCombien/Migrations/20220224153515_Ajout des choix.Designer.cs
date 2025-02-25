﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PourCombien.Database;

namespace PourCombien.Migrations
{
    [DbContext(typeof(PourCombienContext))]
    [Migration("20220224153515_Ajout des choix")]
    partial class Ajoutdeschoix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("PourCombien.Database.Defi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Choix1")
                        .HasColumnType("int");

                    b.Property<int>("Choix2")
                        .HasColumnType("int");

                    b.Property<int>("Max")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Defis");
                });
#pragma warning restore 612, 618
        }
    }
}
