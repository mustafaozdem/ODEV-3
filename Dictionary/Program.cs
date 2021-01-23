using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            AdYas.Add("Mustafa", 24);
            AdYas.Add("Aybüke", 25);

            foreach (var degeroku in AdYas) 
            {
                Console.WriteLine(degeroku);
            }

            Console.WriteLine(AdYas.Count);

            AdYas.Remove("Mustafa");

            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }


        }
    }

   
}
