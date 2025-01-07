using System;

namespace csharp_fundamentals_primitive_types.Main
{
    public class Core
    {
        public Core() { }

        public static int numOne = 8;
        public static int numTwo = 16;
        public static int numThree = 32;

        // 1. Change the value of the member below to be the result of adding numOne and numTwo together
        public int numOnePlusTwo = numOne + numTwo;

        // 2. Change the value of the member below to be the result of multiplying numThree by numTwo
        public int numThreeTimesNumTwo = numThree * numTwo;

        // 3. Change the value of the member below to be the result of dividing numThree by numOne
        public int numThreeDividedByNumOne = numThree / numOne;

        // 4. Change the value of the member below to be the result of subtracting numOne from numThree
        public int numThreeMinusNumOne = numThree - numOne;

        // 5. Change the value of the member below to be the sum of numOne, numTwo and numThree
        public int sum = numOne + numTwo + numThree;

        // 6. Change the value of the member below to be the sum of numOne, numTwo and numThree divided by numOne
        public int numBytes = (numOne + numTwo + numThree) / numOne;

        // 7. Create a public char member named lastLetter containing the last letter of the English alphabet
        public char lastLetter = 'Z';

        // 8. Create a public float member named pi that contains the value of pi to two decimal places
        public float pi = 3.14f;

        // 9. Create a public double member named piD that contains the value of pi to 5 decimal places
        public double piD = 3.14159;

        public static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string firstName = "Jane";
        public static string lastName = "Smith";

        // 10. Create a public member named fullName that contains the value of firstName and lastName concatenated together with a space in between
        public string fullName = firstName + " " + lastName;

        // 11. Fix the line below so that tenthLetter contains the tenth letter in the alphabet member above.
        public char tenthLetter = alphabet.ToCharArray().ElementAtOrDefault(9);

        // 12. Create a public string member named lowerAlphabet that contains the value of the alphabet member in all lower case characters
        // If you need help, look through the available String methods to find a relevant one here: https://www.w3schools.com/cs/cs_strings.php
        public string lowerAlphabet = alphabet.ToLower();

        // 13. Create a public integer member named alphabetLength that contains the number of characters that exist in the alphabet member
        // Use the documentation linked above if you need help
        public int alphabetLength = alphabet.Length;

        // 14. Create a public integer member named remainder that contains the remainder of dividing 15 by 8
        public int remainder = 15 - (8 * (15 / 8));
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
        public required string Make { get; set; }
        public required string Model { get; set; }
        public string? TransmissionType { get; set; }
        public int? NumberOfDoors { get; set; }
        public int? EngineLiters { get; set; }
        public string? EngineType { get; set; }
        public string? Colour { get; set; }
        public string? Registration { get; set; }
    }

    public class Movie
    {
        public required string Title { get; set; }
        public required int ReleaseYear { get; set; }
        public string? ReleaseDate { get; set; }
        public string? Description { get; set; }
        public List<string>? Genres { get; set; }
        public string? ImdbUrl { get; set; }
    }

    public class Computer
    {
        public required string Case { get; set; }
        public required string Motherboard { get; set; }
        public required string Cpu { get; set; }
        public required string Ram { get; set; }
        public required string PowerSupply { get; set; }
        public required List<string> Disks { get; set; }
        public string? Gpu { get; set; }
    }

    public class SocialMediaPost
    {
        public required string PostId { get; set; }
        public required string PosterId { get; set; }
        public required string PostDate { get; set; }
        public required string PostTitle { get; set; }

        public string? PostDescription { get; set; }
        public string? MediaUrl { get; set; }

        public int? Likes { get; set; }
        public int? Dislikes { get; set; }
    }

    public class User
    {
        public required string Uuid { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required DateOnly DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
    }

    public class ECommerceProduct
    {
        public required string Sku { get; set; }
        public required string Name { get; set; }
        public required float Price { get; set; }
        public required int Stock { get; set; }
        public string? Description { get; set; }
    }

    public class ECommerceOrder
    {
        public required string OrderId { get; set; }
        public required string CustomerId { get; set; }
        public required DateTime OrderTime { get; set; }
        public required string Sku { get; set; }
        public required int Amount { get; set; }
        public required float Price { get; set; }
        public required string DeliveryCountry { get; set; }
        public required string DeliveryAddress { get; set; }
    }

    public class TV
    {
        public required string Name { get; set; }
        public required string Manufacturer { get; set; }
        public required string PanelTechnology { get; set; }
        public required int ResolutionHeight { get; set; }
        public required float ResolutionWidth { get; set; }
        public required float Refreshrate { get; set; }
        public required float Size { get; set; }
        public required float Weight { get; set; }
    }

    public class CPU
    {
        public required string Name { get; set; }
        public required string Model { get; set; }
        public required string Manufacturer { get; set; }
        public required int Cores { get; set; }
        public required int Threads { get; set; }
        public required float ClockSpeed { get; set; }
        public required int Tdp { get; set; }
    }
}
