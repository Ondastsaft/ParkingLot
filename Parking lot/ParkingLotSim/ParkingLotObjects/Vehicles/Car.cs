using Parking_lot.ParkingLot.ParkingLotObjects;

namespace Parking_lot.ParkingLot.Vehicles
{
    internal class Car : Vehicle
    {
        internal bool ElectricCar { get; set; }
        internal Car(string name, string licenseplate, string colour, int requiredspace, int positionx, int positiony, bool electriccar) : base(name, licenseplate, colour, requiredspace, positionx, positiony)
        {
            ElectricCar = electriccar;
        }

    }
}
