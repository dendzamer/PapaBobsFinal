using System;

namespace PapaBob.Presentation
{
	static public class Stanje
	{
		private static double _cena = 0.0;
		private static string _stanje;
		private static string _velicina;
		private static string _tipKore; 
		private static string _stanjeDodataka;

		public static void getStanje()
		{
			_stanje = String.Format($"Vasa pizza: {_velicina} --- {_tipKore} ---{_stanjeDodataka} --- {_cena:C}");
			Console.WriteLine(_stanje);
		}

		public static void setVelicina(string noviString)
		{
			_velicina = _velicina.Replace(_velicina, noviString);
		}
		
		public static void setKora(string noviString)
		{
			_tipKore = _tipKore.Replace(_tipKore, noviString);
		}

		public static void setCena(double noviDouble, double stariDouble)
		{
			_cena -= stariDouble;
			_cena += noviDouble;
		}

		public static void setDodatakStanje(string noviUnos, double noviDouble)
		{
			if (_stanjeDodataka == " Bez dodataka")
			{
				_stanjeDodataka = _stanjeDodataka.Replace(" Bez dodataka", " " + noviUnos);
				_cena += noviDouble;
			}
			else 
			{
				_stanjeDodataka += " " + noviUnos;
				_cena += noviDouble;
			}
		}
		public static void deleteDodatak(string zaBrisanje, double istoZaBrisanje)
		{

			_stanjeDodataka = _stanjeDodataka.Replace(" " + zaBrisanje, "");
			_cena -= istoZaBrisanje;
			if(_stanjeDodataka == "")
			{
				_stanjeDodataka = " Bez dodataka";
			}

		}
		public static void nullStanje()
		{
			_cena = 0.0;
			_velicina = "Velicina";
			_tipKore = "Tip kore";
			_stanjeDodataka = " Bez dodataka";
			_stanje = String.Format($"Vasa pizza: {_velicina} --- {_tipKore} --- {_stanjeDodataka} --- {_cena}");
		}
		public static void setPopust(double popust)
		{
			_cena += popust;
		}

		public static string getFinalState()
		{
			return _stanje;
		}


		
	}
}
