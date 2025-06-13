using BusinessObjects;

namespace Repositories
{
    public interface IRoomInformationRepository
    {
        RoomInformation GetRoomInformation(int id);
        List<RoomInformation> GetRoomInformations();
        void AddRoomInformation(RoomInformation roomInformation);
        void UpdateRoomInformation(RoomInformation roomInformation);
        void RemoveRoomInformation(RoomInformation roomInformation);
    }
}
