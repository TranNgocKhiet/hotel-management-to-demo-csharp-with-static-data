using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using BusinessObjects;
using Services;
using Repositories;

namespace TranNgocKhietWPF
{
    public partial class BookingReservationReportPage : Page
    {
        private readonly IBookingReservationService bookingService;

        public BookingReservationReportPage()
        {
            InitializeComponent();
            var repo = new BookingReservationRepository();
            bookingService = new BookingReservationService(repo);
        }

        private void GenerateReport_Click(object sender, RoutedEventArgs e)
        {
            if (StartDatePicker.SelectedDate == null || EndDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Please select both Start Date and End Date.");
                return;
            }

            DateOnly start = DateOnly.FromDateTime(StartDatePicker.SelectedDate.Value);
            DateOnly end = DateOnly.FromDateTime(EndDatePicker.SelectedDate.Value);

            if (start > end)
            {
                MessageBox.Show("Start Date must be before or equal to End Date.");
                return;
            }

            try
            {
                var bookings = bookingService.GetBookingReservations()
                    .Where(b => b.BookingDate >= start && b.BookingDate <= end)
                    .OrderByDescending(b => b.BookingDate)
                    .ToList();

                ReportDataGrid.ItemsSource = bookings;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate report.\n" + ex.Message);
            }
        }
    }
}
