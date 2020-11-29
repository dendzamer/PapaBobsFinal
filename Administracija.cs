using System;
using System.Collections.Generic;
using PapaBob.Persistance;

namespace PapaBob.Presentation
{
	public class Administracija
	{
		private Pretraga _pretraga;
		private BrisanjePorudzbine _brisanje;
		private bool _pretragaUtoku = true;
		private string _odgovor;

		public Administracija()
		{
			_pretraga = new Pretraga();

			while(_pretragaUtoku == true)
			{
				
				Console.Clear();
				Opcije.OpcijePretrage(); 
				_odgovor = Console.ReadLine();


				SwitchCases(_odgovor);
			}
		}

		private void SwitchCases(string odgovor)
		{
			switch(odgovor)
			{
				case "0":
					_pretraga.SviUnosi();
					break;
				case "1":
					_pretraga.IdPretraga();
					break;
				case "2":
					_pretraga.ImePretraga();
					break;
				case "3":
					_pretraga.Telefon();
					break;
				case "4": 
					_brisanje = new BrisanjePorudzbine();
					break;
				case "5":
					_pretragaUtoku = false;
					break;
				default:
					break;
			}	
		}
	}
}
