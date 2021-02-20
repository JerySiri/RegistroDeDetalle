using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_Con_Detalle.Entidades;

namespace Registro_Con_Detalle.DAL
{
    class Contexto : DbContext
    {
        public DbSet<OrdenesDetalle> OrdenesDetalle { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Producto> Producto { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = RegistroDetalle.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>().HasData(
                new Producto() { ProductoId = 1, Nombre = "Coca-cola"},
                new Producto() { ProductoId = 2, Nombre = "Oreo"},
                new Producto() { ProductoId = 3, Nombre = "KitKat"},
                new Producto() { ProductoId = 4, Nombre = "Pringles"},
                new Producto() { ProductoId = 5, Nombre = "Snickers"},
                new Producto() { ProductoId = 6, Nombre = "Pepsi"}

            );
        }
    }
}
