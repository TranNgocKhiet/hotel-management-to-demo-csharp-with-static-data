using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private static RoomTypeRepository roomTypeRepository;
        public static RoomTypeRepository Instance => roomTypeRepository ??= new RoomTypeRepository();
        public RoomType GetRoomType(int id) => RoomTypeDAO.GetRoomType(id);

        public List<RoomType> GetRoomTypes() => RoomTypeDAO.GetRoomTypes();

        public void AddRoomType(RoomType roomType) => RoomTypeDAO.AddRoomType(roomType);
        public void UpdateRoomType(RoomType roomType) => RoomTypeDAO.UpdateRoomType(roomType);
        public void RemoveRoomType(RoomType roomType) => RoomTypeDAO.RemoveRoomType(roomType);
    }
}
