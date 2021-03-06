﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba_Parcial.DAL;

namespace Prueba_Parcial.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20201025142300_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Prueba_Parcial.Models.Articulo", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArticuloId");

                    b.ToTable("Articulo");

                    b.HasData(
                        new
                        {
                            ArticuloId = 1,
                            Departamento = "Tecnologia",
                            DepartamentoId = 1,
                            Descripcion = "Iphone 2g",
                            Existencia = 2,
                            Precio = 4000m,
                            Referencia = "Tecn"
                        },
                        new
                        {
                            ArticuloId = 2,
                            Departamento = "Tecnologia",
                            DepartamentoId = 1,
                            Descripcion = "Iphone 3g",
                            Existencia = 3,
                            Precio = 5000m,
                            Referencia = "Tecn"
                        },
                        new
                        {
                            ArticuloId = 3,
                            Departamento = "Ferreteria",
                            DepartamentoId = 2,
                            Descripcion = "Tornillo Grande",
                            Existencia = 100,
                            Precio = 15m,
                            Referencia = "Tool"
                        });
                });

            modelBuilder.Entity("Prueba_Parcial.Models.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamento");

                    b.HasData(
                        new
                        {
                            DepartamentoId = 1,
                            Descripcion = "Tecnologia"
                        },
                        new
                        {
                            DepartamentoId = 2,
                            Descripcion = "Ferreteria"
                        });
                });

            modelBuilder.Entity("Prueba_Parcial.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArticuloId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Precio")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("PedidoId");

                    b.ToTable("Pedido");

                    b.HasData(
                        new
                        {
                            PedidoId = 1,
                            ArticuloId = 1,
                            Cantidad = 1,
                            Fecha = new DateTime(2020, 10, 25, 10, 23, 0, 358, DateTimeKind.Local).AddTicks(8320),
                            Precio = 1m,
                            Total = 10m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
