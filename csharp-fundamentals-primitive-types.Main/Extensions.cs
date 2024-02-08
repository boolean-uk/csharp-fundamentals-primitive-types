using System;

namespace csharp_fundamentals_primitive_types.Main
{

    // book
    public class Book
    {
        public String title = "A Game of Thrones";
        public int publishYear = 1996;
        public float price = 11.99f;
        public String isbn = "0-00-224584-1";
        public String author = "George R. R. Martin";
    }

    // Make, model, transmission type, number of doors, engine litres, engine type, colour, registration
    // Car
    public class Car
    {
        public String model = "Honda Civic";
        public String transmissionType = "Type";
        public int numOfDoors = 4;
        public int engineLeters = 10;
        public String engineType = "Type of Engine";
        public String colour = "Yellow";
        public bool registration = true;
    }

    // Movie
    public class Movie
    {
        public String title = "MovieName";
        public String director = "Harry Jones";
        public int duration = 120;
        public int rating = 4;
    }

    // Computer
    public class Computer
    {
        public String name = "EliteBook";
        public String OS = "Windows";
        public int bits = 36;
        public String color = "Grey";
    }

    // Social media post
    public class Post
    {
        public String user = "Harry";
        public String text = "Hi there!";
        public int likes = 100;
        public int dislikes = 1;
    }

    // User
    public class User
    {
        public int Id = 123545;
        public String name = "Harry";
        public String email = "harry@gmail.com";
        public String password = "passoword";
        public int followers = 100;
        public bool active = true;
    }

    // E-commerce product
    public class ECommerceProduct
    {
        public String name = "Apple";
        public float price = 1.5F;
        public String brand = "Rainbow";
    }

    // E-commerce order
    public class ECommerceOrder
    {
        public String user = "username";
        public List<String> products = new List<string> { "Apple", "Orange", "Pear" };
        public int amount = 3;
        public float totalSum = 15.0F;
    }

}