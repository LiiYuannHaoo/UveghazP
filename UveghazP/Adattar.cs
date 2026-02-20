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
		List<Novenyfaj> novenyek;
		public Adattar()
		{
			novenyek = new List<Novenyfaj>();
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

	}
}
