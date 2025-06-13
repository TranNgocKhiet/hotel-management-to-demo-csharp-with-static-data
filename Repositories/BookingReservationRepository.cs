using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class BookingReservationRepository : IBookingReservationRepository
    {
        private static BookingReservationRepository bookingReservationRepository;
        public static BookingReservationRepository Instance => bookingReservationRepository ??= new BookingReservationRepository();

        public BookingReservationRepository() { }

        public BookingReservation GetBookingReservation(int id) => BookingReservationDAO.GetBookingReservation(id);

        public List<BookingReservation> GetBookingReservations() => BookingReservationDAO.GetBookingReservations();

        public void AddBookingReservation(BookingReservation bookingReservation) => BookingReservationDAO.AddBookingReservation(bookingReservation);

        public void UpdateBookingReservation(BookingReservation bookingReservation) => BookingReservationDAO.UpdateBookingReservation(bookingReservation);

        public void RemoveBookingReservation(BookingReservation bookingReservation) => BookingReservationDAO.RemoveBookingReservation(bookingReservation);

        List<BookingReservation> IBookingReservationRepository.GetBookingReservationsByCustomerID(int customerId) => BookingReservationDAO.GetBookingReservationsByCustomerID(customerId);
    }
}
