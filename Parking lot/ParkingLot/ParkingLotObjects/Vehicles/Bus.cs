using ParkingLot.ParkingLot.ParkingLotObjects;

namespace ParkingLot.ParkingLot.Vehicles
{
    internal class Bus : Vehicle

    {
        internal int PassengerCapacity { get; set; }

        internal Bus(string name, int fromTop, int fromLeft, string licensePlate, string colour, int passengerCapacity) 
            : base(name, fromTop, fromLeft, licensePlate, colour)
        {
            Name = name;
            FromTop = fromTop;
            FromLeft = fromLeft;
            Width = 8;
            Height = 16;
            RequiredSpace = 4;
            LicensePlate = licensePlate;
            Colour = colour;
            PassengerCapacity = passengerCapacity;
        }


    }
}
