using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace UveghazP
{
	internal class Adattar
	{
		List<Kezelo> kezelok;
		List<Novenyfaj> novenyek;
		Uveghazracs uveghaz;

		internal Uveghazracs Uveghaz { get => uveghaz; set => uveghaz = value; }

		public Adattar()
		{
			this.kezelok = new List<Kezelo>() { new Kezelo("Gipsz Jakab", "GJ", Szerepkor.KERTESZ),
											   new Kezelo("Aranka néni", "Ari", Szerepkor.ADMIN)};
			novenyek = new List<Novenyfaj>();
			this.Uveghaz = new Uveghazracs(4);
			Uveghaz.Parcellazas();

		}
		public void Ujnoveny(Novenyfaj noveny)
		{
			novenyek.Add(noveny);
		}
		public void Novenyeklistazasa()
		{
			foreach (var item in novenyek)
			{
				Console.WriteLine(item);
			}
		}

		public void Ultetes()
		{
			int index = 0;
		}
	}
}
