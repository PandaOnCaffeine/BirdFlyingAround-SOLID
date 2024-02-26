using BirdFlyingAround_SOLID.Abstract_Classes;
using BirdFlyingAround_SOLID.Classes;
using System;
using System.Collections.Generic;

namespace BirdFlyingAround_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird penguin = new Penguin("Penguin", "Pingu"); // Pingu From, Its pingu, everyone know pingu. Noot Noot
            Bird parrot = new Parrot("Parrot", "Jago"); // Jago From Aladdin

            List<Bird> birdList = new List<Bird>
            {
                penguin,
                parrot
            };

            foreach (Bird birdy in birdList)
            {
                birdy.Walk(200, 5);
                birdy.Fly(150);
                birdy.Draw();
            }

            Console.ReadLine();
        }
    }
}
