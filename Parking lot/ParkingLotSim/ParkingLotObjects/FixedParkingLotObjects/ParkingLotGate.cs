namespace Parking_lot.ParkingLot.ParkingLotObjects.FixedObjects
{
    internal class ParkingLotGate : ParkingLotObject
    {
        private bool Unlocked = false;

        internal ParkingLotGate()
        {
            PositionX = 12;
            PositionY = 70;
            Width = 15;
            Height = 1;
        }

    }

}
