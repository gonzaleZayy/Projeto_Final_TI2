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
        public virtual DbSet<Hoteis> Hoteis { get; set; } // tabela Multas


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
