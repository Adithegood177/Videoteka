using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoteka
{
	internal class Film
	{
		public string Cim {  get; private set; }
		public string Kategoria { get; private set; }
		public int KiadasiEv { get; private set; }
		public bool Kolcsonozve { get;  set; }

		public Film(string cim, string kategoria, int kiadasiev) 
		{ Cim = cim; Kategoria = kategoria; KiadasiEv = kiadasiev;
		}
		public void Kolcsonzes()
		{
			Kolcsonozve = true;
            Console.WriteLine("A filmet sikeresen kikölcsönözték!");
        }
		public void Visszavetel()
		{
			Kolcsonozve = false;
            Console.WriteLine("A filmet sikeresen visszaadtad!");
        }
	}
}
