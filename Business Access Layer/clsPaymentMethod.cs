using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using System.Data.SqlClient;

namespace BusinessAccessLayer
{
    public class clsPaymentMethod
    {

        public enum enMode { AddNew = 0, Update = 1 }
        enMode Mode = enMode.AddNew;

        public enum enError { NoError = 0, MethodIDError = 1, MethodNameError = 2, UnknownError = 3 }

        public int MethodID { get; set; } = -1;
        public string MethodName { get; set; } = "";

        public clsPaymentMethod() 
        {
            MethodID = -1;
            MethodName = "";

            Mode = enMode.AddNew;
        }

        private clsPaymentMethod(int MethodID, string MethodName)
        {
            this.MethodID = MethodID;
            this.MethodName = MethodName;

            Mode = enMode.Update;
        }

        private enError HandleSqlException(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                if (ex.Message.Contains("PK__Payment___FB48B3C483A5F21F")) return enError.MethodIDError;
                if (ex.Message.Contains("UQ__Payment___05ABA844E499365B")) return enError.MethodNameError;
            }

            return enError.UnknownError;
        }

        private bool _AddMethod() 
        {
            this.MethodID = clsPaymentMethodsDataAccessLayer.AddNewPaymentMethod(this.MethodName);

            return ( this.MethodID != -1 );
        }

        private bool _UpdateMethod() 
        {
            return ( clsPaymentMethodsDataAccessLayer.UpdatePaymentMethod(this.MethodID, this.MethodName));
        }

        public enError Save() 
        {
            try 
            {
                switch (Mode)
                {
                    case enMode.AddNew:
                        {

                            if (_AddMethod())
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
                            if (_UpdateMethod())
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


        public static clsPaymentMethod GetMethodByID(int MethodID)
        {
            string MethodName = "";

            if (clsPaymentMethodsDataAccessLayer.GetPaymentMethodByID(MethodID, ref MethodName))
            { 

                return new clsPaymentMethod(MethodID, MethodName);
            }

            return null;
        }

        public static clsPaymentMethod GetMethodByMethodName(string MethodName)
        {

            int MethodID = -1;

            if (clsPaymentMethodsDataAccessLayer.GetPaymentMethodByName(ref MethodID, MethodName))
            {
                return new clsPaymentMethod(MethodID, MethodName);

            }

            return null;
        }


        public static DataTable GetAllMethods() 
        {
            return ( clsPaymentMethodsDataAccessLayer.GetAllPaymentMethods() );
        }

        public static bool DeleteMethod(int MethodID) 
        {
            return (clsPaymentMethodsDataAccessLayer.DeletePaymentMethod(MethodID) );
        }

        public static bool IsPaymentMethodExistByID(int MethodID) 
        {
            return (clsPaymentMethodsDataAccessLayer.IsPaymentMethodExistByID(MethodID));
        }

        public static bool IsPaymentMethodExistByName(string MethodName)
        {
            return (clsPaymentMethodsDataAccessLayer.IsPaymentMethodExistByName(MethodName));
        }


    }
}
