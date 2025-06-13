using BusinessObjects;
using Repositories;

namespace Services
{
    public class RoomInformationService : IRoomInformationService
    {
        private readonly IRoomInformationRepository iRoomInformationRepository;

        public RoomInformationService(IRoomInformationRepository roomInformationRepository)
        {
            iRoomInformationRepository = roomInformationRepository;
        }

        public void AddRoomInformation(RoomInformation roomInformation)
        {
            iRoomInformationRepository.AddRoomInformation(roomInformation);
        }

        public void UpdateRoomInformation(RoomInformation roomInformation)
        {
            iRoomInformationRepository.UpdateRoomInformation(roomInformation);
        }

        public void RemoveRoomInformation(RoomInformation roomInformation)
        {
            iRoomInformationRepository.RemoveRoomInformation(roomInformation);
        }

        public RoomInformation GetRoomInformation(int roomInformationId)
        {
            return iRoomInformationRepository.GetRoomInformation(roomInformationId);
        }

        public List<RoomInformation> GetRoomInformations()
        {
            return iRoomInformationRepository.GetRoomInformations();
        }
    }
}
