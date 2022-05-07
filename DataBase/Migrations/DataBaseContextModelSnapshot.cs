﻿// <auto-generated />
using System;
using DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataBase.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("DataBase.BookedTicket", b =>
                {
                    b.Property<int>("BookedTicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClientFirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ClientLastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("FlightId")
                        .HasColumnType("integer");

                    b.HasKey("BookedTicketId");

                    b.HasIndex("FlightId");

                    b.ToTable("BookedTickets");
                });

            modelBuilder.Entity("DataBase.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("FromPlaceId")
                        .HasColumnType("integer");

                    b.Property<int>("MaxClients")
                        .HasColumnType("integer");

                    b.Property<int?>("ToPlaceId")
                        .HasColumnType("integer");

                    b.HasKey("FlightId");

                    b.HasIndex("FromPlaceId");

                    b.HasIndex("ToPlaceId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("DataBase.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PlaceId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("DataBase.BookedTicket", b =>
                {
                    b.HasOne("DataBase.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightId");

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("DataBase.Flight", b =>
                {
                    b.HasOne("DataBase.Place", "From")
                        .WithMany()
                        .HasForeignKey("FromPlaceId");

                    b.HasOne("DataBase.Place", "To")
                        .WithMany()
                        .HasForeignKey("ToPlaceId");

                    b.Navigation("From");

                    b.Navigation("To");
                });
#pragma warning restore 612, 618
        }
    }
}