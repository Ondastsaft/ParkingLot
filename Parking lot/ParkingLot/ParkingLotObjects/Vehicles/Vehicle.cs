namespace Parking_lot.ParkingLot.Vehicles
{
    internal class Vehicle
    {
        internal string LicenseNumber { get; set; }
        internal string Colour { get; set; }
        internal int RequiredSpace { get; set; }
        internal int PositionX { get; set; }
        internal int PositionY { get; set; }
        internal int Width { get; set; }
        internal int Length { get; set; }
        public Vehicle(string licenseNumber, string colour, int requiredSpace, int positionX, int positionY, int width, int length)
        {
            LicenseNumber = licenseNumber;
            Colour = colour;
            RequiredSpace = requiredSpace;
            PositionX = positionX;
            PositionY = positionY;
            Width = width;
            Length = length;
        }


    }
}
