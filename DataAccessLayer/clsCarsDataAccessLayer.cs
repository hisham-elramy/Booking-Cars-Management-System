using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsCarsDataAccessLayer
    {

        public static int AddNewCar(string Model, int Year, string PlateNumber, string Color, decimal PricePerDay, string ImagePath, bool Status) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"INSERT INTO Cars (Model, Year, Plate_Number, Color, Price_Per_Day, Image_Path, Status)
                             VALUES (@Model, @Year, @PlateNumber, @Color, @PricePerDay, @ImagePath, @Status)

                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Model", Model);
            Command.Parameters.AddWithValue("@Year", Year);
            Command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            Command.Parameters.AddWithValue("@Color", Color);
            Command.Parameters.AddWithValue("@PricePerDay", PricePerDay);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            Command.Parameters.AddWithValue("@Status", Status);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                Connection.Close();

                if (Result != null && int.TryParse(Result.ToString(), out int CarID))
                {
                    return CarID;
                }

                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Connection.Close();
            }

            return -1;
        }

        public static bool GetCarByID(int CarID, ref string Model, ref int Year, ref string PlateNumber,
                                      ref string Color, ref decimal PricePerDay, ref string ImagePath, ref bool Status) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Cars WHERE Car_ID = @CarID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CarID", CarID);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    Model = Reader["Model"].ToString();
                    Year = (int)Reader["Year"];
                    PlateNumber = Reader["Plate_Number"].ToString();
                    Color = Reader["Color"].ToString();
                    PricePerDay = (decimal)Reader["Price_Per_Day"];
                    ImagePath = Reader["Image_Path"].ToString();
                    Status = (bool)Reader["Status"];

                }

                Reader.Close();
                Connection.Close();

                return IsExist;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return IsExist;

        }

        public static bool GetCarByPlateNumber(ref int CarID, ref string Model, ref int Year, string PlateNumber,
                               ref string Color, ref decimal PricePerDay, ref string ImagePath, ref bool Status)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Cars WHERE Plate_Number = @PlateNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PlateNumber", PlateNumber);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    CarID = (int)Reader["Car_ID"];
                    Model = Reader["Model"].ToString();
                    Year = (int)Reader["Year"];
                    Color = Reader["Color"].ToString();
                    PricePerDay = (decimal)Reader["Price_Per_Day"];
                    ImagePath = Reader["Image_Path"].ToString();
                    Status = (bool)Reader["Status"];

                }

                Reader.Close();
                Connection.Close();

                return IsExist;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return IsExist;

        }

        public static DataTable GetAllCars()
        {
            DataTable Cars = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Cars";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Cars.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Cars;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Cars;
        }

        public static DataTable GetAvailableCars(DateTime StartDate, DateTime EndDate)
        {
            DataTable Cars = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Cars
                             WHERE Car_ID Not IN 
                             (
                                SELECT Car_ID FROM Bookings
                                WHERE (Start_Date >= @StartDate AND End_Date <= @EndDate)
                             )
                             AND Status = 1;";

                                            

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StartDate", StartDate);
            Command.Parameters.AddWithValue("@EndDate", EndDate);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Cars.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Cars;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Cars;
        }

        public static DataTable GetAvailableCarsByCarID(DateTime StartDate, DateTime EndDate, int CarID)
        {
            DataTable Cars = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Cars
                             WHERE Car_ID Not IN 
                             (
                                SELECT Car_ID FROM Bookings
                                WHERE (Start_Date >= @StartDate AND End_Date <= @EndDate)
                             ) AND Car_ID = @CarID
                             AND Status = 1;";



            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StartDate", StartDate);
            Command.Parameters.AddWithValue("@EndDate", EndDate);
            Command.Parameters.AddWithValue("@CarID", CarID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Cars.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Cars;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Cars;
        }

        public static bool UpdateCar(int CarID, string Model, int Year, string PlateNumber, string Color, decimal PricePerDay, string ImagePath, bool Status)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"UPDATE Cars
                             SET Model = @Model,
                                 Year = @Year,
                                 Plate_Number = @PlateNumber,
                                 Color = @Color,
                                 Price_Per_Day = @PricePerDay,
                                 Image_Path = @ImagePath,
                                 Status = @Status

                             WHERE Car_ID = @CarID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CarID", CarID);
            Command.Parameters.AddWithValue("@Model", Model);
            Command.Parameters.AddWithValue("@Year", Year);
            Command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            Command.Parameters.AddWithValue("@Color", Color);
            Command.Parameters.AddWithValue("@PricePerDay", PricePerDay);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            Command.Parameters.AddWithValue("@Status", Status);

            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                Connection.Close();

                if (RowsAffected == 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return false; ;
        }

        public static bool DeleteCar(int CarID) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"DELETE FROM Cars WHERE Car_ID = @CarID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CarID", CarID);

            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                Connection.Close();

                if (RowsAffected == 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return false;
        }

        public static bool IsCarExistByID(int CarID) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Cars WHERE Car_ID = @CarID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("CarID", CarID);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                IsExist = Reader.HasRows;

                Reader.Close();
                Connection.Close();

                return IsExist;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return IsExist;
        }

        public static bool IsCarExistByPlateNumber(string PlateNumber)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Cars WHERE Plate_Number = @PlateNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PlateNumber", PlateNumber);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                IsExist = Reader.HasRows;

                Reader.Close();
                Connection.Close();

                return IsExist;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return IsExist;
        }


    }
}
