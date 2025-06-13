using BusinessObjects;

namespace Repositories
{
    public interface IBookingDetailRepository
    {
        BookingDetail GetBookingDetail(int id);
        List<BookingDetail> GetBookingDetails();
        void AddBookingDetail(BookingDetail bookingDetail);
        void UpdateBookingDetail(BookingDetail bookingDetail);
        void RemoveBookingDetail(BookingDetail bookingDetail);
    }
}
