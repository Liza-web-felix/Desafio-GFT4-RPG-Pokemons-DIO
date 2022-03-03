using System;
using Dotnet_POO.src.Entities;

namespace Dotnet_POO
{
    class Program
    {
             static void Main(string[] args)
        {
            FragilHero weedle = new FragilHero(name: "Weedle", level: 40, hp:314, mp: 641, heroType: "Venenoso - Weedle Candy");
            FragilHero butterfree = new FragilHero(name: "Butterfree", level: 40, hp: 500, mp: 482, heroType: "Voador - Caterpie Candy"); 
            PotênciaHero machoke = new PotênciaHero(name: "Machoke", level: 35, hp: 570, mp: 80,   heroType: "Lutador - Machoke Candy");
            PotênciaHero charizard = new PotênciaHero(name: "Charizard", level: 35, hp: 750, mp: 100, heroType: "Voador - Charizard Candy");
    

            System.Console.WriteLine(charizard.Attack(200));
            System.Console.WriteLine(machoke.Attack(100));
            System.Console.WriteLine(weedle.Attack(32));
            System.Console.WriteLine(butterfree.Attack(90));
        }
    }
}