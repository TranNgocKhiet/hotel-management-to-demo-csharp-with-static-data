using BusinessObjects;
using Repositories;
using Services;
using System.Windows;

namespace TranNgocKhietWPF
{
    public partial class AdminWindow : Window
    {

        public AdminWindow()
        {
            InitializeComponent();
        }

        private void ToCustomerListPageButton_Click(Object sender, RoutedEventArgs e)
        {
            frMain.NavigationService.Navigate(new CustomerListPage());
        }

        private void ToRoomInformationListPageButton_Click(object sender, RoutedEventArgs e)
        {
            frMain.NavigationService.Navigate(new RoomInformationListPage());
        }

        private void ToBookingReservationReportPageButton_Click(object sender, RoutedEventArgs e)
        {
            frMain.NavigationService.Navigate(new BookingReservationReportPage());
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }
    }
}