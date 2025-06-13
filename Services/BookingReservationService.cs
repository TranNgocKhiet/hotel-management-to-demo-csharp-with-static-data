using BusinessObjects;
using Repositories;

namespace Services
{
    public class BookingReservationService : IBookingReservationService
    {
        private readonly IBookingReservationRepository iBookingReservationRepository;

        public BookingReservationService(IBookingReservationRepository bookingReservationRepository)
        {
            iBookingReservationRepository = bookingReservationRepository;
        }

        public void AddBookingReservation(BookingReservation bookingReservation)
        {
            iBookingReservationRepository.AddBookingReservation(bookingReservation);
        }

        public void UpdateBookingReservation(BookingReservation bookingReservation)
        {
            iBookingReservationRepository.UpdateBookingReservation(bookingReservation);
        }

        public void RemoveBookingReservation(BookingReservation bookingReservation)
        {
            iBookingReservationRepository.RemoveBookingReservation(bookingReservation);
        }

        public BookingReservation GetBookingReservation(int bookingReservationId)
        {
            return iBookingReservationRepository.GetBookingReservation(bookingReservationId);
        }

        public List<BookingReservation> GetBookingReservations()
        {
            return iBookingReservationRepository.GetBookingReservations();
        }

        public List<BookingReservation> GetBookingReservationsByCustomerID(int customerId)
        {
            return iBookingReservationRepository.GetBookingReservationsByCustomerID(customerId);
        }
    }
}
