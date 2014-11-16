using System;
using PackageObject;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            AHero pl = new Player("zczxcz", 15, 10.5f, "name0",
                new Characteristic(10), new Characteristic(10), new Characteristic(10), new Characteristic(10));
            pl.name = "Zoro";
            pl.id = 15;

            Console.WriteLine(pl.life.maxCharacteristic);

            AItem it = new Мedicinal("zczxcz", 15, 10.5f, "name0",changeLife:250);
            it.name = "item";
            pl.id = 16;

            Console.WriteLine(it.changeLife);
        }
    }
}
