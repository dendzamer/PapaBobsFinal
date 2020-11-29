using System;
using PapaBob.Presentation;
using PapaBob.Domain;

namespace PapaBob
{
	public class Pokreni
	{
		private bool programUtoku = true;

		public Pokreni()
		{
			
			while(programUtoku == true)
			{
				PocetnaStrana pStrana = new PocetnaStrana();

				Console.WriteLine("\nUkucajte broj zeljene opcije:\n1)Kreiraj i naruci Pizzu ---> ukucaj 1\n2)Administracija ---> ukucaj 2\n3)Napusti program ---> ukucaj 3");
				switchOpcije();
			}


			Console.WriteLine("Hvala na poverenju ---> Papa Bob!!!");

		}

		private void switchOpcije()
		{
			string odgovor = Console.ReadLine();
			switch(odgovor)
			{
				case "1":
					PokretanjeProcesa pokretanje = new PokretanjeProcesa();
					break;
				case "2":
					Administracija administracija = new Administracija();
					break;
				case "3":
					programUtoku = false;
					break;
				default:
					break;
			}
		}
	}
}
