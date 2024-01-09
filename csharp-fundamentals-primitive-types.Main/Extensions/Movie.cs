namespace csharp_fundamentals_primitive_types.Extensions
{
    internal class Movie
    {
        public string? title = "2012";
        public string? type = "disaster movie";
        public DateOnly? year = new DateOnly(2012 , 1 , 1);
        public List<string> actors = new List<string> { "Tom Hanks" , "Meryl Streep" , "Denzel Washington" , "Viola Davis" , "Leonardo DiCaprio" };
    }
}
