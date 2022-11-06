namespace ParkingLot.ParkingLot
{
    internal class ParkingLotObject
    {
        internal string Name { get; set; }
        internal int FromTop { get; set; }
        internal int FromLeft { get; set; }
        internal int Width;
        internal int Height;
        public ParkingLotObject(string name, int fromTop, int fromLeft)
        {
            Name = name;
            FromTop = fromTop;
            FromLeft = fromLeft;
           
        }                
    }
}
