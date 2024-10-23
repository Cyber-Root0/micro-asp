﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ProductApiDbContext))]
    [Migration("20241019000614_create_products_table")]
    partial class create_products_table
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Infrastructure.Context.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT")
                        .HasColumnName("CREATED");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("NAME");

                    b.Property<double>("Price")
                        .HasColumnType("REAL")
                        .HasColumnName("PRICE");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("TEXT")
                        .HasColumnName("UPDATED");

                    b.HasKey("Id");

                    b.ToTable("PRODUCTS", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
