// See https://aka.ms/new-console-template for more information
using csharp_fundamentals_primitive_types.Main;

Console.WriteLine("Hello, World!");

string firstName = "Jane";
string lastName = "Smith";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
char tenthLetter = alphabet.ToCharArray().ElementAtOrDefault(9);
Console.WriteLine(tenthLetter);

string lowerAlphabet = Core.alphabet.ToLower();
Console.WriteLine(lowerAlphabet);
