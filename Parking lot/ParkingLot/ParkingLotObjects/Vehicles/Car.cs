using ParkingLot.ParkingLot.ParkingLotObjects;

namespace ParkingLot.ParkingLot.Vehicles
{
    internal class Car : Vehicle
    {
        internal bool ElectricCar { get; set; }

        internal Car(string name, int fromTop, int fromLeft, string licensePlate, string colour, bool electricCar) : base (name, fromTop, fromLeft, licensePlate, colour)
        {
            Name = name;
            ElectricCar = electricCar;
            Width = 8;
            Height = 10;
            RequiredSpace = 2;
            FromTop = fromTop;
            FromLeft = fromLeft;
            LicensePlate = licensePlate;
            Colour = colour;           
        }
    }
}
