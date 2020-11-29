using System;
using System.Collections.Generic;
using System.Linq;
using PapaBob.Persistance;

namespace PapaBob.Presentation
{
	public class Pretraga
	{
		private PizzaContext db = new PizzaContext();
                private string _odgovor;
                private bool pretragaUtoku = true;
		private PrikaziPorudzbinu prikaz = new PrikaziPorudzbinu();
		private List<Porudzbina> _porudzbine = new List<Porudzbina>();

		public void IdPretraga()
		{
			while(pretragaUtoku == true)
                        {
				
                                Console.WriteLine("\nDa se vratite na prethodnu stranicu ukucajte rec ---> povratak\nUkucajte broj porudzbine koju zelite da pretrazite:");

                                int brojPorudzbine = 0;

                                _odgovor = Console.ReadLine().Trim().Replace(" ","");

				Console.Clear();

                                if (_odgovor == "povratak") return;

                                bool konvertovanje = int.TryParse(_odgovor, out brojPorudzbine);

                                if (konvertovanje)
                                {
                                        obaviIdPretragu(brojPorudzbine);
                                }

                                else
                                        Console.WriteLine("Neispravan unos... probajte opet...");
                        }

		}
		private void obaviIdPretragu(int idBroj)
		{
			if(db.Porudzbine.Any(p => p.PorudzbinaId == idBroj))
					prikaz.Prikaz(idBroj);
			else Console.WriteLine("Ne postoji porudzbina sa tim brojem... ");
		}

		public void ImePretraga()
		{
		
			while(pretragaUtoku == true)
			{

				Console.WriteLine("\nDa se vratite na prethodnu stranicu ukucajte rec ---> povratak\nUkucajte ime narucioca porudzbine koju zelite da pretrazite:");

				_odgovor = Console.ReadLine().Trim().ToLower();

				Console.Clear();

				if (_odgovor == "povratak") return;

				
				_porudzbine = db.Porudzbine.ToList();
				foreach(Porudzbina element in _porudzbine)
				{
					element.PorucilacIme = element.PorucilacIme.ToLower();
				}

				
				if (_odgovor == "")
					Console.WriteLine("neispravan unos...");
				else if (_porudzbine.Any(p => p.PorucilacIme.Contains(_odgovor)))
				{
					foreach(Porudzbina element in _porudzbine.Where(p => p.PorucilacIme.Contains(_odgovor)))	
					{
						prikaz.Prikaz(element.PorudzbinaId);
					}
				}	

				else 
					Console.WriteLine("Ne postoji porudzbina sa tim imenom narucioca...");

			}
		}

		public void Telefon()
		{
			while(pretragaUtoku == true)
			{

				Console.WriteLine("\nDa se vratite na prethodnu stranicu ukucajte rec ---> povratak\nUkucajte broj telefona narucioca porudzbine koju zelite da pretrazite:");

				_odgovor = Console.ReadLine().Trim();

				Console.Clear();

				if (_odgovor == "povratak") return;

				_porudzbine = db.Porudzbine.ToList();

				if (_odgovor == "")
					Console.WriteLine("neispravan unos...");
				else if (_porudzbine.Any(p => p.Telefon.Contains(_odgovor)))
				{
					foreach(Porudzbina element in _porudzbine.Where(p => p.Telefon.Contains(_odgovor)))	
					{
						prikaz.Prikaz(element.PorudzbinaId);
					}
				}	

				else 
					Console.WriteLine("Ne postoji porudzbina sa tim brojem telefona narucioca...");

			}
		}

		public void SviUnosi()
		{
			foreach(Porudzbina element in db.Porudzbine)
			{
				prikaz.Prikaz(element.PorudzbinaId);
			}
			Console.WriteLine("Pritisnite enter za povratak na prethodnu stranicu...");
			Console.ReadLine();
		}


	}
}
