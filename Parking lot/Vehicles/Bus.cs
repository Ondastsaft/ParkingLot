namespace Parking_lot.Vehicles
{
    internal class Bus : Vehicle

    {
        internal int PassengerCapacity { get; set; }
        public Bus(string licenseNumber, string colour, int requiredSpace, int positionX, int positionY, int width, int length, int passengerCapacity)
            : base(licenseNumber, colour, requiredSpace, positionX, positionY, width, length)
        {
            PassengerCapacity = passengerCapacity;
        }


    }
}
