namespace ParkingLot.ParkingLot.ParkingLotObjects.FixedObjects
{
    internal class ParkingMachine : ParkingLotObject
    {
        private Dictionary<string, int>? ParkedVehicles { get; set; }
        private Dictionary<int, int>? FeePerParkingSpace { get; set; }
        internal ParkingMachine(string name, int fromTop, int fromLeft) : base(name, fromTop, fromLeft)
        {
            Name = name;
            Width = 4;
            Height = 8;
            FromTop = fromTop;
            FromLeft = fromLeft;
        }

    }
}
