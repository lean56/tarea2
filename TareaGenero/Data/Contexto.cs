using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TareaGenero.Entidades;

namespace TareaGenero.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Genero> genero{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=EMIL56\SQLEXPRESS; Database =Cine;Trusted_Connection =true");
        }

    }

   
}
