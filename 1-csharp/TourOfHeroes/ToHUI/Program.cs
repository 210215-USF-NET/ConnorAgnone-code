﻿using System;
using ToHModels;

namespace ToHUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create hero method/logic
            Hero newHero = new Hero();
            Console.WriteLine("Enter Hero Name: ");
            newHero.HeroName = Console.ReadLine();
            Console.WriteLine("Enter HP value: ");
            newHero.HP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SuperPower details");
            SuperPower newSuperPower = new SuperPower();
            Console.WriteLine("Enter SuperPower name: ");
            newSuperPower.Name = Console.ReadLine();
            Console.WriteLine("Enter SuperPower description");
            newSuperPower.Description = Console.ReadLine();
            Console.WriteLine("Enter SuperPower damage:);
            newSuperPower.Damage = int.Parse(Console.ReadLine());
            Console.WriteLine("Set the element type of the hero: ");
            newHero.ElementType = Enum.Parse<Element>(Console.ReadLine());
            newHero.SuperPower = newSuperPower;
            Console.WriteLine($"Hero Created with details: \n\t Name: {newHero.HeroName} \n\t SuperPower: {newHero.SuperPower.Name} \n\t Type: {newHero.ElementType}");
        }
    }
}
