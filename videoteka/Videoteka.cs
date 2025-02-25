using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoteka
{
	internal class Videoteka
	{
		public List<Film> Filmek {  get; private set; }
		public List<Felhasznalo> Felhasznalok { get; private set; }
		public Videoteka()
		{
			Filmek = new List<Film>();
			Felhasznalok = new List<Felhasznalo>();
		}
		public void Filmhozzaadas(Film film)
		{
			Filmek.Add(film);
            Console.WriteLine("Sikeren Hozzáadta a filmet!");

        }
		public void FelhasznaloHozzaadas(Felhasznalo felhasznalo) {
			Felhasznalok.Add(felhasznalo);
            Console.WriteLine("Felhasználó sikeresen felvéve!");

        }
		public Film KeresFilm(string cim)
		{
			foreach (var film in Filmek) 
				{
				if (film.Cim == cim)
				{
					Console.WriteLine("Film megtalálva!");
					return film;
					
				}
				else 
				{ Console.WriteLine("Nincs ilyen film!");
					return null;
				}
				}
			return null; 
		}
		public Felhasznalo KeresFelhasznalo(string nev) {
			foreach (var film in Felhasznalok)
			{
				if (film.Nev == nev)
				{
					Console.WriteLine("Film megtalálva!");
					return film;

				}
				else
				{
					Console.WriteLine("Nincs ilyen film!");
					return null;
				}
			}
			return null;
		}
	}
}
