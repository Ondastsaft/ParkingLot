namespace Parking_lot.ParkingLot.ParkingLotObjects.FixedObjects
{
    internal class ParkingMachine : ParkingLotObject
    {
        private Dictionary<string, int> ParkedVehicles = new Dictionary<string, int>();
        internal ParkingMachine()
        {
            PositionX = 2;
            PositionY = 2;
            Width = 200;
            Height = 100;
        }
        public void ParkVehicle(Vehicle vehicle)
        {
            ParkedVehicles.Add(vehicle.LicensePlate, vehicle.RequiredSpace);
        }


    }
}
