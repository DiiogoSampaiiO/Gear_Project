﻿// <auto-generated />
using Gear_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gear_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220508224911_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Gear_API.Models.Deposito_00", b =>
                {
                    b.Property<int>("Dep_code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dep_code"), 1L, 1);

                    b.Property<string>("Dep_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Dep_code");

                    b.ToTable("Deposito_00");
                });

            modelBuilder.Entity("Gear_API.Models.Estoque_00", b =>
                {
                    b.Property<int>("Etq_code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Etq_code"), 1L, 1);

                    b.Property<int>("Dep_code")
                        .HasColumnType("int");

                    b.Property<string>("Etq_quantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Etq_code");

                    b.ToTable("Estoque_00");
                });

            modelBuilder.Entity("Gear_API.Models.Produto_00", b =>
                {
                    b.Property<int>("Pro_code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Pro_code"), 1L, 1);

                    b.Property<int>("Etq_code")
                        .HasColumnType("int");

                    b.Property<string>("Pro_name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("Pro_value")
                        .HasColumnType("float");

                    b.HasKey("Pro_code");

                    b.ToTable("Produtos_00");
                });

            modelBuilder.Entity("Gear_API.Models.Users", b =>
                {
                    b.Property<int>("Use_code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Use_code"), 1L, 1);

                    b.Property<string>("Use_email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Use_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Usu_password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Use_code");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
