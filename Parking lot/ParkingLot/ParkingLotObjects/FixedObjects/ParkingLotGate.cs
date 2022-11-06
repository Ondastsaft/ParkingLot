namespace ParkingLot.ParkingLot.ParkingLotObjects.FixedObjects
{
    internal class ParkingLotGate : ParkingLotObject
    {
        private bool IsOpen { get; set; }
        internal ParkingLotGate(string name, int fromTop, int fromLeft, int width, int length) : base(name, fromTop, fromLeft, width, length)
        {
        }
        public void OpenGate()
        {
            IsOpen = true;
        }

    }
}
