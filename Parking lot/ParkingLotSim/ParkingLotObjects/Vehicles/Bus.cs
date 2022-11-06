using Parking_lot.ParkingLot.ParkingLotObjects;

namespace Parking_lot.ParkingLot.Vehicles
{
    internal class Bus : Vehicle

    {
        internal int PassengerCapacity { get; set; }
        internal Bus(string name, string licenseplate, string colour, int requiredspace, int positionx, int positiony, int passengercapacity) : base(name, licenseplate, colour, requiredspace, positionx, positiony)
        {
            PassengerCapacity = passengercapacity;
        }

    }
}
