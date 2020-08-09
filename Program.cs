using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isGoldCustomer = true;
            //float price = (isGoldCustomer) ? 19.9f : 29.9f;
            //Console.WriteLine(price);




            var season = Seasons.Monsoon;

            switch (season)
            {
                case Seasons.Autumn:
                    Console.WriteLine("I love Autumn warmth");
                    break;
                case Seasons.Winter:
                    Console.WriteLine("I glow and feel good in Winter");
                    break;
                case Seasons.Monsoon:
                case Seasons.Rainy:
                    Console.WriteLine("Rain drops on tin hood can be super cool time to spend doing nothing or busy with self-crafts");
                    break;
                case Seasons.Spring:
                    Console.WriteLine("I get reminded of how beautiful fields look in Spring; magic in the air for plants");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("Dilemma: Can get dark but sunlight is good");
                    break;
                default:
                    Console.WriteLine("Some season is better than nothing");
                    break;
            }
        }
    }
}
