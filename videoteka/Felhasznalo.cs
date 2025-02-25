using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoteka
{
	internal class Felhasznalo
	{
		public string Nev { get; private set; }
		public List<Film> KikolcsonzottFilmek { get; private set; }

		public Felhasznalo(string nev) { Nev = nev; }

		public bool Kolcsonoz(Film film)
		{
			if (KikolcsonzottFilmek.Count >= 3)
			{
				Console.WriteLine("Túl sokat kölcsönöztek!");
				return false;

			}
			if (film.Kolcsonozve == false)
			{
				{
					Console.WriteLine("Kikölcsönzés megadva!");
					KikolcsonzottFilmek.Add(film);
					return true;
				}
			}
			else
			{
				Console.WriteLine("A kolcsonzes nem lehetseges");
				return false;
			}
		}
		public bool Visszaad(Film film)
		{
			if (film.Kolcsonozve != false && KikolcsonzottFilmek.Contains(film) == true )
			{
				KikolcsonzottFilmek.Remove(film);
				film.Kolcsonozve = false; 
				return true;
				
			} else {
                Console.WriteLine("Nem sikerült a kölcsönzés!");
                return false; }
		}
	}
}
