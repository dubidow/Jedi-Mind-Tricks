using System;
using System.Collections.Generic;
using System.Linq;

namespace Jedi_Mind_Tricks
{
    class Program
    {
        static void Main(string[] args)
        {

            // Oprette mit dictionary
            Dictionary<string, int> characters = new Dictionary<string, int>();


            //Tilføj værdier
            characters.Add("Daniel", 27);
            characters.Add("Natasja", 31);


            //Udskriv den første værdi i dictionary
            Console.WriteLine(characters.First());


            //Fjern en værdi i dictionary
            characters.Remove("Han");


            //Udskriv alt i dictionary
            foreach (var item in characters)
            {
                Console.WriteLine("{0} er {1} år", item.Key, item.Value);
            }
            
        }
    }
}
