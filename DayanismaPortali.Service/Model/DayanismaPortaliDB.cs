using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayanismaPortali.Service.Model
{
	public class DayanismaPortaliDB : DbContext
	{
		public DbSet<iller> il { get; set; }
		public DbSet<Kullanicilar> Kullanici { get; set; }
		public DbSet<Vakiflar> Vakif { get; set; }
		public DbSet<Randevular> Randevu { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=LAPTOP-GGMIOG7S\\MSSQL;Database=DayanismaPortaliDB;Trusted_Connection=True;TrustServerCertificate=True");
		}

	}
}
