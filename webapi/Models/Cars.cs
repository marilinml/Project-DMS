// Base Class Car
using System.Text.Json.Serialization;

namespace webapi.Models;

public class Cars
{
    public int Price { get; set; }
    public string Model { get; set; }
    public int Mileage { get; set; }
    public string Color { get; set; }
    [JsonIgnore]
    public bool Active { get; set; }
    public string Status { get; set; }

    public Cars(Data.Cars cars, string status) 
    {
        Price = cars.Price;
        Model = cars.Model;
        Mileage = cars.Mileage;
        Color = cars.Color;
        Active = cars.Active;
        Status = cars.Active? status: "";
    }
}