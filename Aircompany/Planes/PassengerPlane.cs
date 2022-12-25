namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        public int PassengersCapacity { get; private set; }

        public PassengerPlane(string model, int maximumSpeed, int maximumFlightDistance, int maximumLoadCapacity, int passengersCapacity)
            : base(model, maximumSpeed, maximumFlightDistance, maximumLoadCapacity)
        {
            PassengersCapacity = passengersCapacity;
        }

        public override bool Equals(object item) => item is PassengerPlane plane &&
        base.Equals(item) && PassengersCapacity == plane.PassengersCapacity;

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            hashCode = (hashCode * -1521134295) + base.GetHashCode();
            hashCode = (hashCode * -1521134295) + this.PassengersCapacity.GetHashCode();
            return hashCode;
        }

        public override string ToString() => base.ToString().Replace(".", $", passengersCapacity = {PassengersCapacity}.");

    }
}