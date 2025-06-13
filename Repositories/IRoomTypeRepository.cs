using BusinessObjects;

namespace Repositories
{
    public interface IRoomTypeRepository
    {
        RoomType GetRoomType(int id);
        List<RoomType> GetRoomTypes();
        void AddRoomType(RoomType roomType);
        void UpdateRoomType(RoomType roomType);
        void RemoveRoomType(RoomType roomType);
    }
}
