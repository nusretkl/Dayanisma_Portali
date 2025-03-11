using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayanismaPortali.Service.Model
{
	public class Vakiflar
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int? il_ID { get; set; }
		public string Adres { get; set; }
		public string Sifre { get; set; }	


		public iller il { get; set; }
		public List<Randevular> Randevu { get; set; }

	}
}
