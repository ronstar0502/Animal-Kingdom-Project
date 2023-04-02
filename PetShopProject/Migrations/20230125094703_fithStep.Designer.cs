﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShopProject.Data;

#nullable disable

namespace PetShopProject.Migrations
{
    [DbContext(typeof(KingdomDBContext))]
    [Migration("20230125094703_fithStep")]
    partial class fithStep
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetShopProject.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimalId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("PetShopProject.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("categoryId"));

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("categoryId");

                    b.HasIndex("AnimalId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PetShopProject.Models.Comment", b =>
                {
                    b.Property<int>("commentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("commentId"));

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("commentId");

                    b.HasIndex("AnimalId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("PetShopProject.Models.Category", b =>
                {
                    b.HasOne("PetShopProject.Models.Animal", null)
                        .WithMany("Categories")
                        .HasForeignKey("AnimalId");
                });

            modelBuilder.Entity("PetShopProject.Models.Comment", b =>
                {
                    b.HasOne("PetShopProject.Models.Animal", null)
                        .WithMany("Comments")
                        .HasForeignKey("AnimalId");
                });

            modelBuilder.Entity("PetShopProject.Models.Animal", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}