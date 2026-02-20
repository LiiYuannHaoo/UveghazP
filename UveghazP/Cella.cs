using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UveghazP
{
	internal class Cella
	{
		Pozicio pozicio;
		Novenyfaj novenyfaj;
		int egyedszam;
		List<Szenzor> szenzorok;
		List<Riasztas> riasztasok;

		public Cella(int x, int y)
		{
			this.Pozicio = new Pozicio(x, y);
			this.Novenyfaj = null;
			this.Egyedszam = 0;
			this.Szenzorok = new List<Szenzor>();
			this.Riasztasok = new List<Riasztas>();
		}

		public int Egyedszam { get => egyedszam; set => egyedszam = value; }
		internal Pozicio Pozicio { get => pozicio; set => pozicio = value; }
		internal Novenyfaj Novenyfaj { get => novenyfaj; set => novenyfaj = value; }
		internal List<Szenzor> Szenzorok { get => szenzorok; set => szenzorok = value; }
		internal List<Riasztas> Riasztasok { get => riasztasok; set => riasztasok = value; }
		public bool Urese
		{
			get
			{
				return this.novenyfaj == null;
			}
		}

		public bool Telepit(Novenyfaj noveny, int mennyiseg)
		{
			bool sikeres = false;
			if (mennyiseg > 0 && Urese)
			{
				this.novenyfaj = noveny;
				this.egyedszam = mennyiseg;
				Console.WriteLine($"{novenyfaj.Nev} telepítése sikeresem megtörtént");
				sikeres = true;
			}
			else if (mennyiseg > 0 && this.novenyfaj.Equals(noveny))
			{
				Noveles(mennyiseg);
			}
			return sikeres;
		}

		public void Noveles(int mennyiseg)
		{
			this.egyedszam += mennyiseg;
		}

		public void Csokkentes(int mennyiseg)
		{
			this.egyedszam -= mennyiseg;
			if (this.egyedszam <= 0)
			{
				Uriste();
			}
		}
		public void Uriste()
		{
			this.novenyfaj = null;
			this.egyedszam = 0;
		}

		public override string ToString()
		{
			if (this.Urese)
			{
				return $"| {"üres",8} |";
			}
			return $"| {this.novenyfaj.Azonosito,3} {this.egyedszam,2}db |";

		}
	}
}
