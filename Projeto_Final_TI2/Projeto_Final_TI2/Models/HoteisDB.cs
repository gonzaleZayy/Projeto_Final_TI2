using System;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projeto_Final_TI2.Models
{
    public class HoteisDB : DbContext
    {
        public HoteisDB() : base("HoteisConnectionString") { }
        //descrever os nomes detalhados na base de dados
        public virtual DbSet<Hoteis> Hoteis { get; set; } // tabela Hoteis
        public virtual DbSet<Quartos> Quartos { get; set; } // tabela Quartos
        public virtual DbSet<Fotos> Fotos { get; set; } // tabela Fotos
        public virtual DbSet<Clientes> Clientes { get; set; } // tabela Clientes
        public virtual DbSet<Reservas> Reservas { get; set; } // tabela Reservas


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
