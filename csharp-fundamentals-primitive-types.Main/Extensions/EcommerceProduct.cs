namespace csharp_fundamentals_primitive_types.Extensions
{
    public enum productCategory { Game, Movie, Car }
    public class Product
    {
        public string product = "World Of Warcraft";
        public productCategory productCategory = productCategory.Game;
        public float price = 59.99f;
    }
}
