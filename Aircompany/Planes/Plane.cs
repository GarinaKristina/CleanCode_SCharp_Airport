using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public string Model { get; private set; }
        public int MaximumSpeed { get; private set; }
        public int MaximumFlightDistance { get; private set; }
        public int MaximumLoadCapacity { get; private set; }

        public Plane(string model, int maximumSpeed, int maximumFlightDistance, int maximumLoadCapacity)
        {
            Model = model;
            MaximumSpeed = maximumSpeed;
            MaximumFlightDistance = maximumFlightDistance;
            MaximumLoadCapacity = maximumLoadCapacity;
        }

        public override string ToString()
        {
            return $"Plane: model = '{Model}', maximumSpeed = {MaximumSpeed}, maximumFlightDistance = {MaximumFlightDistance}, maximumLoadCapacity={MaximumLoadCapacity}.";
        }

        public override bool Equals(object item) => item is Plane plane && 
        Model == plane.Model && MaximumSpeed == plane.MaximumSpeed &&
        MaximumFlightDistance == plane.MaximumFlightDistance &&
        MaximumLoadCapacity == plane.MaximumLoadCapacity;

        public override int GetHashCode()
        {
            var hashCode = -1043886837;
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCode = (hashCode * -1521134295) + MaximumSpeed.GetHashCode();
            hashCode = (hashCode * -1521134295) + MaximumFlightDistance.GetHashCode();
            hashCode = (hashCode * -1521134295) + MaximumLoadCapacity.GetHashCode();
            return hashCode;
        }

    }
}