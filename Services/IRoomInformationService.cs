using BusinessObjects;

namespace Services
{
    public interface IRoomInformationService
    {
        void AddRoomInformation(RoomInformation roomInformation);
        void UpdateRoomInformation(RoomInformation roomInformation);
        void RemoveRoomInformation(RoomInformation roomInformation);
        RoomInformation GetRoomInformation(int roomInformationId);
        List<RoomInformation> GetRoomInformations();
    }
}
