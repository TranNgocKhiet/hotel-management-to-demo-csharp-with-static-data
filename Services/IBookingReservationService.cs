using BusinessObjects;
using System.Collections.Generic;

namespace Services
{
    public interface IBookingReservationService
    {
        void AddBookingReservation(BookingReservation bookingReservation);
        void UpdateBookingReservation(BookingReservation bookingReservation);
        void RemoveBookingReservation(BookingReservation bookingReservation);
        BookingReservation GetBookingReservation(int bookingReservationId);
        List<BookingReservation> GetBookingReservations();
        List<BookingReservation> GetBookingReservationsByCustomerID(int customerId);

    }
}
