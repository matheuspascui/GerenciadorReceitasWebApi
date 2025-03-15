﻿// <auto-generated />
using GerenciadorReceitas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GerenciadorReceitas.Migrations
{
    [DbContext(typeof(GerenciadorReceitasDbContext))]
    [Migration("20250314214014_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GerenciadorReceitas.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.PrimitiveCollection<string>("Categorias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Ingredientes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModoDePreparo")
                        .IsRequired()
                        .HasMaxLength(1200)
                        .HasColumnType("nvarchar(1200)");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });
#pragma warning restore 612, 618
        }
    }
}
