using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> vegetables = new MyDictionary<string>();

            vegetables.Add("Broccoli");
            vegetables.Add("Eggplant");
            vegetables.Add("Spinach");
            vegetables.Add("Garlic");

            Console.WriteLine("My Vegetable List: "+"\n"+vegetables.Items[0]+"\n"+vegetables.Items[1]);

        }
    }
}
