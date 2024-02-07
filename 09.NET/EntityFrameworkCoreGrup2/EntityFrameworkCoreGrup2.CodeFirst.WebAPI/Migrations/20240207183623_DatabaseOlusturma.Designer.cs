﻿// <auto-generated />
using System;
using EntityFrameworkCoreGrup2.CodeFirst.WebAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkCoreGrup2.CodeFirst.WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240207183623_DatabaseOlusturma")]
    partial class DatabaseOlusturma
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameworkCoreGrup2.CodeFirst.WebAPI.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
