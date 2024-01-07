﻿// <auto-generated />
using System;
using AlgorithmicTrading.Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Algorithmic_Trading.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240103232021_DateTriedTickerAdded")]
    partial class DateTriedTickerAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Algorithmic_Trading.Models.DateTried", b =>
                {
                    b.Property<string>("Ticker")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Ticker", "Date");

                    b.ToTable("DatesTried");
                });

            modelBuilder.Entity("Algorithmic_Trading.Models.StockData", b =>
                {
                    b.Property<string>("Ticker")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("AdjustedClose")
                        .HasColumnType("real");

                    b.Property<float>("Close")
                        .HasColumnType("real");

                    b.Property<float>("High")
                        .HasColumnType("real");

                    b.Property<float>("Low")
                        .HasColumnType("real");

                    b.Property<float>("Open")
                        .HasColumnType("real");

                    b.Property<int>("Volume")
                        .HasColumnType("integer");

                    b.HasKey("Ticker", "Date");

                    b.ToTable("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
