using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsUsersDataAccessLayer
    {

        public static int AddNewUser(string Name, string Phone, string Address, 
            string NationalID, string Email, string Username, string Password) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"INSERT INTO Users (Name, Phone, Address, National_ID, Email, Username, Hash_Password)
                             VALUES (@Name, @Phone, @Address, @NationalID, @Email, @Username, @Password);
                                
                             SELECT SCOPE_IDENTITY()";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@NationalID", NationalID);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Password", Password);

            int UserID = -1;

            try
            {
                Connection.Open();

                object NewUserID = Command.ExecuteScalar();

                if (NewUserID != null && int.TryParse(NewUserID.ToString(), out int ID))
                {
                    UserID = ID;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error: {ex.Message}");
            }
            finally 
            {
                Connection.Close();
            }

            return UserID;

        }

        public static bool GetUserByID(int UserID, ref string Name, ref string Phone, ref string Address, ref string NationalID,
                                       ref string Email, ref string Username, ref string Password)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Users WHERE User_ID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    Name = Reader["Name"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalID = Reader["National_ID"].ToString();
                    Email = Reader["Email"].ToString();
                    Username = Reader["Username"].ToString();
                    Password = Reader["Hash_Password"].ToString();
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Connection.Close();
            }

            return IsExist;
        }


        public static bool GetUserByUsername(ref int UserID, ref string Name, ref string Phone, ref string Address, ref string NationalID,
                               ref string Email, string Username, ref string Password)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Users WHERE Username = @Username";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Username", Username);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    UserID = (int)Reader["User_ID"];
                    Name = Reader["Name"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalID = Reader["National_ID"].ToString();
                    Email = Reader["Email"].ToString();
                    Password = Reader["Hash_Password"].ToString();
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Connection.Close();
            }

            return IsExist;
        }

        public static bool GetUserByUsernameAndPassword(ref int UserID, ref string Name, ref string Phone, ref string Address, ref string NationalID,
                               ref string Email, string Username, string Password)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"SELECT * FROM Users 
                             WHERE Username = @Username AND Hash_Password = @Password";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Password", Password);

            bool IsExist = false;

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsExist = true;

                    UserID = (int)Reader["User_ID"];
                    Name = Reader["Name"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Address = Reader["Address"].ToString();
                    NationalID = Reader["National_ID"].ToString();
                    Email = Reader["Email"].ToString();
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Connection.Close();
            }

            return IsExist;
        }

        public static DataTable GetAllUsers()
        {

            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = "SELECT * FROM Users";

            SqlCommand Command = new SqlCommand(Query, Connection);

            DataTable Users = new DataTable();

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();


                if (Reader.HasRows)
                {
                    Users.Load(Reader);
                }

                Reader.Close();
                Connection.Close();

                return Users;
            }

            catch (Exception ex)
            {
                //Console.WriteLine($"Error: {ex.Message}");
            }

            return Users;
        }

        public static bool UpdateUser(int UserID, string Name, string Phone, string Address, 
                                      string NationalID, string Email, string Username, string Password)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = @"UPDATE Users
                             SET Name = @Name,
                                 Phone = @Phone,
                                 Address = @Address,
                                 National_ID = @NationalID,
                                 Email = @Email,
                                 Username = @Username,
                                 Hash_Password = @Password
                             WHERE User_ID = @UserID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@NationalID", NationalID);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Username", Username);
            Command.Parameters.AddWithValue("@Password", Password);

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
                //Console.WriteLine($"Error: {ex.Message}");
            }

            return false;
        }

        public static bool DeleteUser(int UserID) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = "DELETE FROM Users WHERE User_ID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

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
                //Console.WriteLine($"Error: {ex.Message}");
            }

            return false;
        }

        public static bool IsUserExistByID(int UserID) 
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = "SELECT 1 FROM Users WHERE User_ID = @UserID";


            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

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
                //Console.WriteLine($"Error: {ex.Message}");
            }

            return IsExist;
        }

        public static bool IsUserExistByUsername(string Username)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = "SELECT 1 FROM Users WHERE Username = @Username";


            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Username", Username);

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
                //Console.WriteLine($"Error: {ex.Message}");
            }

            return IsExist;
        }

        public static bool IsUserExistByEmail(string Email)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = "SELECT 1 FROM Users WHERE Email = @Email";


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

                return IsExist;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error: {ex.Message}");
            }

            return IsExist;
        }

        public static bool IsUserExistByPhone(string Phone)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = "SELECT 1 FROM Users WHERE Phone = @Phone";


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

                return IsExist;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error: {ex.Message}");
            }

            return IsExist;
        }


        public static bool IsUserExistByNationalID(string NationalID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings.Connection);

            string Query = "SELECT 1 FROM Users WHERE National_ID = @NationalID";


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

                return IsExist;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error: {ex.Message}");
            }

            return IsExist;
        }

    }
}
