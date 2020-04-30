using ControleVeicular.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleVeicular
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasKey(t => t.Id);
            
            modelBuilder.Entity<Anuncio>().HasKey(a => a.Id);
            modelBuilder.Entity<Anuncio>().HasOne(a => a.Marca);
            modelBuilder.Entity<Anuncio>().HasOne(a => a.Modelo);
           
            modelBuilder.Entity<Marca>().HasKey(t => t.Id);

            modelBuilder.Entity<Modelo>().HasKey(t => t.Id);


        }
    }
}
