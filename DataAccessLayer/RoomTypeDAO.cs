using BusinessObjects;

namespace DataAccessLayer
{
    public class RoomTypeDAO
    {
        private static List<RoomType> listRoomTypes;

        static RoomTypeDAO()
        {
            RoomType roomType1 = new RoomType(1, "Standard room", "This is typically the most affordable option and provides basic amenities such as a bed, dresser, and TV.", "N/A");
            RoomType roomType2 = new RoomType(2, "Suite", "Suites usually offer more space and amenities than standard rooms, such as a separate living area, kitchenette, and multiple bathrooms.", "N/A");
            RoomType roomType3 = new RoomType(3, "Deluxe room", "Deluxe rooms offer additional features such as a balcony or sea view, upgraded bedding, and improved décor.", "N/A");
            RoomType roomType4 = new RoomType(4, "Executive room", "Executive rooms are designed for business travelers and offer perks such as free breakfast, evening drink, and high - speed internet.", "N/A") ;
            RoomType roomType5 = new RoomType(5, "Family Room", "A room specifically designed to accommodate families, often with multiple beds and additional space for children.", "N/A") ;
            RoomType roomType6 = new RoomType(6, "Connecting Room", "Two or more rooms with a connecting door, providing flexibility for larger groups or families traveling together.", "N/A") ;
            RoomType roomType7 = new RoomType(7, "Penthouse Suite", "An extravagant, top - floor suite with exceptional views and exclusive amenities, typically chosen for special occasions or VIP guests.", "N/A") ;
            RoomType roomType8 = new RoomType(8, "Bungalow", "A standalone cottage - style accommodation, providing privacy and a sense of seclusion often within a resort setting", "N/A");

            listRoomTypes = new List<RoomType>() { roomType1, roomType2, roomType3, roomType4, roomType5, roomType6, roomType7, roomType8 };
        }

        public static List<RoomType> GetRoomTypes()
        {
            return listRoomTypes;
        }

        public static RoomType GetRoomType(int id)
        {
            foreach (RoomType roomType in listRoomTypes)
            {
                if (roomType.RoomTypeID == id)
                    return roomType;
            }

            return null;
        }

        public static void AddRoomType(RoomType roomType)
        {
            listRoomTypes.Add(roomType);
        }

        public static void UpdateRoomType(RoomType roomType)
        {
            foreach (RoomType r in listRoomTypes)
            {
                if (r.RoomTypeID == roomType.RoomTypeID)
                {
                    r.RoomTypeID = roomType.RoomTypeID;
                    r.RoomTypeName = roomType.RoomTypeName;
                    r.TypeDescription = roomType.TypeDescription;
                    r.TypeNote = roomType.TypeNote;
                }
            }
        }

        public static void RemoveRoomType(RoomType roomType)
        {
            listRoomTypes.Remove(roomType);
        }
    }
}
