using Parking_lot.Vehicles;

namespace Parking_lot

{
    internal class ParkingSpace
    {
        internal int PositionX { get; set; }
        internal int PositionY { get; set; }
        internal int Width { get; set; }
        internal int Length { get; set; }
        internal int RequiredSpace { get; set; }
        internal Vehicle MyVehicle { get; set; }
        internal bool IsOccupied { get; set; }
        internal ParkingSpace(int positionX, int positionY, int width, int length, int requiredSpace)
        {
            PositionX = positionX;
            PositionY = positionY;
            Width = width;
            Length = length;
            RequiredSpace = requiredSpace;
            IsOccupied = false;
        }


    }
}
