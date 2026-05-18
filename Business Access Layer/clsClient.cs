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
    public class clsClient
    {

        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public enum enError { NoError = 0, ClientIDError = 1, NationalIDError = 2, PhoneError = 3, EmailError = 4, UnknownError = 5 }
        
        public int ClientID { get; set; } = -1;
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string NationalID { get; set; } = "";

        public clsClient() 
        {
            ClientID = -1;
            Name = "";
            Email = "";
            Phone = "";
            Address = "";
            NationalID = "";

            Mode = enMode.AddNew;
        }

        private clsClient(int ClientID, string Name, string Email, string Phone, string Address, string NationalID) 
        {
            this.ClientID = ClientID;
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.NationalID = NationalID;

            Mode = enMode.Update;
        }

        private enError HandleSqlException(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                if (ex.Message.Contains("PK__Clients__75A5D7182711D0AA")) return enError.ClientIDError;
                if (ex.Message.Contains("UQ__Clients__2C57878431B35C1D")) return enError.NationalIDError;
                if (ex.Message.Contains("UQ__Clients__5C7E359EFEA2CA18")) return enError.PhoneError;
                if (ex.Message.Contains("UQ__Clients__A9D10534E16F8C50")) return enError.EmailError;
            }

            return enError.UnknownError;
        }

        private bool _AddClient() 
        {
            this.ClientID = clsClientsDataAccessLayer.AddNewClient(this.Name, this.Email, this.Phone, this.Address, this.NationalID);

            return ( ClientID != -1 );
        }

        private bool _UpdateClient() 
        {
            return ( clsClientsDataAccessLayer.UpdateClient(this.ClientID, this.Name, this.Email, this.Phone, this.Address, this.NationalID) );
        }

        public enError Save()
        {
            try
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                    {
                        if (_AddClient())
                        {
                            Mode = enMode.Update;
                            return enError.NoError;
                        }
                        else
                        {
                            return enError.UnknownError;
                        }
                    }
                    case enMode.Update:
                    {
                        if (_UpdateClient())
                        {
                            return enError.NoError;
                        }
                        else
                        {
                            return enError.UnknownError;
                        }
                    }
                }
            }
            catch (SqlException ex) 
            {
                return HandleSqlException(ex);
            }
            return enError.UnknownError;           
        }

        public static clsClient GetClientByID(int ClientID)
        {
    
            string Name = "";
            string Email = "";
            string Phone = "";
            string Address = "";
            string NationalID = "";

            if (clsClientsDataAccessLayer.GetClientByID(ClientID, ref Name, ref Email, ref Phone, ref Address, ref NationalID))
            {
      
                return new clsClient(ClientID, Name, Email, Phone, Address, NationalID);
            }

            return null;
        }

        public static clsClient GetClientByPhone(string Phone)
        {
            int ClientID = -1;
            string Name = "";
            string Email = "";
            string Address = "";
            string NationalID = "";

            if (clsClientsDataAccessLayer.GetClientByPhone(ref ClientID, ref Name, ref Email, Phone, ref Address, ref NationalID))
            {
                return new clsClient(ClientID, Name, Email, Phone, Address, NationalID);

            }

            return null;
        }

        public static clsClient GetClientByEmail(string Email)
        {
            int ClientID = -1;
            string Name = "";
            string Phone = "";
            string Address = "";
            string NationalID = "";

            if (clsClientsDataAccessLayer.GetClientByEmail(ref ClientID, ref Name, Email, ref Phone, ref Address, ref NationalID))
            {
                return new clsClient(ClientID, Name, Email, Phone, Address, NationalID);

            }

            return null;
        }

        public static clsClient GetClientByNationalID(string NationalID)
        {
     
            int ClientID = -1;
            string Name = "";
            string Email = "";
            string Phone = "";
            string Address = "";

            if (clsClientsDataAccessLayer.GetClientByNationalID(ref ClientID, ref Name, ref Email, ref Phone, ref Address, NationalID))
            {
                return new clsClient(ClientID, Name, Email, Phone, Address, NationalID);
            }

            return null;
        }

        public static DataTable GetAllClients() 
        {
            return ( clsClientsDataAccessLayer.GetAllClients() );
        }

        public static bool DeleteClient(int ClientID) 
        {
            return ( clsClientsDataAccessLayer.DeleteClient(ClientID) );
        }

        public static bool IsClientExistByID(int ClientID)
        {
            return ( clsClientsDataAccessLayer.IsClientExistByID(ClientID) );
        }
        public static bool IsClientExistByPhone(string Phone)
        {
            return (clsClientsDataAccessLayer.IsClientExistByPhone(Phone));
        }
        public static bool IsClientExistByEmail(string Email)
        {
            return (clsClientsDataAccessLayer.IsClientExistByEmail(Email));
        }

        public static bool IsClientExistByNationalID(string NationalID)
        {
            return (clsClientsDataAccessLayer.IsClientExistByNationalID(NationalID));
        }

    }
}
