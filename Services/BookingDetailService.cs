using BusinessObjects;
using Repositories;

namespace Services
{
    public class BookingDetailService : IBookingDetailService
    {
        private readonly IBookingDetailRepository iBookingDetailRepository;

        public BookingDetailService(IBookingDetailRepository bookingDetailRepository)
        {
            iBookingDetailRepository = bookingDetailRepository;
        }

        public void AddBookingDetail(BookingDetail bookingDetail)
        {
            iBookingDetailRepository.AddBookingDetail(bookingDetail);
        }

        public void UpdateBookingDetail(BookingDetail bookingDetail)
        {
            iBookingDetailRepository.UpdateBookingDetail(bookingDetail);
        }

        public void RemoveBookingDetail(BookingDetail bookingDetail)
        {
            iBookingDetailRepository.RemoveBookingDetail(bookingDetail);
        }

        public BookingDetail GetBookingDetail(int bookingDetailId)
        {
            return iBookingDetailRepository.GetBookingDetail(bookingDetailId);
        }

        public List<BookingDetail> GetBookingDetails()
        {
            return iBookingDetailRepository.GetBookingDetails();
        }
    }
}
