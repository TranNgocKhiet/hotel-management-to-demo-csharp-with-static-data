using BusinessObjects;
using Repositories;

namespace Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepository iRoomTypeRepository;

        public RoomTypeService(IRoomTypeRepository roomTypeRepository)
        {
            iRoomTypeRepository = roomTypeRepository ?? throw new ArgumentNullException(nameof(roomTypeRepository));
        }

        public void AddRoomType(RoomType roomType)
        {
            iRoomTypeRepository.AddRoomType(roomType);
        }
        public void UpdateRoomType(RoomType roomType)
        {
            iRoomTypeRepository.UpdateRoomType(roomType);
        }
        public void RemoveRoomType(RoomType roomType)
        {
            iRoomTypeRepository.RemoveRoomType(roomType);
        }
        public RoomType GetRoomType(int roomTypeId)
        {
            return iRoomTypeRepository.GetRoomType(roomTypeId);
        }
        public List<RoomType> GetRoomTypes()
        {
            return iRoomTypeRepository.GetRoomTypes();
        }
    }
}
