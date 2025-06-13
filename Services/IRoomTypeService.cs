using BusinessObjects;

namespace Services
{
    public interface IRoomTypeService
    {
        void AddRoomType(RoomType roomType);
        void UpdateRoomType(RoomType roomType);
        void RemoveRoomType(RoomType roomType);
        RoomType GetRoomType(int roomTypeId);
        List<RoomType> GetRoomTypes();
    }
}
