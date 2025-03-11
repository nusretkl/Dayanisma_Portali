using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayanismaPortali.Service.Model
{
	public class iller
	{
		public int ID { get; set; }
		public string Adi { get; set; }
		public List<Kullanicilar> Kullanici { get; set; }
		public List<Vakiflar> Vakif { get; set; }

	}
}
