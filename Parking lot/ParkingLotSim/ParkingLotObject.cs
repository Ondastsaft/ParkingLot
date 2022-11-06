namespace Parking_lot.ParkingLot
{
    internal class ParkingLotObject
    {
        internal string Name { get; set; }
        internal int PositionX { get; set; }
        internal int PositionY { get; set; }
        internal int Width { get; set; }
        internal int Height { get; set; }
        internal void PrintMe()
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.WriteLine($"Name: {Name} Width: {Width} Height: {Height} /n PositionX: {PositionX} PositionY: {PositionY} ");
        }

    }
}
