﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spange_Bob.Models;

#nullable disable

namespace Spange_Bob.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221024110155_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Spange_Bob.Models.Friend", b =>
                {
                    b.Property<Guid>("FriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HomeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkinColor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FriendId");

                    b.HasIndex("HomeId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("Spange_Bob.Models.Home", b =>
                {
                    b.Property<Guid>("HomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HomeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsNeighbour")
                        .HasColumnType("bit");

                    b.HasKey("HomeId");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("Spange_Bob.Models.Friend", b =>
                {
                    b.HasOne("Spange_Bob.Models.Home", "Home")
                        .WithMany()
                        .HasForeignKey("HomeId");

                    b.Navigation("Home");
                });
#pragma warning restore 612, 618
        }
    }
}
