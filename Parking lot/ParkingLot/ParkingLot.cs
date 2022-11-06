using ParkingLot.ParkingLot.ParkingLotObjects.FixedObjects;

namespace ParkingLot.ParkingLot
{
    public class ParkingLotSim
    {
        internal ParkingMachine MyParkingMachine = new ParkingMachine();
        internal ParkingLotGate MyParkingLotGate = new ParkingLotGate();
        internal ParkingLotFrame MyParkingLotFrame = new ParkingLotFrame();
        internal List<ParkingSpace> MyParkingSpaces { get; set; }

        public ParkingLotSim()
        {
            MyParkingSpaces = new List<ParkingSpace>();
            for (int i = 0; i < 10; i++)
            {
                MyParkingSpaces.Add(new ParkingSpace());
            }
        }   

        private void DrawObject(ParkingLotObject parkingLotObjectToDraw)
        {
        }
        private void DrawList<T>(List<T> ParkingLotObjectsList)
        {

        }





    }
}
