using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace PapaBob.Persistance
{
	public class PorucenaPizza
	{
		public int PorucenaPizzaId {get; set;}
		public string Velicina {get; set;}
		public string Kora {get; set;}
		public string Zacini {get; set;}
		public double Cena {get; set;}

		public int PorudzbinaId {get; set;}
		public Porudzbina Porudzbina {get; set;}
	}
}
