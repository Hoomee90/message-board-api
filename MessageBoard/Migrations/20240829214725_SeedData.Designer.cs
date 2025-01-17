﻿// <auto-generated />
using System;
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MessageBoard.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    [Migration("20240829214725_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoard.Models.Board", b =>
                {
                    b.Property<int>("BoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("BoardId");

                    b.ToTable("Boards");

                    b.HasData(
                        new
                        {
                            BoardId = 1,
                            Description = "Write write write write",
                            Title = "Writing"
                        },
                        new
                        {
                            BoardId = 2,
                            Description = "Art cool stuff",
                            Title = "Art"
                        });
                });

            modelBuilder.Entity("MessageBoard.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BoardId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("MessageId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            BoardId = 1,
                            Content = "Woolly Mammoth",
                            PostedOn = new DateTime(2018, 8, 18, 7, 22, 16, 0, DateTimeKind.Unspecified),
                            Username = "Matilda"
                        },
                        new
                        {
                            MessageId = 6,
                            BoardId = 2,
                            Content = "Dinosaur",
                            PostedOn = new DateTime(2018, 8, 18, 0, 22, 16, 0, DateTimeKind.Local),
                            Username = "Rexie"
                        },
                        new
                        {
                            MessageId = 3,
                            BoardId = 7,
                            Content = "Dinosaur",
                            PostedOn = new DateTime(2018, 8, 18, 0, 22, 16, 0, DateTimeKind.Local),
                            Username = "Matilda"
                        },
                        new
                        {
                            MessageId = 4,
                            BoardId = 1,
                            Content = "Shark",
                            PostedOn = new DateTime(2022, 8, 28, 11, 22, 16, 0, DateTimeKind.Unspecified),
                            Username = "Pip"
                        },
                        new
                        {
                            MessageId = 5,
                            BoardId = 2,
                            Content = "Dinosaur",
                            PostedOn = new DateTime(2010, 12, 1, 1, 23, 50, 0, DateTimeKind.Unspecified),
                            Username = "Bartholomew"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
