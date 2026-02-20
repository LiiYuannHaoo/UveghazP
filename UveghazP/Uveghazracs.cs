using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UveghazP
{
	internal class Uveghazracs
	{
		Random r =  new Random();

		int meret;
		Cella[,] agyasok;

		public Uveghazracs(int meret)
		{
			this.meret = meret;
			this.agyasok = new Cella[meret, meret];
		}
		public void Parcellazas()
		{
			for (int i = 0; i < this.meret; i++) //sorok
			{
				for (int j = 0; j < this.meret; j++) //oszlopok
				{
					agyasok[i, j] = new Cella(i, j);
				}
			}
		}

		public void  Ultetes(List<Novenyfaj>novenyek)
		{
			int index = 0;
			for (int i = 0; i < this.meret; i++) //sorok
			{
				for (int j = 0; j < this.meret; j++) //oszlopok
				{
					if(index<novenyek.Count)
					agyasok[i, j].Telepit(novenyek[index++], r.Next(-1,15));
				}
			}
		}

		public void Matrixkiir()
		{
			for (int i = 0; i < meret; i++) //sorok
			{
				Console.WriteLine("-------------------------------------------------------------");
				for (int j = 0; j < meret; j++) //oszlopok
				{
					Console.WriteLine(agyasok[i,j]+"\t"); ;
				}
				Console.WriteLine();
				Console.WriteLine("-------------------------------------------------------------");
			}
		}
	}
}
