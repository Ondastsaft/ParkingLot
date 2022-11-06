using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingLot.ParkingLot.ParkingLotObjects;

namespace Parking_lot.ParkingLot.ParkingLotObjects.Vehicles
{
    internal class Motorbike : Vehicle        
    {
        internal Motorbike(string name, int fromTop, int fromLeft, string licensePlate, string colour, string brand) : 
            base(name, fromTop, fromLeft, licensePlate, colour)
        {
            Brand = brand;
            Width = 2;
            Height = 10;
            RequiredSpace = 1;
            FromTop = fromTop;
            FromLeft = fromLeft;
        }
        internal string Brand { get; set; }
        
    }
}
