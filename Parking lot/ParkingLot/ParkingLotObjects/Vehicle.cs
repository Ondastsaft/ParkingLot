namespace ParkingLot.ParkingLot.ParkingLotObjects
{
    internal class Vehicle : ParkingLotObject
    {

        internal string LicensePlate { get; set; }
        internal string Colour { get; set; }
        internal int RequiredSpace { get; set; }

        internal Vehicle(string name, int fromTop, int fromLeft, string licensePlate, string colour) : 
            base(name, fromTop, fromLeft)
        {
            LicensePlate = licensePlate;
            Colour = colour;
           
        }
    }
}
