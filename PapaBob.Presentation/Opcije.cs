using System;

namespace PapaBob.Presentation
{
	static public class Opcije
	{
		static public void OpcijeVelicine()
		{
			Console.WriteLine("\nUkucajte broj ili ime opcije za zeljenu velicinu pizze: ");
			Console.WriteLine("\n1)Papa Bob size ---16\"--- 16$-----> ukucajte broj 1 ili \"Papa bob\"\n2)Mama Bob size ---13\"--- 13$-----> ukucajte broj 2 ili \"Mama bob\"\n3)Baby Bob size ---10\"--- 10$-----> ukucajte broj 3 ili \"Baby bob\"\n\n4)Napusti program-----> ukucajte broj 4 ili \"napusti\"\n5)Potvrdi unos-----> ukucajte broj 5 ili \"potvrdi\"");

		}
		static public void OpcijeCrust()
		{
			Console.WriteLine("\nUkucajte broj ili ime opcije za zeljeni tip kore: ");
			Console.WriteLine("\n1)Thin crust --- 0$-----> ukucajte broj 1 ili \"Thin crust\"\n2)Deep dish --- +2$-----> ukucajte broj 2 ili \"Deep dish\"\n\n3)Napusti program-----> ukucajte broj 3 ili \"napusti\"\n4)Da potvrdite unos-----> ukucajte broj 4 ili \"potvrdi\"");

		}

		static public void OpcijeDodatak()
		{
			Console.WriteLine("\nUkucajte broj ili ime opcije za zeljeni dodatak: ");
			Console.WriteLine("\n1)Pepperoni --- +1.50$-----> ukucajte broj 1 ili \"Pepperoni\"\n2)Onions --- +0.75$-----> ukucajte broj 2 ili \"Onions\"\n3)Green Peppers --- +0.50$-----> ukucajte broj 2 ili \"Green Peppers\"\n4)Red Peppers --- +0.75$-----> ukucajte broj 4 ili \"Red Peppers\"\n5)Anchovies --- +2$-----> ukucajte broj 5 ili \"Anchovies\"\n6)Zavrsi unos dodataka -----> ukucajte broj 6 ili \"zavrsi\"\n\n7)Napusti program-----> ukucajte broj 7 ili \"napusti\"\n8)Brisanje dodatka-----> ukucajte broj 8 ili \"izbrisi\"");
		}

		static public void ZeliteLiDodatke()
		{
			Console.WriteLine("\nZelite li dodatke na pizzu? \n1)da ---> ukucajte \"da\" \n2)ne ---> ukucajte \"ne\" ili bilo sta drugo");
		}

		static public void ZeliteLiPizzu()
		{

			Console.WriteLine("\nZelite li jos jednu pizzu? \n1)da ---> ukucajte \"da\" \n2)ne ---> ukucajte \"ne\" ili bilo sta drugo");
		}

		static public void OpcijePretrage()
		{
			Console.WriteLine("Odaberite neku od sledecih opcija administracije:\n\n0)Da pogledate sve unose ukucajte ---> 0\n1)Za pretragu po broju porudzbine ukucajte ---> 1\n2)Za pretragu po imenu porucioca ukucajte ---> 2\n3)Za pretragu po broju telefona porucioca ukucajte ---> 3\n4)Da izbrisete porudzbinu ukucajte ---> 4\n5)Za povratak na prethodnu stranicu ukucajte ---> 5");

		}
	}
}

