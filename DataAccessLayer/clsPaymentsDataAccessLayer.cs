using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsPaymentsDataAccessLayer
    {

        public static int AddNewPayment(int BookingID, DateTime PaymentDate, int PaymentMethodID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"INSERT INTO Payments (Booking_ID, Payment_Date, Payment_Method_ID)
                             VALUES (@BookingID, @PaymentDate, @PaymentMethodID);

                             SELECT SCOPE_IDENTITY()";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@BookingID", BookingID);
            Command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            Command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                Connection.Close();

                if (Result != null && int.TryParse(Result.ToString(), out int PaymentID))
                {
                    return PaymentID;
                }

                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return -1;
        }

        public static bool GetPaymentByID(int PaymentID, ref int BookingID, ref DateTime PaymentDate, ref int PaymentMethodID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECt * FROM Payments WHERE Payment_ID = @PaymentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PaymentID", PaymentID);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    BookingID = (int)Reader["Booking_ID"];
                    PaymentDate = (DateTime)Reader["Payment_Date"];
                    PaymentMethodID = (int)Reader["Payment_Method_ID"];
                }

                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Connection.Close();
            }

            return IsExist;
        }

        public static bool GetPaymentByBookingID(ref int PaymentID, int BookingID, ref DateTime PaymentDate, ref int PaymentMethodID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECt * FROM Payments WHERE Booking_ID = @BookingID;";

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

                    PaymentID = (int)Reader["Payment_ID"];
                    PaymentDate = (DateTime)Reader["Payment_Date"];
                    PaymentMethodID = (int)Reader["Payment_Method_ID"];
                }

                Reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Connection.Close();
            }

            return IsExist;
        }

        public static DataTable GetAllPayments()
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Payments";

            SqlCommand Command = new SqlCommand(Query, Connection);

            DataTable Payments = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Payments.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Payments;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Payments;
        }

        public static bool UpdatePayment(int PaymentID, int BookingID, DateTime PaymentDate, int PaymentMethodID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"UPDATE Payments
                             SET Booking_ID = @BookingID,
                                 Payment_Date = @PaymentDate,
                                 Payment_Method_ID = @PaymentMethodID
                              WHERE Payment_ID = @PaymentID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PaymentID", PaymentID);
            Command.Parameters.AddWithValue("@BookingID", BookingID);
            Command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
            Command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);

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

        public static bool DeletePayment(int PaymentID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"DELETE FROM Payments WHERE Payment_ID = @PaymentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PaymentID", PaymentID);

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

        public static bool IsPaymentExistByID(int PaymentID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Payments WHERE Payment_ID = @PaymentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PaymentID", PaymentID);

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

        public static bool IsPaymentExistByBookingID(int BookingID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Payments WHERE Booking_ID = @BookingID";

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
    }
}
