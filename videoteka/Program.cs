namespace videoteka
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Film titanic = new Film("Titanic","idk",1997);
			Film inception = new Film("Inception","idk",2010);
			Film interstellar = new Film("Interstellar","idk",2014);
			Felhasznalo anna = new Felhasznalo("Anna");
			
			Videoteka anyad = new Videoteka();
			anyad.Filmhozzaadas(titanic);
			anyad.Filmhozzaadas(inception);
			anyad.Filmhozzaadas(interstellar);
			anyad.FelhasznaloHozzaadas(anna);
			string genyo = "Titanic";
			anyad.KeresFilm(genyo);
			anna.Kolcsonoz(titanic);
			anna.Kolcsonoz(anyad.KeresFilm("Titanic"));



		}
	}
}
