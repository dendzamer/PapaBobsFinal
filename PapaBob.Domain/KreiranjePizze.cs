using System;
using System.Collections.Generic;
using System.Linq;
using PapaBob.Presentation;

namespace PapaBob.Domain
{
	class KreiranjePizze
	{
		private List<Pizza> _kreiranePizze;
		private bool _kreiranjeUtoku = true;
		private bool _potvrdaKreiranja;
		private double _ukupnaCena;

		public KreiranjePizze()
		{
			_kreiranePizze = new List<Pizza>();
			dodajPizzu();
		}

		private void dodajPizzu()
		{
			while (_kreiranjeUtoku == true)
			{

				kreirajPizzu();
				if (_potvrdaKreiranja == false) return;

				Console.Clear();
				Stanje.getStanje();
				Opcije.ZeliteLiPizzu();

				string odgovor = Console.ReadLine().Trim().Replace(" ", "");
				if(odgovor != "da") _kreiranjeUtoku = false;
			}
		}

		private void kreirajPizzu()
		{
				Pizza pizza = new Pizza();
				_potvrdaKreiranja = pizza.PotvrdaKreiranja();
				if (_potvrdaKreiranja == false) return;
				else 
				{
					_kreiranePizze.Add(pizza);
					_ukupnaCena += pizza.Cena();
				}
		}

		public bool PotvrdaKreiranja()
		{
			return _potvrdaKreiranja;
		}

		public List<Pizza> GotovePizze()
		{
			return _kreiranePizze;
		}

		public double Cena()
		{
			return _ukupnaCena;
		}
	}
}
