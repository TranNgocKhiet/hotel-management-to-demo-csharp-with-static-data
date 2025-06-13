using BusinessObjects;

namespace DataAccessLayer
{
    public class BookingDetailDAO
    {
        private static List<BookingDetail> bookingDetails;

        static BookingDetailDAO()
        {
            BookingDetail bookingDetail1 = new BookingDetail(1, 3, new DateOnly(2024, 01, 01), new DateOnly(2024, 01, 02), 199);
            BookingDetail bookingDetail2 = new BookingDetail(1, 7, new DateOnly(2024, 01, 01), new DateOnly(2024, 01, 02), 179);
            BookingDetail bookingDetail3 = new BookingDetail(2, 3, new DateOnly(2024, 01, 05), new DateOnly(2024, 01, 06), 199);
            BookingDetail bookingDetail4 = new BookingDetail(2, 5, new DateOnly(2024, 01, 05), new DateOnly(2024, 01, 09), 219);

            bookingDetails = new List<BookingDetail> { bookingDetail1, bookingDetail2, bookingDetail3, bookingDetail4 };
        }

        public static List<BookingDetail> GetBookingDetails()
        {
            return bookingDetails;
        }

        public static BookingDetail GetBookingDetail(int id)
        {
            foreach(BookingDetail bookingDetail in bookingDetails.ToList())
            {
                if (bookingDetail.BookingReservationID == id) 
                {
                    return bookingDetail;
                }
            }

            return null;
        }

        public static void AddBookingDetail(BookingDetail bookingDetail)
        {
            if (bookingDetails == null)
                bookingDetails = new List<BookingDetail>();
            bookingDetails.Add(bookingDetail);
        }

        public static void UpdateBookDetail(BookingDetail bookingDetail)
        {
            foreach(BookingDetail b in bookingDetails.ToList())
            {
                if (bookingDetail.BookingReservationID == b.BookingReservationID)
                {
                    b.BookingReservationID = bookingDetail.BookingReservationID;
                    b.RoomID = bookingDetail.RoomID;
                    b.StartDate = bookingDetail.StartDate;
                    b.EndDate = bookingDetail.EndDate;
                    b.ActualPrice = bookingDetail.ActualPrice;
                }
            }
        }

        public static void RemoveBookDetail(BookingDetail bookingDetail)
        {
            if (bookingDetails != null && bookingDetails.Contains(bookingDetail))
                bookingDetails.Remove(bookingDetail);
        }
    }
}
