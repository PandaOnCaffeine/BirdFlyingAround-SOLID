using BirdFlyingAround_SOLID.Abstract_Classes;
using System;

namespace BirdFlyingAround_SOLID.Classes
{
    internal class Parrot : FlyingBird
    {
        public Parrot(string specie, string name)
        {
            _specie = specie;
            _name = name;
        }
        public override void Walk(double distance, double speedKmH)
        {
            Console.WriteLine($"The {_specie} {_name} is Walking {distance}m at {speedKmH} km/h");
        }
        public override void Draw()
        {
            Console.WriteLine($"Some code that draws a {_specie}??");
        }
    }
}
