﻿// <auto-generated />
using System;
using FutterautomatenDatenbank.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FutterautomatenDatenbank.Migrations
{
    [DbContext(typeof(FutterautomatenContext))]
    [Migration("20240803101318_changePersonDb")]
    partial class changePersonDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("FutterautomatenDatenbank.Models.Aquarium", b =>
                {
                    b.Property<int>("AquariumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aufstellort")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Groeße")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AquariumId");

                    b.ToTable("Aquarien");
                });

            modelBuilder.Entity("FutterautomatenDatenbank.Models.Fuetterung", b =>
                {
                    b.Property<int>("FuetterungId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FutterautomatId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Futtermenge")
                        .HasColumnType("REAL");

                    b.Property<DateOnly>("Tag")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("Uhrzeit")
                        .HasColumnType("TEXT");

                    b.HasKey("FuetterungId");

                    b.HasIndex("FutterautomatId");

                    b.ToTable("Fuetterungen");
                });

            modelBuilder.Entity("FutterautomatenDatenbank.Models.Futter", b =>
                {
                    b.Property<int>("FutterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Beschreibung")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FutterName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Packungsinhalt")
                        .HasColumnType("REAL");

                    b.HasKey("FutterId");

                    b.ToTable("FutterArt");
                });

            modelBuilder.Entity("FutterautomatenDatenbank.Models.Futterautomat", b =>
                {
                    b.Property<int>("FutterautomatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AquariumId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bezeichnung")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("FutterFaktor")
                        .HasColumnType("REAL");

                    b.Property<int?>("FutterId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PersonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FutterautomatId");

                    b.HasIndex("AquariumId");

                    b.HasIndex("FutterId");

                    b.HasIndex("PersonId");

                    b.ToTable("Futterautomaten");
                });

            modelBuilder.Entity("FutterautomatenDatenbank.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("Personen");
                });

            modelBuilder.Entity("FutterautomatenDatenbank.Models.Fuetterung", b =>
                {
                    b.HasOne("FutterautomatenDatenbank.Models.Futterautomat", "Futterautomat")
                        .WithMany("Fuetterungen")
                        .HasForeignKey("FutterautomatId");

                    b.Navigation("Futterautomat");
                });

            modelBuilder.Entity("FutterautomatenDatenbank.Models.Futterautomat", b =>
                {
                    b.HasOne("FutterautomatenDatenbank.Models.Aquarium", "Aquarium")
                        .WithMany("Futterautomaten")
                        .HasForeignKey("AquariumId");

                    b.HasOne("FutterautomatenDatenbank.Models.Futter", "Futter")
                        .WithMany("Futterautomat")
                        .HasForeignKey("FutterId");

                    b.HasOne("FutterautomatenDatenbank.Models.Person", "Person")
                        .WithMany("Futterautomaten")
                        .HasForeignKey("PersonId");

                    b.Navigation("Aquarium");

                    b.Navigation("Futter");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("FutterautomatenDatenbank.Models.Aquarium", b =>
                {
                    b.Navigation("Futterautomaten");
                });

            modelBuilder.Entity("FutterautomatenDatenbank.Models.Futter", b =>
                {
                    b.Navigation("Futterautomat");
                });

            modelBuilder.Entity("FutterautomatenDatenbank.Models.Futterautomat", b =>
                {
                    b.Navigation("Fuetterungen");
                });

            modelBuilder.Entity("FutterautomatenDatenbank.Models.Person", b =>
                {
                    b.Navigation("Futterautomaten");
                });
#pragma warning restore 612, 618
        }
    }
}
