namespace Parking_lot.ParkingLot.ParkingLotObjects
{
    abstract class Vehicle : ParkingLotObject
    {

        internal string LicensePlate { get; set; }
        internal string Colour { get; set; }
        internal int RequiredSpace { get; set; }

        protected Vehicle(string name, string licenseplate, string colour, int requiredspace, int positionx, int positiony)
        {
            Name = name;
            LicensePlate = licenseplate;
            Colour = colour;
            RequiredSpace = requiredspace;
            PositionX = positionx;
            PositionY = positiony;

        }

    }


}
