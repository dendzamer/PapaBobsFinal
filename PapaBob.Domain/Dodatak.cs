using System;
using PapaBob.Presentation;

namespace PapaBob.Domain 

{
	public class Dodatak
	{
		private string _ime;
		private double _cena;
		private bool _potvrdaKreiranja = true;
		private bool _kreiranjeUtoku = true;
		private string neispravanUnos = "";
		private bool _prekinutUnos = false;
		private bool _brisanje = false;


		public Dodatak()
		{
			kreiranjeUnosa();

		}

		public bool PrekinutUnos()
		{
			return _prekinutUnos;
		}
		private void kreiranjeUnosa()
		{
			while (_kreiranjeUtoku == true)
			{
				Console.Clear();
				Stanje.getStanje();
				
				Opcije.OpcijeDodatak();

				Console.WriteLine(neispravanUnos);

				string opcija = Console.ReadLine().ToLower().Trim().Replace(" ", "");

				switchOpcije(opcija);

			}
		}

		private void switchOpcije(string unos)
		{
			switch (unos)
			{ 
				case "pepperoni": 
				case "1":
					zaSwitch(1.5, "Pepperoni");
					break;

				case "onions": 
				case "2":
					zaSwitch(0.75, "Onions");
					break;

				case "greenpeppers": 
				case "3":
					zaSwitch(0.50, "Green Peppers");
					break;

				case "redpeppers":
				case "4":
					zaSwitch(0.75, "Red Peppers");
					break;

				case "anchovies":
				case "5":
					zaSwitch(2, "Anchovies");
					break;

				case "6":
				case "zavrsi":
					_potvrdaKreiranja = true;
					_prekinutUnos = true;
					_kreiranjeUtoku = false;
					break;

				case "7":
				case "napusti":
					_potvrdaKreiranja = false;
					_kreiranjeUtoku = false;
					break;
				case "8":
				case "izbrisi":
					_kreiranjeUtoku = false;
					_brisanje = true;
					Console.WriteLine("uspesno");
					break;

				default:
					neispravanUnos = "Neispravan unos.. probajte ponovo...";
					_kreiranjeUtoku = true;
					break;
			}
		}

		public bool Brisanje()
		{
			return _brisanje;
		}
		private void zaSwitch(double cena, string ime)
		{
			_ime = ime;
			_cena = cena;
			_kreiranjeUtoku = false;
			_potvrdaKreiranja = true;
		}

		public string Ime()
		{
			string ime = _ime;
			return ime;
		}

		public double Cena()
		{
			double cena = _cena;
			return cena;
		}	
	
		public bool PotvrdaKreiranja()
		{
			bool potvrdaKreiranja = _potvrdaKreiranja;
			return potvrdaKreiranja;
		}

	}
}

