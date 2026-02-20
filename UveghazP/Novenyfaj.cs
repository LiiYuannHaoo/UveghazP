using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UveghazP
{
	internal class Novenyfaj
	{
		string nev;
		int nedvessegtartalom; //100 ideális
		int egeszsegszint; //100 max, 60 jajj jajj
		int optimalissuruseg;

		public Novenyfaj(string nev, int optimalissuruseg)
		{
			this.nev = nev;
			this.optimalissuruseg = optimalissuruseg;
			this.nedvessegtartalom = 100;
			this.egeszsegszint = 100;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Nedvessegtartalom { get => nedvessegtartalom; set => nedvessegtartalom = value; }
		public int Egeszsegszint { get => egeszsegszint; set => egeszsegszint = value; }
		public int Optimalissuruseg { get => optimalissuruseg; set => optimalissuruseg = value; }
	
		public string Azonosito
		{
			get
			{
				return this.nev.Substring(0, 3);
			}
		}

		public override bool Equals(object obj)
		{
			obj = obj as Novenyfaj;
			if(this.nev == ((Novenyfaj)(obj)).nev)
			{
				return true;
			}
			return false;
		}


		public override string ToString()
		{
			return $"{this.nev} - Nedvességtartalom: {this.nedvessegtartalom}%, Egészségszint: {this.egeszsegszint}% ideális egyeds  {this.optimalissuruseg}%)";
		}
	} 
}
