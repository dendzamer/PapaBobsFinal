using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace PapaBob.Persistance
{
	public class Porudzbina
	{
		public int PorudzbinaId {get; set;}
		public string PorucilacIme {get; set;}
		public string Adressa {get; set;}
		public string Telefon {get; set;}
		public double Cena {get; set;}
		public string Datum {get; set;}

		public List<PorucenaPizza> Pizze {get;} = new List<PorucenaPizza>();

		public Porudzbina()
		{

		}

		public void KreirajPorucioca()
		{
			setuj("ime");
			setuj("adresu");
			setuj("broj telefona");
			setuj("datum");

			zeliteLiIspravku();

		}

		private void setuj( string sta)
		{
			Console.Clear();
			Console.WriteLine("Ime: {0}\nAdresa: {1}\nTelefon: {2}\nDatum: {3}", PorucilacIme, Adressa, Telefon, Datum);
			Console.WriteLine("\nUkucajte {0} narucioca i pritisnite Enter: ", sta);
			odrediVariablu(sta);
		}

		private void odrediVariablu(string zaOdrediti)
		{
			DateTime dt = DateTime.Now; 
			if (zaOdrediti == "ime")
				PorucilacIme = Console.ReadLine();
			else if (zaOdrediti == "adresu")
				Adressa = Console.ReadLine();
			else if(zaOdrediti == "datum")
				Datum = dt.ToString(); 
			else Telefon = Console.ReadLine();
		}

		private void zeliteLiIspravku()
		{
			bool ispravljanjeUtoku = true;

			while (ispravljanjeUtoku == true)
			{
				Console.Clear();
				Console.WriteLine("Ime: {0}\nAdresa: {1}\nTelefon: {2}\nDatum: {3}", PorucilacIme, Adressa, Telefon, Datum);
				Console.WriteLine("\n\nZelite li ispravku?\n\n1) Za da ukucajte ------> \"da\"\n2) Da potvrdite podatke ukucajte bilo sta drugo...");
				if(Console.ReadLine() == "da")
					odrediObaviIspravku();
				else ispravljanjeUtoku = false;
			}
			
		}

		private void odrediObaviIspravku()
		{
			Console.Clear();
			Console.WriteLine("Ime: {0}\nAdresa: {1}\nTelefon: {2}", PorucilacIme, Adressa, Telefon);
			Console.WriteLine("\n\n1) Da ponovo ukucate ime ukucajte -----> \"1\"\n2) Da ispravite adresu ukucajte -----> \"2\"\n3) Da ispravite broj telefona ukucajte -----> \"3\"\n4) Da neispravite nista ukucajte bilo sta...");

			string odgovor = Console.ReadLine();

			if (odgovor == "1")
				setuj("ime");
			else if (odgovor == "2")
				setuj("adresu");
			else if (odgovor == "3")
				setuj("broj telefona");
			else return;
		}


	}
	
}
