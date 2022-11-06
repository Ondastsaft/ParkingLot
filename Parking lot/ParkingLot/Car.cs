namespace Parking_lot.Vehicles
{
    internal class Car : Vehicle
    {
        internal bool ElectricCar { get; set; }
        public Car(string licenseNumber, string colour, int requiredSpace, int positionX, int positionY, int width, int length, bool electricCar)
            : base(licenseNumber, colour, requiredSpace, positionX, positionY, width, length)
        {
            ElectricCar = electricCar;
        }
    }
}
