﻿// <auto-generated />
using System;
using DiaryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiaryApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250513134716_AddSeedToDatabase")]
    partial class AddSeedToDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiaryApp.Models.DiaryEntry", b =>
                {
                    b.Property<int>("DairyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DairyId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DairyId");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            DairyId = 1,
                            CreatedAt = new DateTime(2025, 5, 13, 7, 47, 14, 961, DateTimeKind.Local).AddTicks(2170),
                            Description = "Felipe comio pizza",
                            Title = "Felipe en la pizzeria"
                        },
                        new
                        {
                            DairyId = 2,
                            CreatedAt = new DateTime(2025, 5, 13, 7, 47, 14, 961, DateTimeKind.Local).AddTicks(2173),
                            Description = "Felipe comio helado",
                            Title = "Felipe en la heladeria"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
