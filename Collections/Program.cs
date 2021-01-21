using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(Names[0]);
            Console.WriteLine(Names[1]);
            Console.WriteLine(Names[2]);
            Console.WriteLine(Names[3]);
            Names.Add("İlker");
            Console.WriteLine(Names[4]);
            Console.WriteLine(Names[1]);

        }
    }
}
