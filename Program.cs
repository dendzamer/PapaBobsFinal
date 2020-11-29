using System;
using PapaBob.Persistance;

namespace PapaBob
{
    class Program
    {

	    static void Main(string[] args)
	    {
		    using (var db = new PizzaContext())
		    {
			    db.Database.EnsureCreated();
			    db.SaveChanges();
			    Pokreni pokreni = new Pokreni();
		    }

	    }
    }
}
