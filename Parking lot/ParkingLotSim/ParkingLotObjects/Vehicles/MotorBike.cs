using Parking_lot.ParkingLot.ParkingLotObjects;

namespace Parking_lot.ParkingLot.Vehicles
{
    internal class MotorBike : Vehicle
    {
        internal string Brand { get; set; }
        internal MotorBike(string name, string licenseplate, string colour, int requiredspace, int positionx, int positiony, string brand) : base(name, licenseplate, colour, requiredspace, positionx, positiony)
        {
            Brand = brand;
        }

    }
}
