using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookingReservationDAO
    {
        private static List<BookingReservation> bookingReservations;

        static BookingReservationDAO()
        {
            BookingReservation reservation1 = new BookingReservation(1, new DateOnly(2023, 12, 20), 378, 3, 1);
            BookingReservation reservation2 = new BookingReservation(2, new DateOnly(2023, 12, 21), 1493, 3, 1);

            bookingReservations = new List<BookingReservation> { reservation1, reservation2 };
        }

        public static List<BookingReservation> GetBookingReservations()
        {
            return bookingReservations;
        }

        public static BookingReservation GetBookingReservation(int id)
        {
            foreach (BookingReservation reservation in bookingReservations.ToList())
            {
                if (reservation.BookingReservationID == id)
                {
                    return reservation;
                }
            }
            return null;
        }

        public static void AddBookingReservation(BookingReservation reservation)
        {
            if (bookingReservations == null)
                bookingReservations = new List<BookingReservation>();
            bookingReservations.Add(reservation);
        }

        public static void UpdateBookingReservation(BookingReservation reservation)
        {
            foreach (BookingReservation r in bookingReservations.ToList())
            {
                if (reservation.BookingReservationID == r.BookingReservationID)
                {
                    r.BookingDate = reservation.BookingDate;
                    r.TotalPrice = reservation.TotalPrice;
                    r.CustomerID = reservation.CustomerID;
                    r.BookingStatus = reservation.BookingStatus;
                }
            }
        }

        public static void RemoveBookingReservation(BookingReservation reservation)
        {
            if (bookingReservations != null && bookingReservations.Contains(reservation))
                bookingReservations.Remove(reservation);
        }

        public static List<BookingReservation> GetBookingReservationsByCustomerID(int customerId)
        {
            List<BookingReservation> bookingReservationWithID = new List<BookingReservation>();
            foreach (BookingReservation bookingReservation in bookingReservations.ToList())
            {
                if (bookingReservation.CustomerID == customerId)
                    bookingReservationWithID.Add(bookingReservation);
            }
            return bookingReservationWithID;
        }
    }
}
