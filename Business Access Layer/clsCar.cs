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
    public class clsCar
    {

        public enum enMode{ AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public enum enError { NoError = 0, CarIDError = 1, PlateNumberError = 2, UnknownError = 3 }

        public int CarID { get; set; } = -1;

        public string Model { get; set; } = "";
        public int Year { get; set; } = -1;

        public string PlateNumber { get; set; } = "";

        public string Color { get; set; } = "";
        public decimal PricePerDay { get; set; } = decimal.Zero;

        public string ImagePath { get; set; } = "";

        public bool Status { get; set; } = false;

        public clsCar() 
        {
            CarID = -1;
            Model = "";
            Year = -1;
            PlateNumber = "";
            Color = "";
            PricePerDay = decimal.Zero;
            ImagePath = "";
            Status = false;

            Mode = enMode.AddNew;
        }

        private clsCar(int CarID, string Model, int Year, string PlateNumber, string Color, decimal PricePerDay, string ImagePath, bool Status)
        {
            this.CarID = CarID;
            this.Model = Model;
            this.Year = Year;
            this.PlateNumber = PlateNumber;
            this.Color = Color;
            this.PricePerDay = PricePerDay;
            this.ImagePath = ImagePath;
            this.Status = Status;

            Mode = enMode.Update;
        }

        private enError HandleSqlException(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                if (ex.Message.Contains("PK__Cars__523653D916664907")) return enError.CarIDError;
                if (ex.Message.Contains("UQ__Cars__5834C12540A93FFA")) return enError.PlateNumberError;
            }

            return enError.UnknownError;
        }

        private bool _AddCar() 
        {
            this.CarID = clsCarsDataAccessLayer.AddNewCar(this.Model, this.Year, this.PlateNumber, this.Color, this.PricePerDay, this.ImagePath, this.Status);

            return ( this.CarID != -1 );
        }

        private bool _UpdateCar() 
        {
            return ( clsCarsDataAccessLayer.UpdateCar(this.CarID, this.Model, this.Year, this.PlateNumber, this.Color, this.PricePerDay, this.ImagePath, this.Status));
        }

        public enError Save() 
        {
            try 
            {
                switch (Mode) 
                {
                    case enMode.AddNew:
                        {

                            if (_AddCar())
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
                            if (_UpdateCar())
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

        public static clsCar GetCarByID(int CarID)
        {
            string Model = "";
            int Year = -1;
            string PlateNumber = "";
            string Color = "";
            decimal PricePerDay = decimal.Zero;
            string ImagePath = "";
            bool Status = false;

            if (clsCarsDataAccessLayer.GetCarByID(CarID, ref Model, ref Year, ref PlateNumber, ref Color, ref PricePerDay, ref ImagePath, ref Status))
            {
          
                return new clsCar(CarID, Model, Year, PlateNumber, Color, PricePerDay, ImagePath, Status);
            }

            return null;
        }

        public static clsCar GetCarByPlateNumber(string PlateNumber)
        {
            int CarID = -1;
            string Model = "";
            int Year = -1;
            string Color = "";
            decimal PricePerDay = decimal.Zero;
            string ImagePath = "";
            bool Status = false;

            if (clsCarsDataAccessLayer.GetCarByPlateNumber(ref CarID, ref Model, ref Year, PlateNumber, ref Color, ref PricePerDay, ref ImagePath, ref Status))
            {
                return new clsCar(CarID, Model, Year, PlateNumber, Color, PricePerDay, ImagePath, Status);

            }

            return null;
        }

        public static DataTable GetAllCars() 
        {
            return ( clsCarsDataAccessLayer.GetAllCars() );
        }

        public static DataTable GetAvailableCars(DateTime StartDate, DateTime EndDate) 
        {
            return ( clsCarsDataAccessLayer.GetAvailableCars(StartDate, EndDate) );
        }

        public static DataTable GetAvailableCarsByCarID(DateTime StartDate, DateTime EndDate, int CarID)
        {
            return (clsCarsDataAccessLayer.GetAvailableCarsByCarID(StartDate, EndDate, CarID));
        }

        public static bool DeleteCar(int CarID)
        {
            return ( clsCarsDataAccessLayer.DeleteCar(CarID) );
        }

        public static bool IsCarExistByID(int CarID) 
        {
            return ( clsCarsDataAccessLayer.IsCarExistByID(CarID) );
        }

        public static bool IsCarExistByPlateNumber(string PlateNumber)
        {
            return ( clsCarsDataAccessLayer.IsCarExistByPlateNumber(PlateNumber) );
        }


    }
}
