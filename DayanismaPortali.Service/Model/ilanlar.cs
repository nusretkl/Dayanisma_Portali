using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayanismaPortali.Service.Model
{
	public class ilanlar
	{
		public int Id { get; set; }
		public int VakifId { get; set; }
		public string Adres { get; set; }
		public string Konu { get; set; }
		public string Aciklama { get; set; }
		public DateTime Tarih { get; set; }
		public string Saat { get; set; }

	}
}
