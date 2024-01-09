using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_primitive_types
{
    internal class Extensions
    {
    }

    public class Book
    {
        public String title = "A Game of Thrones";
        public int publishYear = 1996;
        public float price = 11.99f;
        public String isbn = "0-00-224584-1";
        public String author = "George R. R. Martin";
    }
    public class Car
    {
        public string Make = "Toyota";
        public string Model = "Camry";
        public string TransmissionType = "Automatic";
        public int NumberOfDoors = 4;
        public float EngineLitres = 2.5f;
        public string EngineType = "V6";
        public string Colour = "Red";
        public string Registration = "XYZ1234";
    }
    public class Movie
    {
        public string Title = "Inception";
        public int ReleaseYear = 2010;
        public string Director = "Christopher Nolan";
        public List<string> Cast = new List<string> { "Leonardo DiCaprio", "Joseph Gordon-Levitt", "Ellen Page" };
        public string Genre = "Sci-Fi";
        public float DurationInMinutes = 148f;
    }
    public class Computer
    {
        public string Brand = "Dell";
        public string Model = "XPS 15";
        public string Processor = "Intel Core i7";
        public string RAM = "16GB";
        public string Storage = "512GB SSD";
        public string OperatingSystem = "Windows 10";
        public float ScreenSize = 15.6f;
    }
    public class SocialMediaPost
    {
        public string Author = "JohnDoe";
        public DateTime PostDate = DateTime.Now;
        public string Content = "Hello World!";
        public List<string> Likes = new List<string> { "Alice", "Bob" };
        public List<string> Comments = new List<string> { "Nice post!", "Agreed!" };
    }

    public class User
    {
        public string Username = "JaneDoe";
        public string FullName = "Jane Doe";
        public string Email = "janedoe@example.com";
        public DateTime DateOfBirth = new DateTime(1990, 1, 1);
        public string ProfilePictureUrl = "http://example.com/profile/janedoe.jpg";
    }
    public class EcommerceProduct
    {
        public string Name = "Wireless Headphones";
        public string Description = "Noise-cancelling, over-ear headphones";
        public float Price = 299.99f;
        public int StockQuantity = 50;
        public List<string> Categories = new List<string> { "Electronics", "Audio" };
        public string SKU = "12345ABC";
    }
    public class EcommerceOrder
    {
        public string OrderId = "ORD10234";
        public string CustomerId = "CUST12345";
        public List<EcommerceProduct> Products = new List<EcommerceProduct> { new EcommerceProduct() };
        public float TotalAmount = 299.99f;
        public DateTime OrderDate = DateTime.Now;
        public string ShippingAddress = "123 Main St, Anytown, USA";
        public string Status = "Processing";
    }
    public class Planet
    {
        public string Name = "Earth";
        public double Mass = 1; // Earth masses
        public double DistanceFromSun = 1; // astronomical units
        public double OrbitalPeriod = 1; // Earth years
        public int NumberOfMoons = 1;
    }

}
