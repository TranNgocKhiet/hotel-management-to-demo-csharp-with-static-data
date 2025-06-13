using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class RoomInformationRepository : IRoomInformationRepository
    {
        private static RoomInformationRepository roomInformationRepository;
        public static RoomInformationRepository Instance => roomInformationRepository ??= new RoomInformationRepository();

        public List<RoomInformation> roomInformations = new List<RoomInformation>();

        public RoomInformationRepository() { }  

        public RoomInformation GetRoomInformation(int id) => RoomInformationDAO.GetRoomInformation(id);

        public List<RoomInformation> GetRoomInformations() => RoomInformationDAO.GetRoomInformations();

        public void AddRoomInformation(RoomInformation roomInformation) => RoomInformationDAO.AddRoomInformation(roomInformation);

        public void UpdateRoomInformation(RoomInformation roomInformation) => RoomInformationDAO.UpdateRoomInformation(roomInformation);

        public void RemoveRoomInformation(RoomInformation roomInformation) => RoomInformationDAO.RemoveRoomInformation(roomInformation);
    }
}
