using Repositories;
using Services;
using System.Windows;
using System.Windows.Controls;
using BusinessObjects;

namespace TranNgocKhietWPF
{
    public partial class BookingReservationHistoryPage : Page
    {
        private readonly IBookingReservationService iBookingReservationService;
        private Customer currentCustomer;

        public BookingReservationHistoryPage(Customer customer)
        {
            InitializeComponent();

            currentCustomer = customer;

            var bookingReservationRepository = BookingReservationRepository.Instance;
            var bookingReservationService = new BookingReservationService(bookingReservationRepository);
            iBookingReservationService = bookingReservationService;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadBookingReservationList();
        }

        public void LoadBookingReservationList()
        {
            try
            {
                var bookingReservations = iBookingReservationService.GetBookingReservationsByCustomerID(currentCustomer.CustomerID);
                BookingReservationDataGrid.ItemsSource = bookingReservations;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of booking reservation");
            }
        }
        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator
                              .ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
            string id = ((TextBlock)RowColumn.Content).Text;

            BookingReservation bookingReservation = iBookingReservationService.GetBookingReservation(Int32.Parse(id));

            txtBookingReservationID.Text = bookingReservation.BookingReservationID.ToString();
            txtTotalPrice.Text = bookingReservation.TotalPrice.ToString();
            txtCustomerID.Text = bookingReservation.CustomerID.ToString();
            txtBookingStatus.Text = bookingReservation.BookingStatus.ToString();

            txtBookingDate.Text = bookingReservation.BookingDate.HasValue
                ? bookingReservation.BookingDate.Value.ToString("dd/MM/yyyy") : "";
        }
    }
}
