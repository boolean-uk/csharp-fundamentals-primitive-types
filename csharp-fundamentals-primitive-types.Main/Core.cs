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


        // 7. Create a public static char member named lastLetter containing the last letter of the English alphabet
        public char lastLetter = 'Z';


        // 8. Create a public static float member named pi that contains the value of pi to two decimal places
        public float pi = 3.14f;


        // 9. Create a public static double member named piD that contains the value of pi to 5 decimal places
        public double piD = 3.14159d;


        public static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string firstName = "Jane";
        public static string lastName = "Smith";

        // 10. Create a public static member named fullName that contains the value of firstName and lastName concatenated together with a space in between
        public string fullName = $"{firstName} {lastName}";


        // 11. Fix the line below so that tenthLetter contains the tenth letter in the alphabet member above.
        public char tenthLetter = alphabet.ToCharArray().ElementAtOrDefault(9);


        // 12. Create a public static string member named lowerAlphabet that contains the value of the alphabet member in all lower case characters
        // If you need help, look through the available String methods to find a relevant one here: https://www.w3schools.com/cs/cs_strings.php
        public string lowerAlphabet = alphabet.ToLower();


        // 13. Create a public static integer member named alphabetLength that contains the number of characters that exist in the alphabet member
        // Use the documentation linked above if you need help
        public int alphabetLength = alphabet.Length;


        // 14. Create a public static integer member named remainder that contains the remainder of dividing 15 by 8
        public int remainder = 15 % 8;
    }

    public class Book
    {
        public string title = "A Game of Thrones";
        public int publishYear = 1996;
        public float price = 11.99f;
        public string isbn = "0-00-2245784-1";
        public string author = "George R. R. Martin";
    }

    public class Car
    {
        public string make = "Tesla";
        public string model = "Dual-Motor AWD Cybertruck";
        public string transmissionType = "Single-speed fixed (15:1 ratio)";
        public int doorNumber = 4;
        public int engineCapacity = 0;
        public string engineType = "Powertrain";
        public string colour = "Neutral Gray";
    }

    public class Movie
    {
        public string title = "Ready Player One";
        public string director = "Steven Spielberg";
        public string distributor = "Warner Bros. Pictures";
        public string language = "English";
        public int runningTime = 140;
        public DateTime releaseYear = new DateTime(2018, 3, 11);

    }

    public class Computer
    {
        public string title = "Voyager II Elite";
        public string distributor = "Starforge Systems";
        public string cpu = "Intel Core i9-14900k";
        public string cpuCooler = "Deepcool LS720 360mm AIO Liquid Cooler";
        public string ram = "Teamgroup Delta RGB 64GB DDR5 6000 CL38 (2x32GB)";
        public string motherboard = "MSI Z790 Tomahawk Wifi DDR5";
        public string gpu = "GeForce RTX™ 4090 24GB";
        public string cables = "CableMod Pro ModMesh Sleeved Cable Extensions (Black)";
        public string storagePrimary = "2TB PCIe 4.0 NVME (min. 7,000 read)";
        public string storageSecondary = "2TB PCIe 4.0 NVME (min. 3,500 read)";
        public string powerSupply = "MSI MPG A1000G Gold PCIE5";
        public string fans = "6 x Deepcool FC 120mm";
        public string computerCase = "Lian Li PC-011 Dynamic Evo Mid-Tower (Black)";
        public string operativeSystem = "Windows 11 Home";
        public double price = 4599.99d;
    }
    
    public class SocialMediaPost
    {
        public string originalPoster = "Sebastian";
        public string content = "Dette er min første post!";
        public bool hasImage = false;
        public bool hasVideo = false;
        public int comments = 0;
        public int reposts = 2;
        public int likes = 13;
        public int views = 43;
        public DateTime postDate = new DateTime(2023, 1, 9, 10, 05, 0);

    }

    public class Person { 
        public string Name { get; set; }
        public int Age { get; set; }
        public bool HasACat { get; set; }

    }

}