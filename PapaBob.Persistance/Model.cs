using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace PapaBob.Persistance
{
	public class PizzaContext : DbContext
	{
		public DbSet<Porudzbina> Porudzbine {get; set; }
		public DbSet<PorucenaPizza> Pizze {get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite("Data Source=./pizze.db");
	}
}
