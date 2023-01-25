﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DataAccess;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230118152540_AddPrimaryWeaponSeedDataToDB")]
    partial class AddPrimaryWeaponSeedDataToDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Warframe", b =>
                {
                    b.Property<int>("id_warframe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_warframe"));

                    b.Property<bool>("crafted")
                        .HasColumnType("bit");

                    b.Property<string>("warframe_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_warframe");

                    b.ToTable("Warframe");
                });

            modelBuilder.Entity("WinFormsApp1.Data.PrimaryWeapon", b =>
                {
                    b.Property<int>("id_primaryWeapon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_primaryWeapon"));

                    b.Property<bool>("crafted")
                        .HasColumnType("bit");

                    b.Property<string>("primaryWeapon_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_primaryWeapon");

                    b.ToTable("PrimaryWeapon");
                });
#pragma warning restore 612, 618
        }
    }
}
