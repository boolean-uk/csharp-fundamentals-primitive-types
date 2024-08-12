namespace csharp_fundamentals_primitive_types.Models;

public class Movie
{
    public string title { get; set; } = "Titanic";
    public string description { get; set; } = "A movie about a woman occupying an entire door";
    public int year { get; set; } = 1997; //???? idk
    public List<string> StarringActors = ["Johnny Depp", "Ice Berg"];
}
