using System;

namespace BirdFlyingAround_SOLID.Abstract_Classes
{
    internal abstract class FlyingBird : Bird
    {
        public override void Fly(double altitudeM)
        {
            Console.WriteLine($"The {_specie} {_name} is Flying at a altitude of {altitudeM}m");
        }
    }
}
