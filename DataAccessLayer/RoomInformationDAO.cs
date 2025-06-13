using BusinessObjects;

namespace DataAccessLayer
{
    public class RoomInformationDAO
    {
        private static List<RoomInformation> roomInformations;

        static RoomInformationDAO()
        {
            RoomInformation roomInformation1 = new RoomInformation(1, "2364", "A basic room with essential amenities, suitable for individual travelers or couples.", 3, 1, 1, 149);
            RoomInformation roomInformation2 = new RoomInformation(2, "3345", "Deluxe rooms offer additional features such as a balcony or sea view, upgraded bedding, and improved décor.", 5, 3, 1, 299);
            RoomInformation roomInformation3 = new RoomInformation(3, "4432", "A luxurious and spacious room with separate living and sleeping areas, ideal for guests seeking extra comfort and space.", 4, 2, 1, 199);
            RoomInformation roomInformation4 = new RoomInformation(5, "3342", "Foor 3, Window in the North West", 5, 5, 1, 219);
            RoomInformation roomInformation5 = new RoomInformation(7, "4434", "Floor 4, main window in the South", 4, 1, 1, 179);

            roomInformations = new List<RoomInformation>() { roomInformation1, roomInformation2, roomInformation3, roomInformation4, roomInformation5 };
        }

        public static List<RoomInformation> GetRoomInformations()
        {
            return roomInformations;
        }

        public static RoomInformation GetRoomInformation(int id)
        {
            foreach (RoomInformation roomInformation in roomInformations)
            {
                if (roomInformation.RoomID == id)
                    return roomInformation;
                }

            return null;
        }

        public static void AddRoomInformation(RoomInformation roomInformation) 
        {
            roomInformations.Add(roomInformation);
        }

        public static void UpdateRoomInformation(RoomInformation roomInformation)
        {
            foreach (RoomInformation r in roomInformations.ToList())
            {
                if (r.RoomID == roomInformation.RoomID)
                {
                    r.RoomID = roomInformation.RoomID;
                    r.RoomNumber = roomInformation.RoomNumber;
                    r.RoomDescription = roomInformation.RoomDescription;
                    r.RoomMaxCapacity = roomInformation.RoomMaxCapacity;
                    r.RoomStatus = roomInformation.RoomStatus;
                    r.RoomPricePerDate = roomInformation.RoomPricePerDate;
                    r.RoomTypeID = roomInformation.RoomTypeID;
                }
            }
        }

        public static void RemoveRoomInformation(RoomInformation roomInformation)
        {
            if (roomInformations != null && roomInformations.Contains(roomInformation))
            {
                roomInformations.Remove(roomInformation);
            }
        }
    }
}   