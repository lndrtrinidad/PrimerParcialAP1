﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroArticulo.DAL;

namespace RegistroArticulo.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200615232038_Migracion_Inicial")]
    partial class Migracion_Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("RegistroArticulo.Entidades.Articulos", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Costo")
                        .HasColumnType("REAL");

                    b.Property<int>("Descripcion")
                        .HasColumnType("INTEGER");

                    b.Property<float>("ValorInv")
                        .HasColumnType("REAL");

                    b.HasKey("ArticuloId");

                    b.ToTable("Articulos");
                });
#pragma warning restore 612, 618
        }
    }
}
