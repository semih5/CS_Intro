using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //böyle tek tek yazılmaz
            string kurs1 = "yazılım geliştirici kursu";
            string kurs2 = "programlamaya giriş";

            //array-diziler kullanılır

            string[] kurslar = new string[] { "yazılım geliştirici kursu",
            "programlamaya giriş", "java"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");

            //for (int i = 1; i < 10; i=i+2) //i+=2 şeklinde de yazılabilir
            //{
            //  Console.WriteLine(i);
            //}
        }
    }
}
