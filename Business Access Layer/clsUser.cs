using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BusinessAccessLayer
{
    public class clsUser
    {

        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;
        public enum enError { NoErrors = 0, UsernameError = 1, UserIDError = 2, NationalIDError = 3, PhoneError = 4, EmailError= 5, UnKnownError = 6 }


        public int UserID { get; set; } = -1;
        public string Name { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string Email { get; set; } = "";
        public string NationalID { get; set; } = "";
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";


        public clsUser()
        {
            this.UserID = -1;
            this.Name = "";
            this.Phone = "";
            this.Address = "";
            this.Email = "";
            this.NationalID = "";
            this.Username = "";
            this.Password = "";

            Mode = enMode.AddNew;
        }

        private clsUser(int userID, string name, string phone, string address, string email, string nationalID, string username, string password)
        {
            UserID = userID;
            Name = name;
            Phone = phone;
            Address = address;
            Email = email;
            NationalID = nationalID;
            Username = username;
            Password = password;

            Mode = enMode.Update;
        }
        private enError HandleSqlException(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                if (ex.Message.Contains("PK__Users__206D919057E2E483")) return enError.UserIDError;
                if (ex.Message.Contains("UQ__Users__2C578784A6A5E57E")) return enError.NationalIDError;
                if (ex.Message.Contains("UQ__Users__536C85E47C36BE2C")) return enError.UsernameError;
                if (ex.Message.Contains("UQ__Users__5C7E359E952E5FF5")) return enError.PhoneError;
                if (ex.Message.Contains("UQ__Users__A9D1053490051B0F")) return enError.EmailError;
            }

            return enError.UnKnownError;
        }


        private bool _AddNewUser()
        {
            this.UserID = clsUsersDataAccessLayer.AddNewUser(this.Name, this.Phone, this.Address, this.NationalID, this.Email, this.Username, this.Password);

            return (UserID != -1);
        }

        private bool _UpdateUser()
        {
            if (clsUsersDataAccessLayer.UpdateUser(this.UserID, this.Name, this.Phone, this.Address,this.NationalID,this.Email, this.Username, this.Password))
            {
                return true;
            }

            return false;
        }

        public enError Save()
        {
            try
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                        {
                            if (_AddNewUser())
                            {
                                Mode = enMode.Update;
                                return enError.NoErrors;
                            }
                            else
                            {
                                return enError.UnKnownError;
                            }
                        }
                    case enMode.Update:
                        {
                            if (_UpdateUser())
                            { 
                                return enError.NoErrors;
                            }
                            else
                            {
                                return enError.UnKnownError;
                            }

                        }
                }
            }
            catch (SqlException ex)
            {
                return HandleSqlException(ex);
            }

            return enError.UnKnownError;
        }

        public static clsUser GetUserByID(int UserID)
        {

            string Name = "";
            string Phone = "";
            string Address = "";
            string NationalID = "";
            string Email = "";
            string Username = "";
            string Password = "";

           

            if (clsUsersDataAccessLayer.GetUserByID(UserID, ref Name, ref Phone, ref Address, ref NationalID, ref Email, ref Username, ref Password))
            {
                return new clsUser(UserID, Name, Phone, Address, Email, NationalID, Username, Password);
            }

            return null;
        }

        public static clsUser GetUserByUsername(string Username)
        {
            int UserID = -1;
            string Name = "";
            string Phone = "";
            string Address = "";
            string NationalID = "";
            string Email = "";
            string Password = "";



            if (clsUsersDataAccessLayer.GetUserByUsername(ref UserID, ref Name, ref Phone, ref Address, ref NationalID, ref Email, Username, ref Password))
            {
                return new clsUser(UserID, Name, Phone, Address, Email, NationalID, Username, Password);
            }

            return null;
        }

        public static clsUser GetUserByUsernameAndPassword(string Username, string Password)
        {

            int UserID = -1;
            string Name = "";
            string Phone = "";
            string Address = "";
            string NationalID = "";
            string Email = "";



            if (clsUsersDataAccessLayer.GetUserByUsernameAndPassword(ref UserID, ref Name, ref Phone, ref Address, ref NationalID, ref Email, Username,  Password))
            {
                return new clsUser(UserID, Name, Phone, Address, Email, NationalID, Username, Password);
            }

            return null;
        }

        public static DataTable GetAllUsers() 
        {
            return (clsUsersDataAccessLayer.GetAllUsers());
        }

        public static bool DeleteUser(int UserID) 
        {
            return clsUsersDataAccessLayer.DeleteUser(UserID);
        }

        public static bool IsUserExistByID(int UserID) 
        {
            return clsUsersDataAccessLayer.IsUserExistByID(UserID);
        }

        public static bool IsUserExistByUsername(string Username)
        {
            return clsUsersDataAccessLayer.IsUserExistByUsername(Username);
        }

        public static bool IsUserExistByEmail(string Email)
        {
            return clsUsersDataAccessLayer.IsUserExistByEmail(Email);
        }

        public static bool IsUserExistByPhone(string Phone)
        {
            return clsUsersDataAccessLayer.IsUserExistByPhone(Phone);
        }

        public static bool IsUserExistByNationalID(string NationalID)
        {
            return clsUsersDataAccessLayer.IsUserExistByNationalID(NationalID);
        }



    }
}
