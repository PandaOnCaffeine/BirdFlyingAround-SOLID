using System;

namespace BirdFlyingAround_SOLID.Abstract_Classes
{
    internal abstract class NonFlyingBird : Bird
    {
        public override void Fly(double altitudeM)
        {
            Console.WriteLine($"The {_specie} {_name} can not fly, but wants to at a altitude of {altitudeM}m");
        }
    }
}
