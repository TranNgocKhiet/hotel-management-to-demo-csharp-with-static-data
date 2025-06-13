namespace BusinessObjects
{
    public partial class BookingReservation
    {
        public int BookingReservationID { get; set; }
        public DateOnly? BookingDate { get; set; }
        public Decimal? TotalPrice { get; set; }
        public int CustomerID { get; set; }
        public Byte? BookingStatus { get; set; }

        public BookingReservation() { }

        public BookingReservation(int bookingReservationID,
            DateOnly? bookingDate, Decimal? totalPrice, int customerID, Byte? bookingStatus)
        {
            BookingReservationID = bookingReservationID;
            BookingDate = bookingDate;
            TotalPrice = totalPrice;
            CustomerID = customerID;
            BookingStatus = bookingStatus;
        }
    }
}
