using System;
using PapaBob.Presentation;

namespace PapaBob.Domain
{
	public class Size
	{
		private string _ime = "";
		private double _cena;
		private double _cenaPrivremeno = 0.0;
		private bool _potvrdaKreiranja;
		private bool _kreiranjeUtoku = true;
		private string neispravanUnos = "";

		public Size()
		{
			kreiranjeUnosa();
		}

		private void kreiranjeUnosa()
		{
			while (_kreiranjeUtoku == true)
			{
				Console.Clear();
				Stanje.getStanje();

				Opcije.OpcijeVelicine();

				Console.WriteLine(neispravanUnos);

				string opcija = Console.ReadLine().ToLower().Trim().Replace(" ", "");

				switchOpcije(opcija);

			}
			_cena = _cenaPrivremeno;
		}

		private void switchOpcije(string unos)
		{
			switch (unos)
			{ 
				case "papabob": 
				case "1":
					zaSwitch(16, "Papa Bob");
					break;

				case "mamabob": 
				case "2":
					zaSwitch(13, "Mama Bob");
					break;

				case "babybob": 
				case "3":
					zaSwitch(10, "Baby Bob");
					break;

				case "4":
				case "napusti":
					_potvrdaKreiranja = false;
					_kreiranjeUtoku = false;
					break;

				case "potvrdi":
				case "5":
					imaLiUnosa();
					break;

				default:
					neispravanUnos = "Neispravan unos.. probajte ponovo...";
					_kreiranjeUtoku = true;
					break;
			}
		}

		private void imaLiUnosa()
		{
			if(_ime != "")
			_kreiranjeUtoku = false;
		}

		private void zaSwitch(double cena, string ime)
		{
			Stanje.setVelicina(ime);
			Stanje.setCena(cena, _cenaPrivremeno);
			_ime = ime;
			_cenaPrivremeno = cena;	
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
