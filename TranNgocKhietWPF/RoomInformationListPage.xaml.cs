using Repositories;
using Services;
using System.Windows;
using System.Windows.Controls;
using BusinessObjects;

namespace TranNgocKhietWPF
{
    public partial class RoomInformationListPage : Page
    {
        private readonly IRoomInformationService iRoomInformationService;

        public RoomInformationListPage()
        {
            InitializeComponent();

            var roomRepository = new RoomInformationRepository();
            iRoomInformationService = new RoomInformationService(roomRepository);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadRoomList();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = SearchTextBox.Text.Trim().ToLower();

            try
            {
                var allRooms = iRoomInformationService.GetRoomInformations();

                var filteredRooms = allRooms
                    .Where(r => r.RoomNumber.ToLower().Contains(keyword))
                    .ToList();

                RoomDataGrid.ItemsSource = null;
                RoomDataGrid.ItemsSource = filteredRooms;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while searching room information");
            }
        }

        public void LoadRoomList()
        {
            try
            {
                var rooms = iRoomInformationService.GetRoomInformations();
                RoomDataGrid.ItemsSource = null;
                RoomDataGrid.ItemsSource = rooms;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading room information");
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            List<RoomType> roomTypes = RoomTypeRepository.Instance.GetRoomTypes();

            var dialog = new RoomInformationDialog(roomTypes);
            if (dialog.ShowDialog() == true)
            {
                var newRoom = dialog.RoomInfo;

                var rooms = iRoomInformationService.GetRoomInformations();
                int autoID = 1;
                var usedIDs = new HashSet<int>(rooms.Select(r => r.RoomID));

                while (usedIDs.Contains(autoID))
                {
                    autoID++;
                }

                newRoom.RoomID = autoID;
                iRoomInformationService.AddRoomInformation(newRoom);
                LoadRoomList();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (RoomDataGrid.SelectedItem is RoomInformation selectedRoom)
            {
                List<RoomType> roomTypes = RoomTypeRepository.Instance.GetRoomTypes();

                var dialog = new RoomInformationDialog(roomTypes, selectedRoom);
                if (dialog.ShowDialog() == true)
                {
                    iRoomInformationService.UpdateRoomInformation(dialog.RoomInfo);
                    LoadRoomList();
                }
            }
            else
            {
                MessageBox.Show("Please select a room to edit.");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (RoomDataGrid.SelectedItem is RoomInformation selectedRoom)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete room '{selectedRoom.RoomNumber}' (ID: {selectedRoom.RoomID})?",
                    "Confirm Delete",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        iRoomInformationService.RemoveRoomInformation(selectedRoom);
                        MessageBox.Show("Room deleted successfully.");
                        LoadRoomList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete room.\n" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete.");
            }
        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
    }
}