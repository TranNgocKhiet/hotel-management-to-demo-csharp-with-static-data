using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class BookingDetailRepository : IBookingDetailRepository
    {
        private static BookingDetailRepository bookingDetailRepository;
        public static BookingDetailRepository Instance => bookingDetailRepository ??= new BookingDetailRepository();

        public BookingDetailRepository() { }

        public BookingDetail GetBookingDetail(int id) => BookingDetailDAO.GetBookingDetail(id);

        public List<BookingDetail> GetBookingDetails() => BookingDetailDAO.GetBookingDetails();

        public void AddBookingDetail(BookingDetail bookingDetail) => BookingDetailDAO.AddBookingDetail(bookingDetail);

        public void UpdateBookingDetail(BookingDetail bookingDetail) => BookingDetailDAO.UpdateBookDetail(bookingDetail);

        public void RemoveBookingDetail(BookingDetail bookingDetail) => BookingDetailDAO.RemoveBookDetail(bookingDetail);
    }
}
