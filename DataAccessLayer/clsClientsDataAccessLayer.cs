using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsClientsDataAccessLayer
    {

        public static int AddNewClient(string Name, string Email, string Phone, string Address, string NationalID) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"INSERT INTO Clients (Name, Email, Phone, Address, National_ID)
                             Values (@Name, @Email, @Phone, @Address, @NationalID)

                             SELECT SCOPE_IDENTITY()";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@NationalID", NationalID);

            int ID = -1;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ClientID))
                {
                    ID = ClientID;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally 
            {
                Connection.Close();
            }

            return ID;
        }

        public static bool GetClientByID(int ClientID, ref string Name, ref string Email, ref string Phone, ref string Address, ref string NationalID) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Clients WHERE Client_ID = @ClientID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ClientID);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    Name = Reader["Name"].ToString();
                    Email = Reader["Email"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalID = Reader["National_ID"].ToString();
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

        public static bool GetClientByPhone(ref int ClientID, ref string Name, ref string Email, string Phone, ref string Address, ref string NationalID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Clients WHERE Phone = @Phone";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Phone", Phone);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    ClientID = (int)Reader["Client_ID"];
                    Name = Reader["Name"].ToString();
                    Email = Reader["Email"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalID = Reader["National_ID"].ToString();
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

        public static bool GetClientByEmail(ref int ClientID, ref string Name, string Email, ref string Phone, ref string Address, ref string NationalID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Clients WHERE Email = @Email";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Email", Email);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    ClientID = (int)Reader["Client_ID"];
                    Name = Reader["Name"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalID = Reader["National_ID"].ToString();
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

        public static bool GetClientByNationalID(ref int ClientID, ref string Name, ref string Email, ref string Phone, ref string Address, string NationalID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Clients WHERE National_ID = @NationalID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalID", NationalID);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    ClientID = (int)Reader["Client_ID"];
                    Name = Reader["Name"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Email = Reader["Email"].ToString();
                    Address = Reader["Address"].ToString();
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

        public static DataTable GetAllClients() 
        {
            DataTable Clients = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Clients";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    Clients.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Clients;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return Clients;
        }

        public static bool UpdateClient(int ClientID, string Name, string Email, string Phone, string Address, string NationalID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"UPDATE Clients
                             SET Name = @Name,
                                 Email = @Email,
                                 Phone = @Phone,
                                 Address = @Address,
                                 National_ID = @NationalID
                             WHERE Client_ID = @ClientID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ClientID);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@NationalID", NationalID);

            try 
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                Connection.Close();

                if (RowsAffected ==0)
                    return false;

                return true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return false;
        }

        public static bool DeleteClient(int ClientID) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"DELETE FROM Clients WHERE Client_ID = @ClientID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool IsClientExistByID(int ClientID) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Clients WHERE Client_ID = @ClientID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static bool IsClientExistByPhone(string Phone)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Clients WHERE Phone = @Phone";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Phone", Phone);

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

        public static bool IsClientExistByEmail(string Email)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Clients WHERE Email = @Email";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Email", Email);

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

        public static bool IsClientExistByNationalID(string NationalID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT 1 FROM Clients WHERE National_ID = @NationalID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalID", NationalID);

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
