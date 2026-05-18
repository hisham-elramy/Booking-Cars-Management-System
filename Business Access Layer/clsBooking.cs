using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class clsBooking
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public enum enError { NoError = 0, CarIDError = 1, ClientIDError = 2, UserIDError = 3, BookingIDError = 4, UnknowError = 5 }

        public int BookingID { get; set; } = -1;
        public int CarID { get; set; } = -1;
        public int ClientID { get; set; } = -1;
        public int UserID { get; set; } = -1;

        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; } = decimal.Zero;

        public clsBooking()
        {
            BookingID = -1;
            CarID = -1;
            ClientID = -1;
            UserID = -1;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            TotalPrice = decimal.Zero;

            Mode = enMode.AddNew;
        }

        private clsBooking(int BookingID, int CarID, int ClientID, int UserID, DateTime StartDate, DateTime EndDate, decimal TotalPrice) 
        {
            this.BookingID = BookingID;
            this.CarID = CarID;

            this.ClientID = ClientID;
            this.UserID = UserID;

            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.TotalPrice = TotalPrice;

            Mode = enMode.Update;
        }

        private enError HandleSqlException(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                if (ex.Message.Contains("FK_Booking_Cars")) return enError.CarIDError;
                if (ex.Message.Contains("FK_Booking_Clients")) return enError.ClientIDError;
                if (ex.Message.Contains("FK_Booking_Users")) return enError.UserIDError;
                if (ex.Message.Contains("PK__Bookings__35ABFDE0A3B5AF71")) return enError.BookingIDError;
            }

            return enError.UnknowError;
        }

        private bool _AddBooking() 
        {
            this.BookingID = clsBookingsDataAccessLayer.AddNewBooking(this.CarID, this.ClientID, this.UserID, this.StartDate, this.EndDate, this.TotalPrice);

            return ( this.BookingID != -1 );
        }

        private bool _UpdateBooking() 
        {
            return ( clsBookingsDataAccessLayer.UpdateBooking(this.BookingID, this.CarID, this.ClientID, this.UserID, this.StartDate, this.EndDate, this.TotalPrice) );
        }

        public enError Save() 
        {
            try 
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                    {
                        if (_AddBooking())
                        {
                            Mode = enMode.Update;
                            return enError.NoError;
                        }
                        else
                        {
                            return enError.UnknowError;
                        }
                    }
                    case enMode.Update:
                    {
                        if (_UpdateBooking())
                        {
                            return enError.NoError;
                        }
                        else
                        {
                            return enError.UnknowError;
                        }
                    }
                }
            }
            catch (SqlException ex) 
            {
                return HandleSqlException(ex);
            }

            return enError.UnknowError;
        }

        public static clsBooking GetBookingByID(int BookingID)
        {
            int CarID = -1;
            int ClientID = -1;
            int UserID = -1;
            DateTime StartDate = DateTime.Now;
            DateTime EndDate = DateTime.Now;
            decimal TotalPrice = decimal.Zero;

            if (clsBookingsDataAccessLayer.GetBookingByID(BookingID, ref CarID, ref ClientID, ref UserID, ref StartDate, ref EndDate, ref TotalPrice))
            {
                return new clsBooking(BookingID, CarID, ClientID, UserID, StartDate, EndDate, TotalPrice);
            }

            return null;
        }

        public static DataTable GetBookingsByCarID(int CarID) 
        {
            return ( clsBookingsDataAccessLayer.GetBookingsByCarID(CarID) );
        }

        public static DataTable GetBookingsByClientID(int ClientID)
        {
            return (clsBookingsDataAccessLayer.GetBookingsByClientID(ClientID));
        }

        public static DataTable GetBookingsByUserID(int UserID)
        {
            return (clsBookingsDataAccessLayer.GetBookingsByUserID(UserID));
        }

        public static DataTable GetBookingsByDateRange(DateTime StartDate, DateTime EndDate)
        {
            return (clsBookingsDataAccessLayer.GetBookingsByDateRange(StartDate, EndDate));
        }

        public static DataTable GetBookingsByCarIDAndDateRange(int CarID, DateTime StartDate, DateTime EndDate) 
        {
            return (clsBookingsDataAccessLayer.GetBookingsByCarIDAndDateRange(CarID, StartDate, EndDate));
        }

        public static DataTable GetAllBookings() 
        {
            return ( clsBookingsDataAccessLayer.GetAllBookings() );
        }

        public static bool DeleteBooking(int BookingID) 
        {
            return ( clsBookingsDataAccessLayer.DeleteBooking(BookingID) );
        }

        public static bool IsBookingExistByID(int BookingID) 
        {
            return ( clsBookingsDataAccessLayer.IsBookingExistByID(BookingID) );
        }

        public static bool IsCarBookedInDateRange(int CarID, DateTime StartDate, DateTime EndDate)
        {
            return (clsBookingsDataAccessLayer.IsCarBookedInDateRange(CarID, StartDate, EndDate));
        }

        public static decimal CalculateTotalPrice(int CarID, DateTime StartDate, DateTime EndDate)
        {
            decimal TotalPrice = 0;

            TotalPrice = (clsCar.GetCarByID(CarID).PricePerDay) * (( EndDate - StartDate ).Days + 1);

            return TotalPrice;
        }


    }
}
