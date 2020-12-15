using System;

namespace mallipeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa Arvaa luku -peliin!");
            Random rnd = new Random();
            int oikeaVastaus = rnd.Next(1, 21);
            Console.WriteLine(oikeaVastaus);

            for (int arvausluku=0; arvausluku<3; arvausluku++)
            {
                Console.WriteLine("Anna arvauksesi välillä 1-20:");
                int arvaus = int.Parse(Console.ReadLine());
                if (arvaus < oikeaVastaus)
                {
                    Console.WriteLine("Oikea luku on suurempi!");
                }        
                if (arvaus > oikeaVastaus)
                {
                    Console.WriteLine("Oikea luku on pienempi!");
                }
                if (arvaus == oikeaVastaus)
                {
                    Console.WriteLine("Oikea luku"); 
                    break;
                }
            }
        }
    }
}
