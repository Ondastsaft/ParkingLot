namespace Parking_lot.Vehicles
{
    internal class MotorBike : Vehicle
    {
        internal string Brand { get; set; }
        public MotorBike(string licenseNumber, string colour, int requiredSpace, int positionX, int positionY, int width, int length, string brand)
            : base(licenseNumber, colour, requiredSpace, positionX, positionY, width, length)
        {
            Brand = brand;
        }
    }
}
