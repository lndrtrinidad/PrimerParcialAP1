using Microsoft.EntityFrameworkCore;
using RegistroArticulo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroArticulo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\RegistroArticulo");
        }
    }
}
