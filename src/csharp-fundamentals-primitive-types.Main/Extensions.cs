using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_primitive_types
{
    class Extensions
    {
        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string TransmissionType { get; set; }
            public int NumberOfDoors { get; set; }
            public double EngineLitres { get; set; }
            public string EngineType { get; set; }
            public string Color { get; set; }
            public string Registration { get; set; }
        }

        public class Movie
        {
            public string Title { get; set; }
            public int ReleaseYear { get; set; }
            public string Director { get; set; }
            public double Rating { get; set; }
        }

        public class Computer
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string CPU { get; set; }
            public int RAM { get; set; }
            public int StorageCapacityGB { get; set; }
            public string OperatingSystem { get; set; }
        }

        public class SocialMediaPost
        {
            public string Username { get; set; }
            public string Content { get; set; }
            public DateTime PostDate { get; set; }
            public int Likes { get; set; }
        }

        public class User
        {
            public string Username { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthdate { get; set; }
            public string Email { get; set; }
        }

        public class EcommerceProduct
        {
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
            public int StockQuantity { get; set; }
        }

        public class EcommerceOrder
        {
            public int OrderNumber { get; set; }
            public List<EcommerceProduct> OrderedProducts { get; set; }
            public decimal TotalAmount { get; set; }
            public DateTime OrderDate { get; set; }
        }

    }
}