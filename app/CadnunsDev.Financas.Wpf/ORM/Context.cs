using CadnunsDev.Financas.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadnunsDev.Financas.Wpf.ORM
{
    public class Context : DbContext
    {
        public Context()
            : base("FinancasDb")
        {
            Database.ExecuteSqlCommand(@"CREATE TABLE if not exists `Anotacoes` (
	`Id`	INTEGER,
	`Texto`	TEXT,
	PRIMARY KEY(Id)
)");
        }

        public DbSet<Anotacao> Anotacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anotacao>().ToTable("Anotacoes");
            base.OnModelCreating(modelBuilder);
        }
    }
}
