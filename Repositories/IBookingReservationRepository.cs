using BusinessObjects;

namespace Repositories
{
    public interface IBookingReservationRepository
    {
        BookingReservation GetBookingReservation(int id);
        List<BookingReservation> GetBookingReservations();
        void AddBookingReservation(BookingReservation bookingReservation);
        void UpdateBookingReservation(BookingReservation bookingReservation);
        void RemoveBookingReservation(BookingReservation bookingReservation);
        List<BookingReservation> GetBookingReservationsByCustomerID(int customerId);
    }
}
