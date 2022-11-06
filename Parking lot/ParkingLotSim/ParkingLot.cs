using Parking_lot.ParkingLot.ParkingLotObjects.FixedObjects;

namespace Parking_lot.ParkingLot
{
    internal class ParkingLot
    {
        internal ParkingMachine MyParkingLotMachine = new ParkingMachine();
        internal ParkingLotGate MyParkingLotGate = new ParkingLotGate();
        internal ParkingLotFrame MyParkingLotFrame = new ParkingLotFrame();
        internal List<ParkingSpace> MyParkingSpaces { get; set; }
        internal void Run()
        {
            DrawObject(MyParkingLotMachine);
            DrawObject(MyParkingLotGate);
            DrawObject(MyParkingLotFrame);
            Console.ReadLine();
        }

        private void DrawObject(ParkingLotObject parkingLotObjectToDraw)
        {
            {
                Console.SetCursorPosition(parkingLotObjectToDraw.PositionY, parkingLotObjectToDraw.PositionX);
                Console.Write('┌' + " ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(parkingLotObjectToDraw.Name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" " + new String('─', parkingLotObjectToDraw.Width - parkingLotObjectToDraw.Name.Length - 4) + '┐');
                Console.WriteLine();
                for (int i = 0; i < parkingLotObjectToDraw.Height; i++)
                {
                    Console.SetCursorPosition(parkingLotObjectToDraw.PositionY, parkingLotObjectToDraw.PositionX + i + 1);
                    Console.Write('│' + " " + new string(' ', parkingLotObjectToDraw.Width) + " " + '│');
                }
                Console.SetCursorPosition(parkingLotObjectToDraw.PositionY, parkingLotObjectToDraw.PositionX + parkingLotObjectToDraw.Height + 1);
                Console.Write('└' + new String('─', parkingLotObjectToDraw.Width - 2) + '┘');
            }
        }
        private void DrawList<T>(List<T> ParkingLotObjectsList)
        {

            foreach (T parkingLotObject in ParkingLotObjectsList)
            {
                DrawObject(parkingLotObject as ParkingLotObject);
            }

        }

        private void EraseObject(ParkingLotObject parkingLotObjectToErase)
        {
            for (int i = 0; i < parkingLotObjectToErase.Height + 2; i++)
            {
                Console.SetCursorPosition(parkingLotObjectToErase.PositionY, parkingLotObjectToErase.PositionX + i);
                Console.Write(new string(' ', parkingLotObjectToErase.Width));
            }
        }



    }
}
