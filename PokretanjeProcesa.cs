using System;
using System.Collections.Generic;
using PapaBob.Domain;
using PapaBob.Persistance;
using PapaBob.Presentation;

namespace PapaBob
{
	public class PokretanjeProcesa
	{
		private KreiranjePizze _pocetnoKreiranje;
		private Porudzbina _porudzbina;
		private PrikaziPorudzbinu prikaz = new PrikaziPorudzbinu();

		
		public PokretanjeProcesa()
		{
			_pocetnoKreiranje = new KreiranjePizze();
			if (_pocetnoKreiranje.PotvrdaKreiranja() == false) return;

			prikaziPizze();

			if (potvrdaPorudzbine() == false)
				return;

			PizzaContext db = new PizzaContext();

			KreirajPorudzbinu(_pocetnoKreiranje.GotovePizze());

			db.Porudzbine.Add(_porudzbina);
			db.SaveChanges();
			Console.Clear();
			prikaz.Prikaz(_porudzbina.PorudzbinaId);
			Console.WriteLine("\nPritisnite enter za povratak na pocetnu stranu...");
			Console.ReadLine();
		}

		private void prikaziPizze()
		{
			Console.Clear();
			Console.WriteLine("Vasa porudzbina: \n\n");
			foreach (Pizza element in _pocetnoKreiranje.GotovePizze())
			{
				Console.WriteLine(element.KonacnaPizza());
			}
			Console.WriteLine("\nKonacna cena porudzbine {0:C}",_pocetnoKreiranje.Cena());
		}

		private bool potvrdaPorudzbine()
		{
			Console.WriteLine("\nDa PONISTITE porudzbinu ukucajte ---> \"1\"\nDa potvrdite porudzbinu ukucajte bilo sta drugo...");
			string odgovor = Console.ReadLine();
			if (odgovor == "1")
				return false;
			else return true;
		}

		private void KreirajPorudzbinu(List<Pizza> pizzeZaDodati)
		{
			_porudzbina = new Porudzbina();
			_porudzbina.KreirajPorucioca();

			foreach (Pizza element in pizzeZaDodati)
			{
				_porudzbina.Pizze.Add(new PorucenaPizza(){
						Velicina = element.Velicina(), Kora = element.Kora(), Zacini = imaLiDodataka(element), Cena = element.Cena()});
				
				_porudzbina.Cena += element.Cena();
			}
		}

		private string imaLiDodataka(Pizza pizza)
		{
			if (pizza.Dodaci().Trim().Replace(" ","") == "")
					return "BEZ DODATAKA";
			else return pizza.Dodaci();
		}
	}
}
