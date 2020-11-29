using System;
using System.Collections.Generic;
using System.Linq;
using PapaBob.Presentation;

namespace PapaBob.Domain
{
	public class Pizza
	{
		private Size _size; 
		private Crust _crust;
		private	double _cena;
		private bool _potvrdaKreiranja;
		private string _konacnoStanje;

		private List<Dodatak> _dodaci { get; set; } 

		public Pizza()
		{
			_dodaci = new List<Dodatak>();
			Stanje.nullStanje();


			kreiranjeVelicine();
			if (_potvrdaKreiranja == false) return;
			//Stanje.setStanje(_size.Ime(), _size.Cena());


			kreiranjeKore();
			if (_potvrdaKreiranja == false) return;
			//Stanje.setStanje(_crust.Ime(), _crust.Cena());

			Console.Clear();
			Stanje.getStanje();

			Opcije.ZeliteLiDodatke();
			string odgovor = Console.ReadLine().Replace(" ", "").Trim().ToLower();

			if (odgovor == "da")
			{
				KreiranjeDodataka kreiranjeD = new KreiranjeDodataka();
				_cena += kreiranjeD.Cena();
				_potvrdaKreiranja = kreiranjeD.PotvrdaKreiranja();
				_dodaci = kreiranjeD.Dodaci();
			}
			
			Console.Clear();
			Stanje.getStanje();
			_konacnoStanje = Stanje.getFinalState();

		}

		private void kreiranjeVelicine()
		{		
			_size = new Size();
			_cena += _size.Cena();
			_potvrdaKreiranja = _size.PotvrdaKreiranja();
		}

		private void kreiranjeKore()
		{		
			_crust = new Crust();
			_cena += _crust.Cena();
			_potvrdaKreiranja = _crust.PotvrdaKreiranja();
		}

		public bool PotvrdaKreiranja()
		{
			return _potvrdaKreiranja;
		}

		public string Kora()
		{
			return _crust.Ime();
		}
		public string Velicina()
		{
			return _size.Ime();
		}
		public string Dodaci()
		{
			string prisutniDodaci = "";
			foreach (Dodatak element in _dodaci)
			{
				prisutniDodaci += element.Ime() + " ";
			}

			return prisutniDodaci;
		}
		public double Cena()
		{
			return _cena;
		}

		public string KonacnaPizza()
		{
			return _konacnoStanje; 
		}

	}
}
