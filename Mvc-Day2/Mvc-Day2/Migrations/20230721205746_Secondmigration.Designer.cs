﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mvc_Day2.Context;

#nullable disable

namespace Mvc_Day2.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20230721205746_Secondmigration")]
    partial class Secondmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mvc_Day2.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSubscribedToNewLitter")
                        .HasColumnType("bit");

                    b.Property<int>("MembershipTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfWatchedMovies")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MembershipTypeId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsSubscribedToNewLitter = false,
                            MembershipTypeId = 1,
                            Name = "Ahmed",
                            NumberOfWatchedMovies = 5
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsSubscribedToNewLitter = true,
                            MembershipTypeId = 2,
                            Name = "Mohamed",
                            NumberOfWatchedMovies = 2
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsSubscribedToNewLitter = false,
                            MembershipTypeId = 4,
                            Name = "Ali",
                            NumberOfWatchedMovies = 10
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsSubscribedToNewLitter = true,
                            MembershipTypeId = 3,
                            Name = "Mona",
                            NumberOfWatchedMovies = 3
                        });
                });

            modelBuilder.Entity("Mvc_Day2.Models.MembershipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiscountRate")
                        .HasColumnType("int");

                    b.Property<int>("DurationInMonths")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SingUpFee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MembershipTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscountRate = 20,
                            DurationInMonths = 1,
                            Name = "pay as you go",
                            SingUpFee = 50
                        },
                        new
                        {
                            Id = 2,
                            DiscountRate = 20,
                            DurationInMonths = 1,
                            Name = "monthly",
                            SingUpFee = 100
                        },
                        new
                        {
                            Id = 3,
                            DiscountRate = 20,
                            DurationInMonths = 4,
                            Name = "Quartarly",
                            SingUpFee = 400
                        },
                        new
                        {
                            Id = 4,
                            DiscountRate = 20,
                            DurationInMonths = 12,
                            Name = "Annual",
                            SingUpFee = 1000
                        });
                });

            modelBuilder.Entity("Mvc_Day2.Models.Customer", b =>
                {
                    b.HasOne("Mvc_Day2.Models.MembershipType", "MembershipType")
                        .WithMany()
                        .HasForeignKey("MembershipTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembershipType");
                });
#pragma warning restore 612, 618
        }
    }
}
