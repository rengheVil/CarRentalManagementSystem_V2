
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace CarRentalManagementSystem_V2{

    public class CarRepository{
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB; Database = CarRentalManagement; TrustServerCertificate=True; Integrated Security = true";

    private string CapitalizeBrand(string brand){
        return System.Globalization.Culture.TextInfo.ToTitleCase(brand.ToLower());
    }

    public decimal ValidateCarRentalPrice(){
        decimal rentalPrice;
        while(true){
            Console.WriteLine("Enter Rental Price: ");
            if (decimal.TryParse(Console.ReadLine(), out rentalPrice) && rentalPrice > 0){
                break;
            }
            else{
                Console.WriteLine("Invalied input. Please enter a positive rental price. ");
            }
        }
        return rentalPrice;
    }

    public void AddCar(Car car){
        string quary ="INSERT INTO CARS (Brand, Model, RentalPrice) VALUES (@Brand, @Model, @RentalPrice)";
        using (var connection = new SqlConnection(connectionString)){
            using (var command = new SqlCommand(query, connection)){
                try{
                    command.Parameters.AddWithValue("@Brand", CapitalizeBrand(car.CarId));
                  command.Parameters.AddWithValue(@model, car.Model);command.Parameters.AddWithValue("@RentalPrice", car.RentalPrice);
                  connection.Open();
                  command.ExecuteNonQuery();
                  Console.WriteLine("Car added successfully.");
                }
                catch (Exception ex){
                    Console.WriteLine($"Error adding car: {ex.Message}");
                }
            }
        }
    }

    public static List<Car> GetCars(){
        List<Car> cars = new List<Car>();
    }


    }
}