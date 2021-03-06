using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	[Serializable()]
	public class Ukoly
		//Deklarace třídy Úkolů, se kterými se bude pracovat.
	{
		public string NazevUkolu { get; set; }
		public string TypUkolu { get; set; }
		public int Den { get; set;}
		public int Mesic { get; set; }
		public int Rok { get; set; }
		public int Hodina { get; set; }
		public int Minuta { get; set; }
		public Ukoly(string nazevUkolu, string typUkolu, int den, int mesic, int rok, int hodina, int minuta)
		{
			NazevUkolu = nazevUkolu;

			TypUkolu = typUkolu;
			Den = den;
			Mesic = mesic;
			Rok = rok;
			Hodina = hodina;
			Minuta = minuta;
		}
	}
}
