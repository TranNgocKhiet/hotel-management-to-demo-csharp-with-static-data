namespace BusinessObjects
{
    public partial class RoomInformation
    {
        public int RoomID { get ; set; }
        public string? RoomNumber { get; set; }
        public string? RoomDescription { get; set; }
        public int? RoomMaxCapacity { get; set; }
        public int RoomTypeID { get; set; }
        public Byte? RoomStatus { get; set; }
        public Decimal? RoomPricePerDate { get; set; }

        public RoomInformation() { }

        public RoomInformation(int roomID, string? roomNumber, string? roomDescription, 
            int? roomMaxCapacity, int roomTypeID, Byte? roomStatus, Decimal? roomPricePerDate)
        {
            RoomID = roomID;
            RoomNumber = roomNumber;
            RoomDescription = roomDescription;
            RoomMaxCapacity = roomMaxCapacity;
            RoomStatus = roomStatus;
            RoomPricePerDate = roomPricePerDate;
            RoomTypeID = roomTypeID;
        }
    }
}