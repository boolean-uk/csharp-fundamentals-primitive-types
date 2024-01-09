using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_primitive_types
{
    internal class Extensions
    {
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
            public String Make = "Volkswagen";
            public String model = "Passat";
            public String transmissionType = "Automatic";
            public float engineLitres = 2.0f;
            public String engineType = "Inline-4";
            public String color = "Midnight Blue";
            public String registration = "VXG 789A";
        }

        public class Movie 
        {
            // Key info
            public string title = "John Wick";
            public string synopsis = "A retired hitman seeks vengeance for the killing of his dog.";
            public int year = 2014;
            public String genre = "Action";
            public String language = "English";

            // Performance
            public float budget = 20000000f;
            public float boxOffice = 88076124f;
            public float rating = 7.4f;

            // Productions
            public string director = "Chad Stahelski";
            public string studio = "Lionsgate";
            public string cinematographer = "Jonathan Sela";
            public string[] actors = { "Keanu Reeves", "Ian McShane" };
        }

        public class Computer 
        {
            // Key
            public string brand = "Asus";
            public string model = "UX303-LN";
            public float screenSizeInInches = 13.3f;
            public int year = 2015;
            // Specs
            public string processor = "Intel Core i7-5500U";
            public int storageSizeInGB = 256;
            public int ramSizeInGB = 8;

            // Software
            public string operatingSystem = "Windows 8.1";
        }

        public class SocialMediaPost 
        {
            // Key
            public string username = "SomeUsername";
            public string content = "Doing things :)";
            public DateTime timestamp = DateTime.Now;
            public bool isPublic = true;

            // Interactions
            public int likes = 256;
            public int comments = 1024;
            public string[] hashtags = { "Doing", "Things" };
        }

        public class User
        {
            // Key
            public string username = "ThisIsAUsername";
            public string email = "Tim.Bob@gmail.com";

            // Personal info
            public string fullName = "Tim Bob";
            public int age = 25;

            // Meta
            public DateTime registrationDate = DateTime.Now;
            public bool isActive = true;
            public string[] interests = { "Sleeping", "Eating", "Staring" };
            public int friendsCount = 256;
        }

        public class ECommerceProduct
        {
            // Key info
            public string productName = "Some Phone X";
            public string brand = "PhoneProducer";
            public string description = "Literally the best smartphone";
            public DateTime releaseDate = new DateTime(2023, 3, 15);
            public string[] specifications = { "6.5-inch Display", "Snapdragon 865 Processor", "128GB Storage", "Quad Camera Setup" };

            // Price and availability
            public float price = 12999.99f;
            public int stockQuantity = 64;
            public bool isAvailable = true;

            // Store information
            public string category = "Electronics";
            public string subCategory = "Phones";
            public string productImageURI = "https://imagehost.com/image1.jpg";
        }

        public class ECommerceOrder
        {
            // Key info
            public int orderId = 1001;
            public DateTime orderDate = DateTime.Now;
            public float totalAmount = 499.99f;

            // Shipping info
            public string customerName = "This Guy";
            public string shippingAddress = "Some Street 123A, A City 9999";
            public string[] orderedProducts = { "Phone", "Tomato" };
            public bool isShipped = false;
            public DateTime estimatedDeliveryDate = DateTime.Now.AddDays(10);

            // Payment
            public string paymentMethod = "Credit Card";
            public string transactionId = "AD732583";
        }
    }
}
