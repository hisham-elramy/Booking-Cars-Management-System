using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPaymentMethodsDataAccessLayer
    {

        public static int AddNewPaymentMethod(string MethodName) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"INSERT INTO Payment_Methods (Method_Name)
                            VALUES (@MethodName)
                            
                            SELECT SCOPE_IDENTITY();";
        
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@MethodName", MethodName);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                Connection.Close();

                if (Result != null && int.TryParse(Result.ToString(), out int MethodID))
                {
                    return MethodID;
                }

                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return -1;
        }

        public static bool GetPaymentMethodByID(int MethodID, ref string MethodName) 
        {
            SqlConnection Connection = new SqlConnection (clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Payment_Methods WHERE Method_ID = @MethodID";

            SqlCommand Command = new SqlCommand (Query, Connection);
            Command.Parameters.AddWithValue("@MethodID", MethodID);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    MethodName = Reader["Method_Name"].ToString();
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

        public static bool GetPaymentMethodByName(ref int MethodID, string MethodName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Payment_Methods WHERE Method_Name = @MethodName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@MethodName", MethodName);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    MethodID = (int)Reader["Method_ID"];
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

        public static DataTable GetAllPaymentMethods() 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Payment_Methods";

            SqlCommand Command = new SqlCommand(Query, Connection);

            DataTable Methods = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Methods.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Methods;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Methods;
        }

        public static bool UpdatePaymentMethod(int MethodID, string MethodName)
        {
            SqlConnection Connection = new SqlConnection (clsDataAccessLayerSettings.Connection);

            string Query = @"UPDATE Payment_Methods
                             SET Method_Name = @MethodName
                             WHERE Method_ID = @MethodID;";

            SqlCommand Command = new SqlCommand (Query, Connection);
            Command.Parameters.AddWithValue("@MethodID", MethodID);
            Command.Parameters.AddWithValue("@MethodName", MethodName);

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

        public static bool DeletePaymentMethod(int MethodID) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"DELETE FROM Payment_Methods WHERE Method_ID = @MethodID";

            SqlCommand Command = new SqlCommand (Query, Connection);
            Command.Parameters.AddWithValue("MethodID", MethodID);

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

        public static bool IsPaymentMethodExistByID(int MethodID) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Payment_Methods WHERE Method_ID = @MethodID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@MethodID", MethodID);

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

        public static bool IsPaymentMethodExistByName(string MethodName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Payment_Methods WHERE Method_Name = @MethodName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@MethodName", MethodName);

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
