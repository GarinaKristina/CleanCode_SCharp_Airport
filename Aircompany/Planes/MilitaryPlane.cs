using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType Type { get; private set; }
        public string MilitaryType { get; internal set; }

        public MilitaryPlane(string model, int maximumSpeed, int maximumFlightDistance, int maximumLoadCapacity, MilitaryType type)
            : base(model, maximumSpeed, maximumFlightDistance, maximumLoadCapacity)
        {
            Type = type;
        }

        public override bool Equals(object item) => item is MilitaryPlane plane && base.Equals(item) && Type == plane.Type;

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            hashCode = (hashCode * -1521134295) + base.GetHashCode();
            hashCode = (hashCode * -1521134295) + Type.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString().Replace(".", $", type = {Type}.");
        }

        public MilitaryType PlaneTypeIs() => Type;
    }
}