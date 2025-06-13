using BusinessObjects;
using System.Collections.Generic;

namespace Services
{
    public interface IBookingDetailService
    {
        void AddBookingDetail(BookingDetail bookingDetail);
        void UpdateBookingDetail(BookingDetail bookingDetail);
        void RemoveBookingDetail(BookingDetail bookingDetail);
        BookingDetail GetBookingDetail(int bookingDetailId);
        List<BookingDetail> GetBookingDetails();
    }
}
