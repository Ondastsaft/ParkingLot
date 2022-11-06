namespace ParkingLot.ParkingLot.ParkingLotObjects.FixedObjects

{
    internal class ParkingSpace : ParkingLotObject
    {
       
        internal Vehicle? ParkedVehicle { get; set; }
        internal bool IsOccupied { get; set; }
        internal ParkingSpace (string name, int fromTop, int fromLeft  ) : base(name, fromTop, fromLeft)
        {
            Name = name;
            IsOccupied = false;
            Width = 8;
            Height = 12;
            FromTop = fromTop;
            FromLeft = fromLeft;
            
        }
    
    
        


        
    }
}
