using System;
using Microsoft.EntityFrameworkCore;
using Prueba_Parcial.Models;

namespace Prueba_Parcial.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\parcial.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Crear Departamentos directos en la base de datos
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoId = 1, Descripcion = "Tecnologia" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoId = 2, Descripcion = "Ferreteria" });

            //Crear Articulos directos en la base de datos
            modelBuilder.Entity<Articulo>().HasData(new Articulo {ArticuloId = 1, DepartamentoId = 1, Referencia = "Tecn", Descripcion = "Iphone 2g", Precio = 4000, Existencia = 2, Departamento = "Tecnologia"} );
            modelBuilder.Entity<Articulo>().HasData(new Articulo {ArticuloId = 2, DepartamentoId = 1, Referencia = "Tecn", Descripcion = "Iphone 3g", Precio = 5000, Existencia = 3, Departamento = "Tecnologia"} );

            modelBuilder.Entity<Articulo>().HasData(new Articulo {ArticuloId = 3, DepartamentoId = 2, Referencia = "Tool", Descripcion = "Tornillo Grande", Precio = 15, Existencia = 100, Departamento = "Ferreteria"} );
            
            //Pedidos
            modelBuilder.Entity<Pedido>().HasData(new Pedido {PedidoId = 1, Fecha = DateTime.Now, ArticuloId = 1, Cantidad = 1, Precio = 1, Total = 10});
        }
    }
}