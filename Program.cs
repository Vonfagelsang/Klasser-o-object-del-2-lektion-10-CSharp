using System;
using System.Collections.Generic;

class Program {

    public static void Main () 
    {
        List<Fordon> Fordonslista = new List<Fordon>();

        Fordon bil = new Fordon("Fård", "grön", "V3", 1500);
        Fordonslista.Add(bil);
        Fordonslista.Add(new Fordon("Volvo", "gul", "V70", 2000));

        foreach (Fordon element in Fordonslista)
        {
            Console.WriteLine(element.tillvärkare);
            Console.WriteLine(element.årsmodell);
            Console.WriteLine(element.modell);
            Console.WriteLine(element.vikt);
        }
    }
}
