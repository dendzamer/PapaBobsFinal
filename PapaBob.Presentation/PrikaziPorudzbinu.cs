using System;
using System.Collections.Generic;
using System.Linq;
using PapaBob.Persistance;

namespace PapaBob.Presentation
{
	public class PrikaziPorudzbinu
	{
		private PizzaContext db = new PizzaContext();
		private Porudzbina porudzbina = new Porudzbina();

		public void Prikaz(int idPorudzbine)
		{
			porudzbina = db.Porudzbine.Find(idPorudzbine);

				Console.WriteLine("\nBroj porudzbine: {0}\n\nNarucilac: {1}\nTelefon: {2}\nAdressa: {3}\nDatum: {4}", porudzbina.PorudzbinaId, porudzbina.PorucilacIme, porudzbina.Telefon, porudzbina.Adressa, porudzbina.Datum);

				Console.WriteLine();
			foreach (PorucenaPizza element in db.Pizze.Where(p => p.PorudzbinaId == idPorudzbine))
			{
				Console.WriteLine("{0} --- {1} --- {2} --- {3:C}", element.Velicina, element.Kora, element.Zacini, element.Cena);
			}

			Console.WriteLine("\nUkupno za uplatu: {0:C}", porudzbina.Cena);
			Console.WriteLine("------------------------------------------------");




		}
	}
}
