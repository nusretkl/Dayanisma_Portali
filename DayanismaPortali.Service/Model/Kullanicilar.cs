using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayanismaPortali.Service.Model
{
	public class Kullanicilar
	{
		public int ID { get; set; }
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public string Mail { get; set; }
		public string Telefon { get; set; }
		public string Sifre { get; set; }
		public string Cinsiyet { get; set; }
		public int? ilId { get; set; }
		public string? Puan { get; set; }


		public iller il { get; set; }

		public List<Randevular> Randevu { get; set; }

	}
}
