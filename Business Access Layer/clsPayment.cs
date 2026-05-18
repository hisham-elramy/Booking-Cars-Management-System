using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BusinessAccessLayer
{
    public class clsPayment
    {

        public enum enMode { Add= 0, Update = 1 }
        public enMode Mode = enMode.Add;

        public enum enError { NoError = 0, PaymentIDError = 1, BookingIDError = 2, PaymentDateError = 3, MethodIDError = 4, UnknownError = 5 }

        public int PaymentID { get; set; } = -1;

        public int BookingID { get; set; } = -1;

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        public int MethodID { get; set; } = -1;

        public clsPayment() 
        {   
            PaymentID = -1;
            BookingID = -1;
            PaymentDate = DateTime.Now;
            MethodID = -1;

            Mode = enMode.Add;
        }

        private clsPayment(int PaymentID, int BookingID, DateTime PaymentDate, int MethodID)
        {
            this.PaymentID = PaymentID;
            this.BookingID = BookingID;
            this.PaymentDate = PaymentDate;
            this.MethodID = MethodID;

            Mode = enMode.Update;
        }

        private enError HandleSqlException(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                if (ex.Message.Contains("FK_Payment_Bookings")) return enError.BookingIDError;
                if (ex.Message.Contains("FK_Payment_Methods")) return enError.MethodIDError;
                if (ex.Message.Contains("PK__Payments__DA6C7FE14CA3C6EA")) return enError.PaymentIDError;
            }

            return enError.UnknownError;
        }


        private bool _AddPayment() 
        {
            this.PaymentID = clsPaymentsDataAccessLayer.AddNewPayment(this.BookingID, this.PaymentDate, this.MethodID);

            return (this.PaymentID != -1);
        }

        private bool _UpdatePayment() 
        {
            return (clsPaymentsDataAccessLayer.UpdatePayment(this.PaymentID, this.BookingID, this.PaymentDate, this.MethodID));
        }

        public enError Save() 
        {

            try
            {
                switch (Mode)
                {
                    case enMode.Add:
                        {
                            if (_AddPayment())
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
                            if (_UpdatePayment())
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

        public static clsPayment GetPaymentByID(int PaymentID)
        {
            int BookingID = -1;
            DateTime PaymentDate = DateTime.Now;
            int MethodID = -1;

            if (clsPaymentsDataAccessLayer.GetPaymentByID(PaymentID, ref BookingID, ref PaymentDate, ref MethodID))
            {
                
                return new clsPayment(PaymentID, BookingID, PaymentDate, MethodID);
            }

            return null;
        }

        public static clsPayment GetPaymentByBookingID(int BookingID)
        {

            int PaymentID = -1;
            DateTime PaymentDate = DateTime.Now;
            int MethodID = -1;

            if (clsPaymentsDataAccessLayer.GetPaymentByBookingID(ref PaymentID, BookingID, ref PaymentDate, ref MethodID))
            {
                return new clsPayment(PaymentID, BookingID, PaymentDate, MethodID);

            }

            return null;
        }

        public static DataTable GetAllPayments() 
        {
            return (clsPaymentsDataAccessLayer.GetAllPayments());
        }

        public static bool DeletePayment(int PaymentID) 
        {
            return (clsPaymentsDataAccessLayer.DeletePayment(PaymentID));
        }

        public static bool IsPaymentExistByID(int PaymentID) 
        {
            return (clsPaymentsDataAccessLayer.IsPaymentExistByID(PaymentID));
        }

        public static bool IsPaymentExistByBookingID(int BookingID)
        {
            return (clsPaymentsDataAccessLayer.IsPaymentExistByBookingID(BookingID));
        }
    }
}
