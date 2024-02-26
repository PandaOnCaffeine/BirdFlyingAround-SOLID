
namespace BirdFlyingAround_SOLID.Abstract_Classes
{
    internal abstract class Bird
    {
        protected string _name;
        protected string _specie;
        // Changed the code from moodle. From SetLocation to Walk
        public abstract void Walk(double distance, double speedKmH);

        // Changed the code from moodle. From SetAltitude to Fly
        public abstract void Fly(double altitudeM);

        public abstract void Draw();
    }
}
