// See https://aka.ms/new-console-template for more information
using csharp_fundamentals_primitive_types.Main;
using System;

SocialMediaPost secondPost = new SocialMediaPost();
Console.WriteLine(secondPost.content);
secondPost.content = "Dette er min andre post!";
Console.WriteLine(secondPost.content);

Person sebastian = new Person();
sebastian.Name = "Sebastian";
sebastian.Age = 22;

Console.WriteLine($"Does {sebastian.Name} have a cat?");
Console.WriteLine("Y/N");
switch (Console.ReadLine())
{
    case "Y":
    case "y":
        sebastian.HasACat = true;
        break;
    case "N":
    case "n":
        sebastian.HasACat = false;
        break;
    default: break;
}
if (sebastian.HasACat)
{
    Console.WriteLine($"{sebastian.Name} has a cat and is {sebastian.Age} years old.");
} else
{
    Console.WriteLine($"{sebastian.Name} does not have a cat and is {sebastian.Age} years old.");
}
