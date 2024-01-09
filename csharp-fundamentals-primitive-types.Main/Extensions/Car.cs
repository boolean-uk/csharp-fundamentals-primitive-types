namespace csharp_fundamentals_primitive_types.Extensions
{
    public enum transmissionType { Automatic, Manual }
    public enum color { Red, Blue, Black, Green }

    public class Car
    {
        public string model = "Toyota";
        public transmissionType transmissionType = transmissionType.Automatic;
        public int numDoors = 4;
        public int litres = 40;
        public string engineType = "v8";
        public color color = color.Red;
        public string registration = "ABC123";
    }
}
