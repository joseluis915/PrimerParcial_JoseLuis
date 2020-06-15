﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrimerParcial_JoseLuis.DAL;

namespace PrimerParcial_JoseLuis.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("PrimerParcial_JoseLuis.Entidades.Articulos", b =>
                {
                    b.Property<int>("IdArticulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Costo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ValorInventario")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdArticulo");

                    b.ToTable("Articulos");
                });
#pragma warning restore 612, 618
        }
    }
}