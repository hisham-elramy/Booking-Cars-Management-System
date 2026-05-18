using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsBookingsDataAccessLayer
    {

        public static int AddNewBooking(int CarID, int ClientID, int UserID, DateTime StartDate, DateTime EndDate, decimal TotalPrice) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"INSERT INTO Bookings (Car_ID, Client_ID, User_ID, Start_Date, End_Date, Total_Price)
                             VALUES (@CarID, @ClientID, @UserID, @StartDate, @EndDate, @TotalPrice);
            
                             SELECT SCOPE_IDENTITY()";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CarID", CarID);
            Command.Parameters.AddWithValue("@ClientID", ClientID); 
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@StartDate", StartDate);
            Command.Parameters.AddWithValue("@EndDate", EndDate);
            Command.Parameters.AddWithValue("@TotalPrice", TotalPrice);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                Connection.Close();

                if (Result != null && int.TryParse(Result.ToString(), out int BookingID))
                {
                    return BookingID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return -1;
        }

        public static bool GetBookingByID(int BookingID, ref int CarID, ref int ClientID, ref int UserID,
                                          ref DateTime StartDate, ref DateTime EndDate, ref decimal TotalPrice)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Bookings WHERE Booking_ID = @BookingID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@BookingID", BookingID);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    CarID = (int)Reader["Car_ID"];
                    ClientID = (int)Reader["Client_ID"];
                    UserID = (int)Reader["User_ID"];
                    StartDate = (DateTime)Reader["Start_Date"];
                    EndDate = (DateTime)Reader["End_Date"];
                    TotalPrice = (decimal)Reader["Total_Price"];
                }

                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return IsExist;
        }

        public static DataTable GetBookingsByCarID(int CarID) 
        {   
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Bookings WHERE Car_ID = @CarID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CarID", CarID);

            DataTable Bookings = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Bookings.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Bookings;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Bookings;
        }

        public static DataTable GetBookingsByClientID(int ClientID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Bookings WHERE Client_ID = @ClientID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ClientID);

            DataTable Bookings = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Bookings.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Bookings;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Bookings;
        }

        public static DataTable GetBookingsByUserID(int UserID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Bookings WHERE User_ID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            DataTable Bookings = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Bookings.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Bookings;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Bookings;
        }

        public static DataTable GetBookingsByDateRange(DateTime StartDate, DateTime EndDate)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Bookings WHERE (Start_Date >= @StartDate AND End_Date <= @EndDate)";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StartDate", StartDate);
            Command.Parameters.AddWithValue("@EndDate", EndDate);

            DataTable Bookings = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Bookings.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Bookings;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Bookings;
        }

        public static DataTable GetBookingsByCarIDAndDateRange(int CarID, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Bookings WHERE (Start_Date >= @StartDate AND End_Date <= @EndDate AND Car_ID = @CarID)";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CarID", CarID);
            Command.Parameters.AddWithValue("@StartDate", StartDate);
            Command.Parameters.AddWithValue("@EndDate", EndDate);

            DataTable Bookings = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Bookings.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Bookings;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Bookings;
        }

        public static DataTable GetAllBookings() 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Bookings";

            SqlCommand Command = new SqlCommand(Query, Connection);
 
            DataTable Bookings = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Bookings.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Bookings;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Bookings;

        }

        public static bool UpdateBooking(int BookingID, int CarID, int ClientID, int UserID, DateTime StartDate, DateTime EndDate, decimal TotalPrice) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"UPDATE Bookings
                             SET Car_ID = @CarID,
                                 Client_ID = @ClientID,
                                 User_ID = @UserID,
                                 Start_Date = @StartDate,
                                 End_Date = @EndDate,
                                 Total_Price = @TotalPrice
                             WHERE Booking_ID = @BookingID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@BookingID", BookingID);
            Command.Parameters.AddWithValue("@CarID", CarID);
            Command.Parameters.AddWithValue("@ClientID", ClientID);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@StartDate", StartDate);
            Command.Parameters.AddWithValue("@EndDate", EndDate);
            Command.Parameters.AddWithValue("@TotalPrice", TotalPrice);

            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                Connection.Close();

                if (RowsAffected == 0)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return false;
        }

        public static bool DeleteBooking(int BookingID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"DELETE FROM Bookings WHERE Booking_ID = @BookingID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("BookingID", BookingID);

            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                if (RowsAffected == 0)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return false;
        }

        public static bool IsBookingExistByID(int BookingID) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Bookings WHERE Booking_ID = @BookingID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@BookingID", BookingID);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                IsExist = Reader.HasRows;

                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return IsExist;
        }

        public static bool IsCarBookedInDateRange(int CarID, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Bookings WHERE (Car_ID = @CarID AND Start_Date < @EndDate AND End_Date > @StartDate);";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CarID", CarID);
            Command.Parameters.AddWithValue("@StartDate", StartDate);
            Command.Parameters.AddWithValue("@EndDate", EndDate);

            bool IsBooked = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                IsBooked = Reader.HasRows;

                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return IsBooked;
        }




    }
}
