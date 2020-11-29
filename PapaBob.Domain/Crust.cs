using System;
using PapaBob.Presentation;

namespace PapaBob.Domain
{
	public class Crust
	{
		private string _ime = "";
		private double _cena;
		private double _cenaPrivremeno = 0.0;
		private bool _potvrdaKreiranja;
		private bool _kreiranjeUtoku = true;
		private string neispravanUnos = "";

		public Crust()
		{
			kreiranjeUnosa();
		}

		private void kreiranjeUnosa()
		{

			while (_kreiranjeUtoku == true)
			{

				Console.Clear();
				Stanje.getStanje();

				Opcije.OpcijeCrust();

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
				case "thincrust": 
				case "1":
					zaSwitch(0, "Thin Crust");
					break;

				case "deepdish": 
				case "2":
					zaSwitch(2, "Deep dish");
					break;

				case "3":
				case "napusti":
					_potvrdaKreiranja = false;
					_kreiranjeUtoku = false;
					break;

				case "potvrdi":
				case "4":
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
			Stanje.setKora(ime);
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
