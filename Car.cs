using System;
using Microsoft.Data.SqlClient;

namespace CarRentalManagementSystem_V2
{

    public class Car
    {
      
       public string CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal RentalPrice { get; set; }

        public Car(string carId, string brand, string model, decimal rentalPrice) 
        {
            CarId = carId;
            Brand = brand;
            Model = model;
            RentalPrice = rentalPrice;
  
        }
    }
}