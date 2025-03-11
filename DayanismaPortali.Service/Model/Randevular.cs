using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayanismaPortali.Service.Model
{
	public class Randevular
	{
		public int ID { get; set; }
		public int? Kullanici_ID { get; set; }
		public int? Vakif_ID { get; set; }
		public int? ilan_ID { get; set; }
		public DateTime Tarih {  get; set; }
		public string Aciklama { get; set; }
		public bool Yapildi_mi {  get; set; }

		public ilanlar ilan { get; set; }
		public Kullanicilar kullanici { get; set; }
		public Vakiflar vakif { get; set; }

	}
}
