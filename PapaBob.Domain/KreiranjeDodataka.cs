using System;
using System.Collections.Generic;
using System.Linq;
using PapaBob.Presentation;

namespace PapaBob.Domain
{
	public class KreiranjeDodataka
	{
		private List<Dodatak> _dodaci { get; set; } 
		private	double _cena;
		private bool _potvrdaKreiranja;

		public KreiranjeDodataka()
		{
			_dodaci = new List<Dodatak>();
			kreiranjeDodataka();
			kreiranjePopusta();
		}	

		public double Cena()
		{
			double cena = _cena;
			return cena;
		}

		public bool PotvrdaKreiranja()
		{
			bool potvrda = _potvrdaKreiranja;
			return potvrda;
		}

		public List<Dodatak> Dodaci()
		{
			return _dodaci;
		}

		private void kreiranjePopusta()
		{
			if ((_dodaci.Any(p => p.Ime() == "Pepperoni")
						&& _dodaci.Any(p => p.Ime() == "Green Peppers") 
						&& _dodaci.Any(p => p.Ime() == "Anchovies"))
					||
			(_dodaci.Any(p => p.Ime() == "Pepperoni")
						&& _dodaci.Any(p => p.Ime() == "Red Peppers") 
						&& _dodaci.Any(p => p.Ime() == "Onion")))
			{
				_cena = _cena - 2;
				double zaStanje = -2;
				Stanje.setPopust(zaStanje);
			}
		}

		private void kreiranjeDodataka()
		{
			bool dKreiranjeUtoku = true;

			while (dKreiranjeUtoku)
			{
				Dodatak dodatak = new Dodatak();
				
				if (dodatak.PotvrdaKreiranja() == false)
				{
					_potvrdaKreiranja = false;
					return;
				}


				else if(dodatak.PrekinutUnos() == true)
				{
					return;
				}

				if (!_dodaci.Any(p => p.Ime() == dodatak.Ime()) && dodatak.Brisanje() != true) 
				{
					Console.WriteLine("dodavanje");
					_dodaci.Add(dodatak);
					_potvrdaKreiranja = dodatak.PotvrdaKreiranja();

					Stanje.setDodatakStanje(dodatak.Ime(),dodatak.Cena());
					
					
					_cena += dodatak.Cena();
					Console.Clear();
					Stanje.getStanje();
				}

				else if (dodatak.Brisanje() == true && _dodaci.Any())
				{
					brisanjeDodataka();
				}
				

					
				/*else 
				{
					Console.Clear();
					Stanje.getStanje();
					Console.WriteLine("Dodatak je vec unet!");
					Console.WriteLine( "vas dodatak" + dodatak.Ime());
				}
				*/

				/*if (_dodaci.Count < 5)
				{
					
					Console.WriteLine("\nZelite li novi dodatak?    da     ne");
					string odgovor = Console.ReadLine().Trim().ToLower();
					if (odgovor != "da")
						dKreiranjeUtoku = false;
				}
				*/
			}

			
		}
		
		public void brisanjeDodataka()
			{
				while(true)
				{
				Console.Clear();
				Stanje.getStanje();
				Console.WriteLine();

				int i = 0;
				foreach (Dodatak element in _dodaci)
				{

					Console.WriteLine( i + ")da izbrisete: " + element.Ime() +   " ukucajte broj-----> " + i);
					i++;
				}
				Console.WriteLine("\n" + i + ")da zavrsite sa brisanjem dodataka ukucajte ----->  *");
				int mojIndex = 0;

				string mojaVrednost = Console.ReadLine();
				if (int.TryParse(mojaVrednost,out mojIndex))
				{
					if (_dodaci.Any(p => _dodaci.IndexOf(p) == mojIndex))
					{
						Stanje.deleteDodatak(_dodaci.ElementAt(mojIndex).Ime(), _dodaci.ElementAt(mojIndex).Cena());
						_cena -= _dodaci.ElementAt(mojIndex).Cena();
						_dodaci.Remove(_dodaci.ElementAt(mojIndex));
					}
				}

				else if(mojaVrednost == "*") 
				{
					return;
				}

				}
			}


	}

}
