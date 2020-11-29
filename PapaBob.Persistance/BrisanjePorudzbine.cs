using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PapaBob.Presentation;

namespace PapaBob.Persistance
{
	public class BrisanjePorudzbine
	{
		private PizzaContext db = new PizzaContext();
		private string _odgovor;
		private bool brisanjeUtoku = true;
		Porudzbina porudzbina;

		public BrisanjePorudzbine()
		{
			while(brisanjeUtoku == true)
			{
				Console.WriteLine("\nDa se vratite na prethodnu stranicu ukucajte rec ---> povratak\nUkucajte broj porudzbine koju zelite da izbrisete:");

				int brojPorudzbine = 0;

				_odgovor = Console.ReadLine().Trim().Replace(" ","");
				if (_odgovor == "povratak") return;

				bool konvertovanje = int.TryParse(_odgovor, out brojPorudzbine);

				if (konvertovanje)
				{
					izbrisiPorudzbinu(brojPorudzbine);
				}

				else
					Console.WriteLine("Neispravan unos... probajte opet...");
			}
		}

		private void izbrisiPorudzbinu(int brojZaBrisanje)
		{
			if (db.Porudzbine.Any(p => p.PorudzbinaId == brojZaBrisanje))
			{
				//melementehanizam za prikazivanje date porudzbine. Klasa db ne izbacuje kompletnu klasu vec samo stringove. Potrebno je napraviti klasu u PapaBob.Presentation koja ce vrsiti prikaz podataka iz baze na osnovu ID broja Porudzbine i pizza.

				PrikaziPorudzbinu prikazi = new PrikaziPorudzbinu();
				prikazi.Prikaz(brojZaBrisanje);



				Console.WriteLine("\nPotvrdjujete brisanje ove porudzbine?\n\n1) Da potvrdite brisanje ukucajte ---> 1\n2)Da odustanete ukucajte bilo sta drugo...");

				string odgovor = Console.ReadLine().Trim().Replace(" ","");
				if (odgovor == "1")
				{
					porudzbina = new Porudzbina();
					porudzbina = db.Porudzbine.Single(p => p.PorudzbinaId == brojZaBrisanje);

					db.Porudzbine.Remove(porudzbina);
					db.SaveChanges();

					Console.Clear();
					brisanjeUtoku = false;
					Console.WriteLine("Porudzbina je izbrisana... pritisnite enter za povratak na prethodnu stranicu...");
					Console.ReadLine();
				}

			}

			else Console.WriteLine("Ne postoji porudzbina sa tim brojem... pokusajte opet");
			
		}
		}

}
