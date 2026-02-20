namespace UveghazP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adattar adattar = new Adattar();
			adattar.Ujnoveny(new Novenyfaj("Uborka", 5));
			adattar.Ujnoveny(new Novenyfaj("Sárgarépa", 6));
			adattar.Ujnoveny(new Novenyfaj("Burgonya", 4));
			adattar.Ujnoveny(new Novenyfaj("Hagyma", 7));
			adattar.Ujnoveny(new Novenyfaj("fokhagyma", 8));
			adattar.Ujnoveny(new Novenyfaj("Saláta", 5));
			adattar.Ujnoveny(new Novenyfaj("Kukorica", 3));
			adattar.Ujnoveny(new Novenyfaj("Borsó", 6));
			adattar.Ujnoveny(new Novenyfaj("Bab", 5));
			adattar.Ujnoveny(new Novenyfaj("Káposzta", 4));
			adattar.Ujnoveny(new Novenyfaj("Karfiol", 4));
			adattar.Ujnoveny(new Novenyfaj("Brokkoli", 4));
			adattar.Ujnoveny(new Novenyfaj("Cukkini", 5));
			adattar.Ujnoveny(new Novenyfaj("Spenót", 7));

			adattar.Novenyeklistazasa();
		}
    }
}
